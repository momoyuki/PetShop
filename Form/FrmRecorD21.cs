using Petshop.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Petshop
{
    public partial class FrmRecorD21 : Form
    {
        private TextBox _Textbox = new TextBox();
        private MySQLDBConnect iConnect;
         
        public FrmRecorD21(ref TextBox refTextbox)
        { 
            iConnect = new MySQLDBConnect();
            InitializeComponent();
            _Textbox = refTextbox;
        }
        private void bt_LoadProfile_Click(object sender, EventArgs e)
        {
            LoadData();
        }
         
        private void LoadData()
        {
           // LoadSex();
            LoadCompany();
            LoadPetProfile();
            LoadPetType();
            LoadPetBreed();
        }
        private void bt_remove_Click(object sender, EventArgs e)
        {
            string itxbPetProfileID = txb_PetProfileID.Text.ToString();

            DataTable idtCheckProfileID;
            string isqlCheckProfileID = "SELECT * FROM petshop.tb_petprofile where Pet_ID = '"+itxbPetProfileID+"' ";
            idtCheckProfileID = iConnect.SelectByCommand(isqlCheckProfileID);
            if (idtCheckProfileID.Rows.Count != 0)
            {
                 DialogResult iConfirmResult = MessageBox.Show("ต้องการลบข้อมูลสัตว์ใช่หรือไม่?", "ลบข้อมูลข้อมูล..", MessageBoxButtons.YesNo);
                 if (iConfirmResult == DialogResult.Yes)
                 {
                     string isqlreStatus = "UPDATE `petshop`.`tb_petprofile` SET `Status`=1 WHERE `Pet_ID`='"+itxbPetProfileID+"'";
                     iConnect.Insert(isqlreStatus);
                     clearTxb();
                 }
            }
            LoadPetProfile();
        }
        private void LoadHealDetail()
        {
                string itxbPetProfileID = txb_PetProfileID.Text.ToString();
                DataTable idtHealDetail;
                string isqlCommand = "SELECT  tb_healrecord.Pet_ID as Pet_ID,tb_medirecord.HealRecord_ID as HealRecord_ID,tb_medirecord.Medi_ID as ServiceMedi_ID, "
                                     + "tb_medicine.Medi_Des as ServiceMedi_Des "
                                     + "FROM tb_healrecord,tb_medirecord,tb_medicine where  tb_healrecord.Pet_ID = '" + itxbPetProfileID + "' AND tb_medirecord.Medi_ID = tb_medicine.Medi_ID "
                                     + "UNION "
                                     + "SELECT tb_healrecord.Pet_ID as Pet_ID ,tb_servicerecord.HealRecord_ID as HealRecord_ID,tb_servicerecord.Service_ID as ServiceMedi_ID, "
                                     + "tb_service.service_Des AS ServiceMedi_Des "
                                     + "FROM tb_healrecord,tb_servicerecord,tb_service where  tb_healrecord.Pet_ID = '" + itxbPetProfileID + "' AND tb_servicerecord.Service_ID = tb_service.Service_ID order by HealRecord_ID";

                idtHealDetail = iConnect.SelectByCommand(isqlCommand);
                dGV_HealDetail.DataSource = idtHealDetail;
                dGV_HealDetail.Refresh();
                lb_HealDetailCount.Text = idtHealDetail.Rows.Count.ToString();
        }

        private void LoadSex() // ญังไม่ได้เสร็จ มีปัญหา ในการ เพิ่ม เพศ ชาย หญิง
        {
            if (rb_F.Checked == true)
            {
                lbSex.Text = "0";               
            }
            else if (rb_M.Checked == true)
            {
                lbSex.Text = "1";
            }
        }
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bt_ServiceRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FrmMM24_Load(object sender, EventArgs e)
        {
            LoadData();
            nUDYear.Value = Convert.ToDecimal(lbYear.Text);
 
        }
        private void LoadCompany()
        {
            DataTable idtCompany;
            string isqlCommand = "SELECT * FROM `tb_company`";
            idtCompany = iConnect.SelectByCommand(isqlCommand);

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            lbYear.Text = DateTime.Now.ToString("yy");
            lbCompany.Text = "01";
            if (idtCompany.Rows.Count > 0)
            {
                lbCompany.Text = idtCompany.Rows[0]["Company_ID"].ToString();
            }
        }

        private void LoadPetType()
        {
            DataTable idtPetType;
            string isqlCommand = "SELECT * FROM `tb_pettype`";
            idtPetType = iConnect.SelectByCommand(isqlCommand);
            if (idtPetType.Rows.Count > 0)
            {
            cb_PetType.DisplayMember = idtPetType.Columns["PetType_Des"].ColumnName;
            cb_PetType.ValueMember = idtPetType.Columns["PetType_ID"].ColumnName;
            cb_PetType.DataSource = idtPetType;
            }
            
         }

        private void LoadPetBreed()
        {
            if (cb_PetType.SelectedValue != null)
            {
                string icbTypeID = cb_PetType.SelectedValue.ToString();
                if ((icbTypeID != "") && (icbTypeID != null))
                {
                    DataTable idtPetBreed;
                    string isqlCommand = "SELECT * FROM `tb_petbreed` where PetType_ID = " + icbTypeID + "";
                    idtPetBreed = iConnect.SelectByCommand(isqlCommand);
                    cb_PetBreed.DisplayMember = null;
                    cb_PetBreed.ValueMember = null;
                    cb_PetBreed.DataSource = null;

                    if (idtPetBreed.Rows.Count > 0)
                    {
                        cb_PetBreed.DisplayMember = idtPetBreed.Columns["PetBreed_Des"].ColumnName;
                        cb_PetBreed.ValueMember = idtPetBreed.Columns["PetBreed_ID"].ColumnName;
                        cb_PetBreed.DataSource = idtPetBreed;
                    }
                }
            }
            
        }
        private void LoadPetProfile()
        {
            string itxbSearch = txb_SearchPet.Text.Trim();
            DataTable idtPetProfile;
            string isqlCommand = "SELECT tb_petprofile.*,tb_petbreed.petbreed_des,tb_pettype.pettype_des FROM `tb_petprofile`,tb_petbreed,tb_pettype where tb_petprofile.petbreed_ID = tb_petbreed.petbreed_id AND tb_petprofile.pettype_id = tb_pettype.pettype_id AND status = 0";
            idtPetProfile = iConnect.SelectByCommand(isqlCommand);

                dGV_PetProfile.DataSource = idtPetProfile;
                dGV_PetProfile.Refresh();
                lb_PetCount.Text = idtPetProfile.Rows.Count.ToString();
            
        }
        string iAddEditMember;    
        private void bt_AddMember_Click(object sender, EventArgs e)
        {
            iAddEditMember = "AddMember";
            AddEditMember();
        }

        private void AddEditMember()
        {
            lbYear.Text = nUDYear.Value.ToString();
            epCheck.Clear();
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            Regex RegTel = new Regex(@"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{3,4}");
            
            if (!RegString.IsMatch(txb_PetName.Text))
            {
                epCheck.SetError(txb_PetName, "***กรุณาระบุชื่อสัตว์เลี้ยง");
            }
            else if (cb_PetType.SelectedValue == null)
            {
                epCheck.SetError(cb_PetType,"กรุณาเลือกประเภทของสัตว์");
            }else if(cb_PetBreed.SelectedValue == null)
            {
                epCheck.SetError(cb_PetBreed, "กรุณาเลือกพันธุ์ของสัตว์");
            }
            else if (!RegString.IsMatch(txb_PetColor.Text))
            {
                epCheck.SetError(txb_PetColor, "***กรุณาระบุสีของสัตว์");
            }
            else if ((rb_M.Checked != true) && (rb_F.Checked != true))
            {
                epCheck.SetError(lb_Sex, "กรุณาเลือกเพศของสัตว์");
            }
            else if (!RegString.IsMatch(txb_NameOwner.Text))
            {
                epCheck.SetError(txb_NameOwner, "***กรุณาระบุชื่อเจ้าของสัตว์");
            }
            else if (!RegTel.IsMatch(txb_TelOwner.Text))
            {
                epCheck.SetError(txb_TelOwner, "***กรุณาระบุเบอร์โทรศัพท์ติดต่อ ตัวอย่าง(658)154-1122 | 6581541122 | 658-154-1122) ");
            }
            else
            {
                string itbPetID = txb_PetProfileID.Text.Trim();
                string itbPetName = txb_PetName.Text.Trim();
                string ilbSex = lbSex.Text.Trim();
                // string icbPetSex = cb_Sex.SelectedValue.ToString();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                string idTPBorn = dTP_Born.Value.ToString("yyyy-MM-dd");
                string itbPetColor = txb_PetColor.Text.Trim();
                string icbPetTypeID = cb_PetType.SelectedValue.ToString();
                string icbPetBreedID = cb_PetBreed.SelectedValue.ToString();
                string iSterility = "0000-00-00";
                if (CheckBox_Sterility.Checked == true)
                {
                    iSterility = dTP_Sterility.Value.ToString("yyyy-MM-dd");
                }
                string idTPSterility = iSterility;
                string itbOwnerName = txb_NameOwner.Text.Trim();
                string itbOwnerAddr = Txb_Addr.Text.Trim();
                string itbOwnerTel = txb_TelOwner.Text.Trim();
                string ilbyear = lbYear.Text.Trim();
                string ilbCompany = lbCompany.Text.Trim();

                if (iAddEditMember == "AddMember")
                {
                    DialogResult iConfirmResult = MessageBox.Show("ต้องการเพิ่มข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlCommand = "INSERT INTO `tb_petprofile` (`Pet_ID`, `Pet_Name`, `Pet_Sex`, `Pet_DOB`, `Pet_Color`, `PetType_ID`, `PetBreed_ID`, `Pet_Sterility`, `Owner_Name`, `Owner_Addr`, `Owner_Tel`,status) " +
                            "VALUES (CONCAT('" + ilbyear + ilbCompany + "', LPAD(  IFNULL( (SELECT SUBSTR(`pet_Id`, 5) FROM `tb_petProfile` AS `alias` WHERE SUBSTR(`pet_Id`, 1, 2) = ('" + ilbyear + "')  " +
                            "ORDER BY `pet_Id` DESC LIMIT 1 ) + 1, 1 ),  5, '0' )),'" + itbPetName + "', b'" + ilbSex + "', '" + idTPBorn + "', '" + itbPetColor + "', '" + icbPetTypeID + "', '" + icbPetBreedID + "', '" + idTPSterility + "', '" + itbOwnerName + "', '" + itbOwnerAddr + "', '" + itbOwnerTel + "',b'0')";
                        iConnect.Insert(isqlCommand);
                        iAddEditMember = string.Empty;
                        clearTxb();
                    }
                }
                else if (iAddEditMember == "EditMember")
                {
                    if (txb_PetProfileID.Text == string.Empty)
                    {
                        epCheck.SetError(txb_PetProfileID, "***กรุณาระบุรหัสสัตว์");
                    }
                    else
                    {
                        DialogResult iConfirmResult = MessageBox.Show("ต้องการแก้ไขข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {
                            string isqlCommand = "UPDATE `tb_petprofile` SET `Pet_Name` = '" + itbPetName + "', `Pet_Sex` = b'" + ilbSex + "', `Pet_DOB` = '" + idTPBorn + "', `Pet_Color` = '" + itbPetColor + "', `PetType_ID` = '" + icbPetTypeID + "', `PetBreed_ID` = '" + icbPetBreedID + "', `Pet_Sterility` = '" + idTPSterility + "', `Owner_Name` = '" + itbOwnerName + "', `Owner_Addr` = '" + itbOwnerAddr + "', `Owner_Tel` = '" + itbOwnerTel + "' WHERE `tb_petprofile`.`Pet_ID` = '" + itbPetID + "'";
                            iAddEditMember = string.Empty;
                            iConnect.Insert(isqlCommand);
                        }
                    }

                }
            }
            LoadPetProfile();
        }

        private void clearTxb()
        {
            txb_PetProfileID.Clear();
            txb_PetName.Clear();
            txb_PetColor.Clear();
            txb_NameOwner.Clear();
            txb_TelOwner.Clear();
            Txb_Addr.Clear();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            nUDYear.Value =Convert.ToDecimal(DateTime.Now.ToString("yy"));

            dTP_Born.Value = DateTime.Now;

            lb_HealRecordID.Text = "";
            lb_HealDetailID.Text = "";
        }

        private void cb_PetType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPetBreed();
        }
       

        private void bt_EditMember_Click(object sender, EventArgs e)
        {
            iAddEditMember = "EditMember";
            AddEditMember();
        }

        private void rb_F_CheckedChanged(object sender, EventArgs e)
        {
            LoadSex();
        }

        private void rb_M_CheckedChanged(object sender, EventArgs e)
        {
            LoadSex();
        }
        private void bt_Service_Click(object sender, EventArgs e)
        {
            if ((txb_PetProfileID.Text != null) && (txb_PetProfileID.Text != string.Empty))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmNN21))
                    {
                        form.Activate();
                        return;
                    }
                }
                
                FrmNN21 iFrmMM21 = new FrmNN21();
                iFrmMM21.MdiParent = MainForm.ActiveForm;
                iFrmMM21.Show();
                iFrmMM21.txb_PetID.Text = txb_PetProfileID.Text;
                //this.Close();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสัตว์ไข้", "ไม่พบสัตว์ไข้");
            }
        }
        private void dTP_Born_ValueChanged(object sender, EventArgs e)
        {
            DateTime ToDate = DateTime.Now;

            DateDifference dDiff = new DateDifference(dTP_Born.Value, ToDate);
            lb_BirthDay.Text = dDiff.ToString("ปี", "เดือน", "วัน");
        }
        private void txb_PetProfileID_TextChanged(object sender, EventArgs e)
        {
            _Textbox.Text = txb_PetProfileID.Text;
            loadHealRecord();
            LoadHealDetail();
            loadDate();
            if ((txb_PetProfileID.Text != null) && (txb_PetProfileID.Text != string.Empty))
            {
                bt_Service.Enabled = true;
                bt_EditMember.Enabled = true;
                bt_remove.Enabled = true;
            }
            else
            {
                bt_Service.Enabled = false;
                bt_EditMember.Enabled = false;
                bt_remove.Enabled = false;
            }
        }

        private void loadDate()
        {
            string itxbPetProfileID = txb_PetProfileID.Text.Trim();
            DataTable idtDate;
            string isqlDate = "SELECT tb_healdate.Healdate_ID,tb_service.Service_Des,tb_healdate.healdate_Remark,tb_healdate.healDate_Day FROM tb_healdate,tb_service "+
            "where tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = '"+itxbPetProfileID+"'  order by HealDate_Status,HealDate_Day";
            idtDate = iConnect.SelectByCommand(isqlDate);
            dGV_HealDate.DataSource = idtDate;
            dGV_HealDate.Refresh();
            lb_HealDateCount.Text = idtDate.Rows.Count.ToString();
        }

        private void loadHealRecord()
        {
            string  itxbPetID = txb_PetProfileID.Text.Trim();
            DataTable idtHealRecord;
            string isqlHealRecord = "SELECT * FROM petshop.tb_healrecord where pet_ID='" + itxbPetID + "'";
            idtHealRecord = iConnect.SelectByCommand(isqlHealRecord);
            dGV_HealRecord.DataSource = idtHealRecord;
            dGV_HealRecord.Refresh();
            lb_CountHealRecord.Text = idtHealRecord.Rows.Count.ToString();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            PetSearch();
        }

        private void PetSearch()
        {
            string iSearchBox = txb_SearchPet.Text.Trim();
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");

            if (RegString.IsMatch(txb_SearchPet.Text))
            {
                DataTable itbPetProfile;
                string isqlCommand = "SELECT tb_petprofile.*,tb_petbreed.petbreed_des,tb_pettype.pettype_des " +
                    "FROM `tb_petprofile`,tb_petbreed,tb_pettype where ( Pet_ID like '%" + iSearchBox + "%' OR Pet_Name like '%" + iSearchBox + "%' OR Owner_Name like '%" + iSearchBox + "%' ) AND (tb_petprofile.petbreed_ID = tb_petbreed.petbreed_id) AND (tb_petprofile.pettype_id = tb_pettype.pettype_id) And Status = 0";
                itbPetProfile = iConnect.SelectByCommand(isqlCommand);
                dGV_PetProfile.DataSource = itbPetProfile;
                dGV_PetProfile.Refresh();
                lb_PetCount.Text = itbPetProfile.Rows.Count.ToString();
            }
            else
            {
                LoadPetProfile();
            }
        }
        private void bt_HealRecord_Click(object sender, EventArgs e)
        {
            if ((lb_HealRecordID.Text != string.Empty) && (lb_HealRecordID.Text != null))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmNN21))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmNN21 iFrmNN21 = new FrmNN21();
                iFrmNN21.MdiParent = MainForm.ActiveForm;
                iFrmNN21.Show();
                iFrmNN21.lb_HealRecordID.Text = lb_HealRecordID.Text;
            }
            //string itxbPetProfiles = txb_PetProfileID.Text.Trim();
            
        }
        private void dGV_HealRecord_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_HealRecord.SelectedRows)
            {
                lb_HealRecordID.Text = row.Cells["ccHealRecord_ID"].Value.ToString();
              
            }
        } 
        private void dGV_HealRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_HealRecord.Rows[e.RowIndex];
                lb_HealRecordID.Text = row.Cells["ccHealRecord_ID"].Value.ToString();
            }*/
        }
     /*   private void dGV_PetProfile_SelectionChanged(object sender, EventArgs e) //ไว้ทดสอบ
        {
            foreach (DataGridViewRow row in dGV_PetProfile.SelectedRows)
            {
                txb_PetProfileID.Text = row.Cells["ccPet_ID"].Value.ToString();
                txb_PetName.Text = row.Cells["ccPet_Name"].Value.ToString();
                //เพศ ccPet_Sex Combobox
                int isex = Convert.ToInt32(row.Cells["ccPet_Sex"].Value);
                if (isex == 0)
                {
                    rb_F.Checked = true;
                }
                else if (isex == 1)
                {
                    rb_M.Checked = true;
                }

                //วันเกิด ccPet_DOB DateTimePicker
                txb_PetColor.Text = row.Cells["ccPet_Color"].Value.ToString();
                //ประเภทสัตว์ ccPetType_ID  Combobox
                //พันธุ์สัตว์ ccPet_Breed_ID Combobox
                //ทำหมัน ccPet_Sterility DateTimePicker
                DateTime iSterility = Convert.ToDateTime(row.Cells["ccPet_Sterility"].Value);
                if (iSterility > DateTime.MinValue)
                {
                    CheckBox_Sterility.Checked = true;
                    //DateTime  iSterility = Convert.ToDateTime(row.Cells["ccPet_Sterility"].Value);
                    dTP_Sterility.Value = iSterility;
                }
                else
                {
                    CheckBox_Sterility.Checked = false;
                }
                txb_NameOwner.Text = row.Cells["ccOwner_Name"].Value.ToString();
                Txb_Addr.Text = row.Cells["ccOwner_Addr"].Value.ToString();
                txb_TelOwner.Text = row.Cells["ccOwner_Tel"].Value.ToString();
            }
        } */

        private void bt_HealRecordDetail_Click(object sender, EventArgs e)
        {
            if ((lb_HealRecordID.Text != string.Empty)&&(lb_HealRecordID.Text != null))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmNN21))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmNN21 iFrmNN21 = new FrmNN21();
                iFrmNN21.MdiParent = MainForm.ActiveForm;
                iFrmNN21.Show();
                iFrmNN21.lb_HealRecordID.Text = lb_HealDetailID.Text;
            }
            //string itxbPetProfiles = txb_PetProfileID.Text.Trim();
            
        }
        private void bt_HealDateDetail_Click(object sender, EventArgs e)
        {
            if ((lb_HealRecordID.Text != string.Empty) && (lb_HealRecordID.Text != null))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmRecorD22))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmRecorD22 iFrmMM23 = new FrmRecorD22();
                iFrmMM23.MdiParent = MainForm.ActiveForm;
                iFrmMM23.Show();
                iFrmMM23.lb_HealRecordID.Text = lb_HealDetailID.Text;
                iFrmMM23.lb_PetID.Text = txb_PetProfileID.Text;
            }
            
        }
        private void dGV_PetProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lb_HealRecordID.Text = "";
                lb_HealDetailID.Text = "";
                DataGridViewRow row = this.dGV_PetProfile.Rows[e.RowIndex];
                txb_PetProfileID.Text = row.Cells["ccPet_ID"].Value.ToString();
                txb_PetName.Text = row.Cells["ccPet_Name"].Value.ToString();
                //เพศ ccPet_Sex Combobox
                int isex = Convert.ToInt32(row.Cells["ccPet_Sex"].Value);
                if (isex == 0)
                {
                    rb_F.Checked = true;
                }
                else if (isex == 1)
                {
                    rb_M.Checked = true;
                }

                //วันเกิด ccPet_DOB DateTimePicker
                dTP_Born.Value = Convert.ToDateTime(row.Cells["ccPet_DOB"].Value);
                txb_PetColor.Text = row.Cells["ccPet_Color"].Value.ToString();
                //ประเภทสัตว์ ccPetType_ID  Combobox
                cb_PetType.SelectedValue = row.Cells["ccPetType_ID"].Value;

                //พันธุ์สัตว์ ccPetBreed_ID Combobox
                cb_PetBreed.SelectedValue = row.Cells["ccPetBreed_ID"].Value;

                //ทำหมัน ccPet_Sterility DateTimePicker
                DateTime iSterility = Convert.ToDateTime(row.Cells["ccPet_Sterility"].Value);
                if (iSterility > DateTime.MinValue)
                {
                    CheckBox_Sterility.Checked = true;
                    //DateTime  iSterility = Convert.ToDateTime(row.Cells["ccPet_Sterility"].Value);
                    dTP_Sterility.Value = iSterility;
                }
                else
                {
                    CheckBox_Sterility.Checked = false;
                }
                txb_NameOwner.Text = row.Cells["ccOwner_Name"].Value.ToString();
                Txb_Addr.Text = row.Cells["ccOwner_Addr"].Value.ToString();
                txb_TelOwner.Text = row.Cells["ccOwner_Tel"].Value.ToString();
            }
        }

        private void txb_PetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_PetType.Focus();
            }
        }

        private void cb_PetType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cb_PetBreed.Focus();
            }
        }

        private void cb_PetBreed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_PetColor.Focus();
            }
        }

        private void txb_PetColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rb_F.Select();
            }
        }

        private void txb_NameOwner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_TelOwner.Focus();
            }
        }

        private void txb_TelOwner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txb_Addr.Focus();
            }
        }



        private void dGV_HealDetail_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_HealDetail.SelectedRows)
            {
                lb_HealDetailID.Text = row.Cells["ccHealRecord_IDd"].Value.ToString();
            }
        }

        private void bt_ResetProfile_Click(object sender, EventArgs e)
        {
            clearTxb();
        }

        private void txb_SearchPet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PetSearch();
            }
        }

        private void bt_HealBill_Click(object sender, EventArgs e)
        {
            if ((txb_PetProfileID.Text != null) && (txb_PetProfileID.Text != string.Empty))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmNRePort31))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmNRePort31 iFrmNRePort31 = new FrmNRePort31();
                iFrmNRePort31.MdiParent = MainForm.ActiveForm;
                iFrmNRePort31.Show();
                iFrmNRePort31.txb_ReferID.Text = lb_HealRecordID.Text;
                //iFrmNRePort31.lb_PetID.Text = txb_PetProfileID.Text;
                //this.Close();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสัตว์ไข้", "ไม่พบสัตว์ไข้");
            }
        }

        private void bt_DetailBill_Click(object sender, EventArgs e)
        {
            if ((lb_HealRecordID.Text != string.Empty) && (lb_HealRecordID.Text != null))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmNRePort31))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmNRePort31 iFrmNRePort31 = new FrmNRePort31();
                iFrmNRePort31.MdiParent = MainForm.ActiveForm;
                iFrmNRePort31.Show();
                iFrmNRePort31.txb_ReferID.Text = lb_HealDetailID.Text;
            }
        }



        private void bt_HealDate_Click(object sender, EventArgs e)
        {
            if ((txb_PetProfileID.Text != null) && (txb_PetProfileID.Text != string.Empty))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmRecorD22))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmRecorD22 iFrmMM23 = new FrmRecorD22();
                iFrmMM23.MdiParent = MainForm.ActiveForm;
                iFrmMM23.Show();
                iFrmMM23.lb_HealRecordID.Text = lb_HealRecordID.Text;
                iFrmMM23.lb_PetID.Text = txb_PetProfileID.Text;
                //this.Close();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสัตว์ไข้", "ไม่พบสัตว์ไข้");
            }
        }

        private void cb_PetType_TextChanged(object sender, EventArgs e)
        {
            LoadPetBreed();
        }

        private void nUDYear_ValueChanged(object sender, EventArgs e)
        {
            lbYear.Text = nUDYear.Value.ToString();
        }

       
    }
}
