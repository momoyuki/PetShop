using Petshop.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Petshop
{
    public partial class FrmMM21 : Form
    {
        private TextBox _Textbox = new TextBox();
        private MySQLDBConnect iConnect;
         
        public FrmMM21(ref TextBox refTextbox)
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

        private void LoadCompany()
        {
            DataTable idtCompany;
            string isqlCommand = "SELECT * FROM `tb_company`";
            idtCompany = iConnect.SelectByCommand(isqlCommand);
            lbCompany.Text = idtCompany.Rows[0]["Company_ID"].ToString();
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            lbYear.Text = DateTime.Now.ToString("yy");
            lbCompany.Text = idtCompany.Rows[0]["Company_ID"].ToString();
        }

        private void LoadPetType()
        {
            DataTable idtPetType;
            string isqlCommand = "SELECT * FROM `tb_pettype`";
            idtPetType = iConnect.SelectByCommand(isqlCommand);
            cb_PetType.DisplayMember = idtPetType.Columns["PetType_Des"].ColumnName;
            cb_PetType.ValueMember = idtPetType.Columns["PetType_ID"].ColumnName;
            cb_PetType.DataSource = idtPetType;
         }

        private void LoadPetBreed()
        {
            string icbTypeID = cb_PetType.SelectedValue.ToString();
            if ((icbTypeID != "") || (icbTypeID != null))
            {
                
                DataTable idtPetBreed;
                string isqlCommand = "SELECT * FROM `tb_petbreed` where PetType_ID = " + icbTypeID + "";

                idtPetBreed = iConnect.SelectByCommand(isqlCommand);
                cb_PetBreed.DisplayMember = idtPetBreed.Columns["PetBreed_Des"].ColumnName;
                cb_PetBreed.ValueMember = idtPetBreed.Columns["PetBreed_ID"].ColumnName;
                cb_PetBreed.DataSource = idtPetBreed;
            }
        }
        private void LoadPetProfile()
        {
            string itxbSearch = txb_SearchPet.Text.Trim();
            DataTable itbPetProfile;
            string isqlCommand = "SELECT tb_petprofile.*,tb_petbreed.petbreed_des,tb_pettype.pettype_des FROM `tb_petprofile`,tb_petbreed,tb_pettype where tb_petprofile.petbreed_ID = tb_petbreed.petbreed_id AND tb_petprofile.pettype_id = tb_pettype.pettype_id";
            itbPetProfile = iConnect.SelectByCommand(isqlCommand);
            dGV_PetProfile.DataSource = itbPetProfile;
            dGV_PetProfile.Refresh();
        }

        private void bt_AddMember_Click(object sender, EventArgs e)
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
            if(CheckBox_Sterility.Checked == true) {
                iSterility = dTP_Sterility.Value.ToString("yyyy-MM-dd");
            }
            string idTPSterility = iSterility;
            string itbOwnerName = txb_NameOwner.Text.Trim();
            string itbOwnerAddr = Txb_Addr.Text.Trim();
            string itbOwnerTel = txb_TelOwner.Text.Trim();
            string ilbyear = lbYear.Text.Trim();
            string ilbCompany = lbCompany.Text.Trim();

           // if ((itbPetID == null) || (itbPetID == ""))
            //{
                DialogResult iConfirmResult = MessageBox.Show("ต้องการเพิ่มข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlCommand = "INSERT INTO `tb_petprofile` (`Pet_ID`, `Pet_Name`, `Pet_Sex`, `Pet_DOB`, `Pet_Color`, `PetType_ID`, `PetBreed_ID`, `Pet_Sterility`, `Owner_Name`, `Owner_Addr`, `Owner_Tel`) "+
                        "VALUES (CONCAT('" + ilbyear + ilbCompany + "', LPAD(  IFNULL( (SELECT SUBSTR(`pet_Id`, 5) FROM `tb_petProfile` AS `alias` WHERE SUBSTR(`pet_Id`, 1, 2) = ('" + ilbyear + "')  "+
                        "ORDER BY `pet_Id` DESC LIMIT 1 ) + 1, 1 ),  5, '0' )),'" + itbPetName + "', b'" + ilbSex + "', '" + idTPBorn + "', '" + itbPetColor + "', '" + icbPetTypeID + "', '" + icbPetBreedID + "', '" + idTPSterility + "', '" + itbOwnerName + "', '" + itbOwnerAddr + "', '" + itbOwnerTel + "')";
                    iConnect.Insert(isqlCommand);
                    cleatTxb();
                }
                LoadPetProfile();
            //}
        }

        private void cleatTxb()
        {
            txb_PetProfileID.Clear();
            txb_PetName.Clear();
            txb_PetColor.Clear();
            txb_NameOwner.Clear();
            txb_TelOwner.Clear();
            Txb_Addr.Clear();
            dTP_Born.Value = DateTime.Now;
        }

        private void cb_PetType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPetBreed();
        }
        private void FrmMM24_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_EditMember_Click(object sender, EventArgs e)
        {
            string itbPetID = txb_PetProfileID.Text.Trim();
            string itbPetName = txb_PetName.Text.Trim();
            //string icbPetSex = cb_Sex.SelectedValue.ToString();
            string ilbSex = lbSex.Text.Trim();
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

            if ((itbPetID != null) || (itbPetID != ""))
            {
                DialogResult iConfirmResult = MessageBox.Show("ต้องการแก้ไขข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlCommand = "UPDATE `tb_petprofile` SET `Pet_Name` = '" + itbPetName + "', `Pet_Sex` = b'" + ilbSex + "', `Pet_DOB` = '" + idTPBorn + "', `Pet_Color` = '" + itbPetColor + "', `PetType_ID` = '" + icbPetTypeID + "', `PetBreed_ID` = '" + icbPetBreedID + "', `Pet_Sterility` = '" + idTPSterility + "', `Owner_Name` = '" + itbOwnerName + "', `Owner_Addr` = '" + itbOwnerAddr + "', `Owner_Tel` = '" + itbOwnerTel + "' WHERE `tb_petprofile`.`Pet_ID` = '" + itbPetID + "'";
                    iConnect.Insert(isqlCommand);
                }
                LoadPetProfile();
            }
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
            if ((txb_PetProfileID.Text != null) && (txb_PetProfileID.Text != ""))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmMM22))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmMM22 iFrmMM21 = new FrmMM22();
                iFrmMM21.MdiParent = MainForm.ActiveForm;
                iFrmMM21.Show();
                iFrmMM21.txb_PetID.Text = txb_PetProfileID.Text;
                this.Close();
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
        }

        private void loadHealRecord()
        {
           string  iPetID = txb_PetProfileID.Text.Trim();
            DataTable idtHealRecord;
            string isqlHealRecord = "SELECT * FROM petshop.tb_healrecord where pet_ID = " + iPetID + "";
            idtHealRecord = iConnect.SelectByCommand(isqlHealRecord);
            dGV_HealRecord.DataSource = idtHealRecord;
            dGV_HealRecord.Refresh();
            lb_CountHealRecord.Text = idtHealRecord.Rows.Count.ToString();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            string iSearchBox = txb_SearchPet.Text.Trim();
            if((iSearchBox !="")||(iSearchBox !=null)){

                DataTable itbPetProfile;
                string isqlCommand = "SELECT tb_petprofile.*,tb_petbreed.petbreed_des,tb_pettype.pettype_des "+
                    "FROM `tb_petprofile`,tb_petbreed,tb_pettype where ( Pet_ID like '%"+iSearchBox+"%' OR Pet_Name like '%"+iSearchBox+"%' OR Owner_Name like '"+iSearchBox+"' ) AND (tb_petprofile.petbreed_ID = tb_petbreed.petbreed_id) AND (tb_petprofile.pettype_id = tb_pettype.pettype_id)";
                itbPetProfile = iConnect.SelectByCommand(isqlCommand);
                dGV_PetProfile.DataSource = itbPetProfile;
                dGV_PetProfile.Refresh();
            }
            else
            {
                LoadPetProfile();
            }
        }

        private void bt_HealDate_Click(object sender, EventArgs e)
        {
            if ((txb_PetProfileID.Text != null) && (txb_PetProfileID.Text != ""))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmMM23))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmMM23 iFrmMM23 = new FrmMM23();
                iFrmMM23.MdiParent = MainForm.ActiveForm;
                iFrmMM23.Show();
                iFrmMM23.lb_PetID.Text = txb_PetProfileID.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสัตว์ไข้","ไม่พบสัตว์ไข้");
            }
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
            //string itxbPetProfiles = txb_PetProfileID.Text.Trim();
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM22))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM22 iFrmMM21 = new FrmMM22();
            iFrmMM21.MdiParent = MainForm.ActiveForm;
            iFrmMM21.Show();
            iFrmMM21.lb_HealRecordID.Text = lb_HealRecordID.Text;
        }
        private void bt_HealDateDetail_Click(object sender, EventArgs e)
        {
            if ((lb_HealRecordID.Text != "") && (lb_HealRecordID.Text != null))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmMM23))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmMM23 iFrmMM23 = new FrmMM23();
                iFrmMM23.MdiParent = MainForm.ActiveForm;
                iFrmMM23.Show();
                iFrmMM23.lb_HealRecordID.Text = lb_HealRecordID.Text;
                iFrmMM23.lb_PetID.Text = txb_PetProfileID.Text;
            }
            
        }
        private void dGV_PetProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lb_HealRecordID.Text = "";
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
        }



    }
}
