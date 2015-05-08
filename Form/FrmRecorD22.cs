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
    public partial class FrmRecorD22 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmRecorD22()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void FrmMM23_Load(object sender, EventArgs e) //เมื่อมีการเปิดหน้าตานี้ครั้งแรก จะทำการโหลดข้อมูลทั้งหมด
        {
            loadData();
        }
        private void loadData()
        {
            LoadService();
            loadHealDate();
        }
        private void loadHealDate()
        {
            DataTable idtHealDate;
            if (rBt_All.Checked == true)
            {
                string isqlHealDate = "SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel " +
                    "FROM tb_healdate,tb_petprofile,tb_service where tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID  order by HealDate_Status,HealDate_Day";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();
            }
            else if (rBt_contract.Checked == true)
            {
                string isqlHealDate = "SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel " +
                     "FROM tb_healdate,tb_petprofile,tb_service where tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID AND Healdate_Status = 0 order by HealDate_Day";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();
            }
            else if (rBt_contracted.Checked == true)
            {
                string isqlHealDate = "SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel " +
                    "FROM tb_healdate,tb_petprofile,tb_service where tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID AND Healdate_Status = 1 order by HealDate_Day";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();
            }
            else if (rBt_Today.Checked == true)
            {
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                string iDateToday = DateTime.Now.ToString("yyyy-MM-dd");

                string isqlHealDate = "SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel "
                                    + " FROM tb_healdate,tb_petprofile,tb_service where tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID AND Healdate_Status = 0 "
                                    + " AND  HealDate_Remind = '" + iDateToday + "'"
                                    + " Union "
                                    + " SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel "
                                    + " FROM tb_healdate,tb_petprofile,tb_service where tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID AND Healdate_Status = 0 "
                                    + " AND  HealDate_Day = '" + iDateToday + "' Order By HealDate_ID";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();
            }
        }
        private void lb_HealRecordID_TextChanged(object sender, EventArgs e)
        {
            EnableAddBT();
            
        }
        private void LoadService() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
        {
            DataTable idtService;
            string isqlCommand = "SELECT * FROM `tb_service`";
            idtService = iConnect.SelectByCommand(isqlCommand);
            cb_Service.DisplayMember = idtService.Columns["Service_Des"].ColumnName;
            cb_Service.ValueMember = idtService.Columns["Service_ID"].ColumnName;
            cb_Service.DataSource = idtService;
        }
        string iAddEditHealDate;
        private void bt_AddHealDate_Click(object sender, EventArgs e)
        { //คลิกเพื่อบันทึก นัดหมาย
            iAddEditHealDate = "AddHealDate";
            AddEditHealDate();
        }
        private void bt_HealDateEdit_Click(object sender, EventArgs e)
        {
            iAddEditHealDate = "EditHealDate";
            AddEditHealDate();
        }

        private void AddEditHealDate()
        {
            epCheck.Clear();
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            Regex Regint = new Regex(@"^\d{1,3}$");
            if (lb_PetID.Text == string.Empty)
            {
                epCheck.SetError(lb_PetID, "ไม่พบรหัสสัตว์");
            }
            else if(lb_HealRecordID.Text == string.Empty) {
                epCheck.SetError(lb_HealRecordID, "ไม่พบรหัสการรักษา");
            }
            else if(cb_Service.SelectedValue == null)
            {
                epCheck.SetError(cb_Service,"กรุณาเลือกบริการที่นัดหมาย");
            }
            else if(!Regint.IsMatch(txb_Remind.Text)){
                epCheck.SetError(txb_Remind,"กรุณาระบุจำนวนวันก่อนถึงวันนัดหมาย");
                txb_Remind.Focus();
            }
            else
            {
                string ilbPetID = lb_PetID.Text.Trim();
                string ilbHealRecordID = lb_HealRecordID.Text.Trim();

                string icbService = cb_Service.SelectedValue.ToString();

                string itxbRemark = Txb_Remark.Text.Trim();

                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                string idTPHealDate = dTP_HealDate.Value.ToString("yyyy-MM-dd");
                string iRe = "-" + txb_Remind.Text.Trim();
                //MessageBox.Show(iRe);
                Int32 itxbRemind = Convert.ToInt32(iRe);
                DateTime iDateHeal = dTP_HealDate.Value;
                DateTime Remind = iDateHeal.AddDays(itxbRemind);
                string iRemind = Remind.ToString("yyyy-MM-dd");

                if (iAddEditHealDate == "AddHealDate")
                {
                    if ((lb_PetID.Text != "") || (lb_PetID.Text != null))
                    {
                        DialogResult iConfirmResult = MessageBox.Show("ต้องการเพิ่มข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {
                            string isqlAddHealDate = "INSERT INTO `petshop`.`tb_healdate` (`Pet_ID`, `HealRecord_ID`, `Service_ID`, `HealDate_Remark`, `HealDate_Day`, `HealDate_Remind`, `HealDate_Status`) " +
                            "VALUES ('" + ilbPetID + "', '" + ilbHealRecordID + "', '" + icbService + "', '" + itxbRemark + "', '" + idTPHealDate + "', '" + iRemind + "', 0)";
                            iConnect.Insert(isqlAddHealDate);
                            ClearTxb();
                            /* DataTable idtHealDateID;
                             string isqlHealDateID = "SELECT HealDate_ID FROM `tb_healdate` ORDER BY `healDate_ID` DESC LIMIT 1";
                             idtHealDateID = iConnect.SelectByCommand(isqlHealDateID);
                             lb_HealDateID.Text = Convert.ToString(idtHealDateID.Rows[0].Field<UInt32>(0));*/
                            MessageBox.Show("บันทึกการนัดหมายแล้ว");
                            loadData();
                        }
                    }
                }
                else if (iAddEditHealDate == "EditHealDate")
                {
                    string ilbHealDateID = lb_HealDateID.Text.Trim();
                    int iContract = -0;
                    if (CheckBox_Contract.Checked == true)
                    {
                        iContract = 1;
                    }
                    else
                    {
                        iContract = 0;
                    }
                    if ((lb_HealDateID.Text != "") || (lb_HealDateID.Text != null))
                    {
                        DialogResult iConfirmResult = MessageBox.Show("ต้องการเพิ่มข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {
                            string isqlAddHealDate = "UPDATE `tb_healdate` " +
                            " SET Service_Id = '" + icbService + "', `HealDate_Remark`='" + itxbRemark + "', `HealDate_Day`='" + idTPHealDate + "', `HealDate_Remind`='" + iRemind + "', `HealDate_Status`=" + iContract.ToString() + " WHERE `HealDate_ID`='" + ilbHealDateID + "'";
                            iConnect.Insert(isqlAddHealDate);
                            ClearTxb();
                            MessageBox.Show("แก้ไขข้อมูลการนัดหมาย");
                            loadData();
                        }
                    }
                }
            }
        }
        private void ClearTxb()
        {
            lb_PetID.Text = "";
            lb_HealRecordID.Text = "";
            lb_HealDateID.Text = "";
            Txb_Remark.Clear();
            CheckBox_Contract.Checked = false;
        }

 

        private void cb_Service_SelectionChangeCommitted(object sender, EventArgs e)
        {
           String iServiceID =  cb_Service.SelectedValue.ToString();
          // MessageBox.Show(iServiceID);
           DataTable idtServiceDate;
           string isqlServiceDate = "SELECT * FROM tb_service where Service_ID = '"+iServiceID+"'";
           idtServiceDate = iConnect.SelectByCommand(isqlServiceDate);
           Int32 i = Convert.ToInt32(idtServiceDate.Rows[0].Field<UInt32>(3));
           DateTime day = DateTime.Now.AddDays(i);
           dTP_HealDate.Value = day;
        }

      /*  private void dGV_HealDate_SelectionChanged(object sender, EventArgs e) 
        {
            foreach (DataGridViewRow row in dGV_HealDate.SelectedRows)
            {
                lb_HealDateID.Text = row.Cells["ccHealDate_ID"].Value.ToString();
                lb_PetID.Text = row.Cells["ccPet_ID"].Value.ToString();
                lb_HealRecordID.Text = row.Cells["ccHealRecord_ID"].Value.ToString();
                cb_Service.SelectedValue = row.Cells["ccService_ID"].Value.ToString();
                DateTime iHealDate = Convert.ToDateTime(row.Cells["ccHealDate_Day"].Value);
                dTP_HealDate.Value = iHealDate;
                DateTime iRemind = Convert.ToDateTime(row.Cells["ccHealDate_Remind"].Value);
                TimeSpan iDay = iHealDate - iRemind ;
                txb_Remind.Text = iDay.Days.ToString();
                Txb_Remark.Text = row.Cells["ccHeadDate_Remark"].Value.ToString();
            }
        } */

        private void dGV_HealDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_HealDate.Rows[e.RowIndex];
                lb_HealDateID.Text = row.Cells["ccHealDate_ID"].Value.ToString();
                lb_PetID.Text = row.Cells["ccPet_ID"].Value.ToString();
                lb_HealRecordID.Text = row.Cells["ccHealRecord_ID"].Value.ToString();
                cb_Service.SelectedValue = row.Cells["ccService_ID"].Value.ToString();
                DateTime iHealDate = Convert.ToDateTime(row.Cells["ccHealDate_Day"].Value);
                dTP_HealDate.Value = iHealDate;
                DateTime iRemind = Convert.ToDateTime(row.Cells["ccHealDate_Remind"].Value);
                TimeSpan iDay = iRemind - iHealDate;
                string iStringDay = iDay.Days.ToString();
                string iDays = iStringDay.Substring(1);
                txb_Remind.Text = iDays;
                Txb_Remark.Text = row.Cells["ccHeadDate_Remark"].Value.ToString();
                UInt64 iContract = Convert.ToUInt64(row.Cells["ccHealDate_Stats"].Value);
                if (iContract != 0)
                {
                    CheckBox_Contract.Checked = true;
                }
                else
                {
                    CheckBox_Contract.Checked = false;
                }
            }
        
        }

        private void rBt_All_CheckedChanged(object sender, EventArgs e)
        {
            loadHealDate();
        }

        private void rBt_contract_CheckedChanged(object sender, EventArgs e)
        {
            loadHealDate();
        }

        private void rBt_contracted_CheckedChanged(object sender, EventArgs e)
        {
            loadHealDate();
        }
        private void rBt_Today_CheckedChanged(object sender, EventArgs e)
        {
            loadHealDate();
        }
        private void bt_PrintDate_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmPreBillDate))
                {
                    form.Activate();
                    return;
                }
            }
            FrmPreBillDate iFrmPreBillDate = new FrmPreBillDate();
            iFrmPreBillDate.MdiParent = MainForm.ActiveForm;
            iFrmPreBillDate.Show();
            iFrmPreBillDate.lb_PetID.Text = lb_PetID.Text;
        }

        private void bt_PrintBill_Click(object sender, EventArgs e)
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            if((ilbHealRecordID !=null)&&(ilbHealRecordID !=string.Empty))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmBillSerMe))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmBillSerMe iFrmBillSerMe = new FrmBillSerMe();
                iFrmBillSerMe.MdiParent = MainForm.ActiveForm;
                iFrmBillSerMe.Show();
                iFrmBillSerMe.txb_ReferID.Text = lb_HealRecordID.Text;
                //iFrmNRePort31.lb_PetID.Text = .Text;
            }
            else
            {
                MessageBox.Show("ไม่พบรหัสประวัติการรักษา");
            }
        }

        private void bt_contracted_Click(object sender, EventArgs e)
        {
          for (int i = 0; dGV_HealDate.Rows.Count > i; i++)
                {
                    if (dGV_HealDate.Rows[i].Cells[0].Value != null)
                    {
                        String iHealDateID = dGV_HealDate.Rows[i].Cells[1].Value.ToString();
                        string isqlHealDate = "UPDATE `tb_healdate` SET `HealDate_Status`=1 WHERE `HealDate_ID`='"+iHealDateID+"'";
                        iConnect.Insert(isqlHealDate);

                    }
                }
          loadHealDate();
         }

        private void bt_contract_Click(object sender, EventArgs e)
        {
            for (int i = 0; dGV_HealDate.Rows.Count > i; i++)
            {
                if (dGV_HealDate.Rows[i].Cells[0].Value != null)
                {
                    String iHealDateID = dGV_HealDate.Rows[i].Cells[1].Value.ToString();
                    string isqlHealDate = "UPDATE `tb_healdate` SET `HealDate_Status`=0 WHERE `HealDate_ID`='" + iHealDateID + "'";
                    iConnect.Insert(isqlHealDate);
                }
            }
            loadHealDate();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
                Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            if (RegString.IsMatch(txb_Search.Text.Trim())){
                string itxbSearch = txb_Search.Text.ToString();
                DataTable idtSearch;
                Regex RegDate = new Regex(@"^[0-9]+|$");
                
                string isqlSearch = "SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel " +
                   "FROM tb_healdate,tb_petprofile,tb_service where (tb_petprofile.pet_name like '%" + itxbSearch + "%' OR tb_Service.Service_Des like '%" + itxbSearch + "%' ) AND tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID  order by HealDate_Status,HealDate_Day"; ;
                if(RegDate.IsMatch(itxbSearch))
                {
                     isqlSearch = "SELECT tb_healdate.*,tb_petprofile.pet_name,tb_service.Service_Des,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel " +
                                       "FROM tb_healdate,tb_petprofile,tb_service where (tb_HealDate.HealDate_Day like '%"+itxbSearch+"%' ) AND tb_healdate.Service_ID = tb_Service.Service_ID AND tb_healdate.Pet_ID = tb_petprofile.Pet_ID  order by HealDate_Status,HealDate_Day"; ;
                     MessageBox.Show("wwwss");
                }
             
                idtSearch = iConnect.SelectByCommand(isqlSearch);
                dGV_HealDate.DataSource = idtSearch;
                dGV_HealDate.Refresh();
            }
            else
            {
                loadData();
            }
        }

        private void lb_HealDateID_TextChanged(object sender, EventArgs e)
        {
            if((lb_HealDateID.Text !=null)&&(lb_HealDateID.Text != string.Empty))
            {
                bt_HealDateEdit.Enabled = true;
                bt_HealDateDel.Enabled = true;
                bt_PrintDate.Enabled = true;
            }
            else
            {
                bt_HealDateEdit.Enabled = false;
                bt_HealDateDel.Enabled = false;
                bt_PrintDate.Enabled = false;
            }
        }

        private void lb_PetID_TextChanged(object sender, EventArgs e)
        {
            EnableAddBT();
        }

        private void EnableAddBT()
        {
            if ((lb_PetID.Text != null) && (lb_PetID.Text != string.Empty) && (lb_HealRecordID.Text != null) && (lb_HealRecordID.Text != string.Empty))
            {
                bt_AddHealDate.Enabled = true;
                bt_PrintBill.Enabled = true;
                string lbHealRecordID = lb_HealRecordID.Text.Trim();
                if ((lbHealRecordID != null) && (lbHealRecordID != ""))
                {
                    DataTable idtHealRecord;
                    string isqlCommand = "SELECT HealRecord_ID as HealRecord_ID,tb_medirecord.Medi_ID as ServiceMedi_ID, "
                                        + "tb_medicine.Medi_Des as ServiceMedi_Des "
                                        + "FROM tb_medirecord,tb_medicine where tb_medirecord.HealRecord_ID = '" + lbHealRecordID + "' AND tb_medirecord.Medi_ID = tb_medicine.Medi_ID "
                                        + "UNION "
                                        + " SELECT HealRecord_ID as HealRecord_ID,tb_servicerecord.Service_ID as ServiceMedi_ID , "
                                        + "tb_service.service_Des AS ServiceMedi_Des "
                                        + "FROM tb_servicerecord,tb_service where tb_servicerecord.HealRecord_ID = '" + lbHealRecordID + "' AND tb_servicerecord.Service_ID = tb_service.Service_ID";
                    idtHealRecord = iConnect.SelectByCommand(isqlCommand);
                    dGV_HealRecord.DataSource = idtHealRecord;
                    dGV_HealRecord.Refresh();
                    lb_CountHealRecord.Text = idtHealRecord.Rows.Count.ToString();
                }
            }
            else
            {
                bt_AddHealDate.Enabled = false;
                bt_PrintBill.Enabled = false;
            }
        }

        private void bt_ResetRecord_Click(object sender, EventArgs e)
        {
            ClearTxb();
        }

        private void bt_HealDateDel_Click(object sender, EventArgs e)
        {
            if ((lb_HealDateID.Text != null) && (lb_HealDateID.Text != string.Empty))
            {
                string lbHealDate = lb_HealDateID.Text.Trim();
                 DialogResult iConfirmResult = MessageBox.Show("ต้องการเพิ่มข้อมูลสัตว์ใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                 if (iConfirmResult == DialogResult.Yes)
                 {
                     string isqlHealDate = "DELETE FROM `petshop`.`tb_healdate` WHERE `HealDate_ID`='" + lbHealDate + "'";
                     iConnect.Insert(isqlHealDate);
                     MessageBox.Show("ลบข้อมูลแล้ว");
                     ClearTxb();
                     loadHealDate();
                 }
            }
         }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
