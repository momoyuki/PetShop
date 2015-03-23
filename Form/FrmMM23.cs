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
    public partial class FrmMM23 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmMM23()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void Bt_Print_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM35))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM35 iFrmMM35 = new FrmMM35();
            iFrmMM35.MdiParent = this;
            iFrmMM35.Show();
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
                string isqlHealDate = "SELECT tb_healdate.*,.tb_petprofile.pet_name,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel "+
                    "FROM tb_healdate,tb_petprofile where tb_healdate.Pet_ID = tb_petprofile.Pet_ID order by HealDate_Status,HealDate_Day";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();
            }
            if (rBt_contract.Checked == true)
            {
                string isqlHealDate = "SELECT tb_healdate.*,.tb_petprofile.pet_name,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel "+
                    "FROM tb_healdate,tb_petprofile where tb_healdate.Pet_ID = tb_petprofile.Pet_ID AND Healdate_Status = 0 order by HealDate_Status,HealDate_Day";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();

            }
            if (rBt_contracted.Checked == true)
            {
                string isqlHealDate = "SELECT tb_healdate.*,.tb_petprofile.pet_name,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel "+
                    "FROM tb_healdate,tb_petprofile where tb_healdate.Pet_ID = tb_petprofile.Pet_ID AND Healdate_Status = 1 order by HealDate_Status,HealDate_Day";
                idtHealDate = iConnect.SelectByCommand(isqlHealDate);
                dGV_HealDate.DataSource = idtHealDate;
                dGV_HealDate.Refresh();
            }
        }
        private void lb_HealRecordID_TextChanged(object sender, EventArgs e)
        {
            string lbHealRecordID = lb_HealRecordID.Text.Trim();

            if ((lbHealRecordID != null)&&(lbHealRecordID !=""))
            {
                DataTable idtHealRecord;
                string isqlCommand = "SELECT HealRecord_ID as HealRecord_ID,tb_medirecord.Medi_ID as ServiceMedi_ID, "
                                    + "tb_medicine.Medi_Des as ServiceMedi_Des "
                                    + "FROM tb_medirecord,tb_medicine where tb_medirecord.HealRecord_ID = '"+lbHealRecordID+"' AND tb_medirecord.Medi_ID = tb_medicine.Medi_ID "
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
        private void LoadService() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
        {
            DataTable idtService;
            string isqlCommand = "SELECT * FROM `tb_service`";
            idtService = iConnect.SelectByCommand(isqlCommand);
            cb_Service.DisplayMember = idtService.Columns["Service_Des"].ColumnName;
            cb_Service.ValueMember = idtService.Columns["Service_ID"].ColumnName;
            cb_Service.DataSource = idtService;
        }
        private void bt_AddHealDate_Click(object sender, EventArgs e)
        { //คลิกเพื่อบันทึก นัดหมาย
            AddHealDate();
         }

        private void AddHealDate()
        {
            string ilbHealDateID = lb_HealDateID.Text.Trim();
            
            string ilbPetID = lb_PetID.Text.Trim();
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            string icbService = cb_Service.SelectedValue.ToString();
            string itxbRemark = Txb_Remark.Text.Trim();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            string idTPHealDate = dTP_HealDate.Value.ToString("yyyy-MM-dd");
            Int32 itxbRemind = Convert.ToInt32(txb_Remind.Text.Trim());
            DateTime iDateHeal = dTP_HealDate.Value;
            DateTime Remind = iDateHeal.AddDays(itxbRemind);
            string iRemind = Remind.ToString("yyyy-MM-dd");

              if ((lb_PetID.Text != "") || (lb_PetID.Text != null))
            {
                string isqlAddHealDate = "INSERT INTO `petshop`.`tb_healdate` (`Pet_ID`, `HealRecord_ID`, `Service_ID`, `HealDate_Remark`, `HealDate_Day`, `HealDate_Remind`, `HealDate_Status`) " +
                "VALUES ('" + ilbPetID + "', '" + ilbHealRecordID + "', '" + icbService + "', '" + itxbRemark + "', '" + idTPHealDate + "', '" + iRemind + "', 0)";
                iConnect.Insert(isqlAddHealDate);

                /* DataTable idtHealDateID;
                 string isqlHealDateID = "SELECT HealDate_ID FROM `tb_healdate` ORDER BY `healDate_ID` DESC LIMIT 1";
                 idtHealDateID = iConnect.SelectByCommand(isqlHealDateID);
                 lb_HealDateID.Text = Convert.ToString(idtHealDateID.Rows[0].Field<UInt32>(0));*/
                MessageBox.Show("บันทึกการนัดหมายแล้ว");
                loadData();
            }
        }

        private void bt_HealDateEdit_Click(object sender, EventArgs e)
        {
            string ilbHealDateID = lb_HealDateID.Text.Trim();

            string ilbPetID = lb_PetID.Text.Trim();
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            string icbService = cb_Service.SelectedValue.ToString();
            string itxbRemark = Txb_Remark.Text.Trim();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            string idTPHealDate = dTP_HealDate.Value.ToString("yyyy-MM-dd");
            Int32 itxbRemind = Convert.ToInt32(txb_Remind.Text.Trim());
            DateTime iDateHeal = dTP_HealDate.Value;
            DateTime Remind = iDateHeal.AddDays(itxbRemind);
            string iRemind = Remind.ToString("yyyy-MM-dd");

            int iContract = -0;
            if (CheckBox_Contract.Checked == true)
            {
                iContract = 1;
            }else{
                iContract = 0;
            }

            if ((lb_HealDateID.Text != "") || (lb_HealDateID.Text != null))
            {
                string isqlAddHealDate = "UPDATE `tb_healdate` "+
                " SET Service_Id = '" + icbService + "', `HealDate_Remark`='" + itxbRemark + "', `HealDate_Day`='" + idTPHealDate + "', `HealDate_Remind`='" + iRemind + "', `HealDate_Status`=" + iContract.ToString() + " WHERE `HealDate_ID`='" + ilbHealDateID + "'";
                iConnect.Insert(isqlAddHealDate);
                MessageBox.Show("แก้ไขข้อมูลการนัดหมาย");
                loadData();
            }
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
                TimeSpan iDay = iRemind- iHealDate;
                txb_Remind.Text = iDay.Days.ToString();
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

      
    }
}
