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
    public partial class FrmNH21 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmNH21()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void FrmNH21_Load(object sender, EventArgs e)
        {
            loadHealRecord();
            loadHealService();
            loadHealMedi();
            loadPetProfiles();
        }
        private void LoadData()
        {
            loadHealRecord();
            loadHealService();
            loadHealMedi();
            loadPetProfiles();
        }
        private void bt_LoadData_Click(object sender, EventArgs e)
        {
            loadHealRecord();
            loadHealService();
            loadHealMedi();
            loadPetProfiles();
        }

        private void loadPetProfiles()
        {
            DataTable idtPetProfile;
            string itb_PetID = txb_PetID.Text.Trim();
            string isqlPetProfile = "SELECT * FROM petshop.`tb_petprofile` where Pet_ID ='" + itb_PetID + "'";  //โหลดข้อมูลสัตว์เจ้าของสัตว์ จากการค้นหารายชื่อ
            idtPetProfile = iConnect.SelectByCommand(isqlPetProfile);
            if ((idtPetProfile != null) && (idtPetProfile.Rows.Count > 0))
            {
                txb_PetName.Text = idtPetProfile.Rows[0].Field<string>(1);
                txb_OwnerName.Text = idtPetProfile.Rows[0].Field<string>(8);
            }
        }

        private void loadHealService()
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            DataTable idtSerivceRecord;
            string isqlServiceRecord = "SELECT tb_ServiceRecord.*,tb_Service.Service_Des FROM tb_service,tb_ServiceRecord WHERE (tb_ServiceRecord.HealRecord_ID = '" + ilbHealRecordID + "' AND tb_service.Service_ID = tb_ServiceRecord.Service_ID)";
            idtSerivceRecord = iConnect.SelectByCommand(isqlServiceRecord);
            //if ((idtSerivceRecord != null) && (idtSerivceRecord.Rows.Count > 0))
            // {
            dGV_Service.DataSource = idtSerivceRecord;
            dGV_Service.Refresh();

            DataTable idtSumService;
            string isqlSumService = "SELECT sum(Service_Amt) as ServiceAmt FROM tb_ServiceRecord WHERE tb_ServiceRecord.HealRecord_ID = '" + ilbHealRecordID + "' ";
            idtSumService = iConnect.SelectByCommand(isqlSumService);
            lb_ServiceAmt.DataBindings.Clear();
            Binding b = new Binding("Text", idtSumService, "ServiceAmt");
            lb_ServiceAmt.DataBindings.Add(b);
            // }
        }

        private void loadHealMedi()
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            DataTable idtMediRecord;
            string isqlMediRecord = "SELECT tb_MediRecord.*,tb_medicine.Medi_Des  FROM tb_Medicine,tb_MediRecord WHERE (tb_MediRecord.HealRecord_ID = '" + ilbHealRecordID + "' AND tb_Medicine.Medi_ID = tb_MediRecord.Medi_ID)";
            idtMediRecord = iConnect.SelectByCommand(isqlMediRecord);
            // if ((idtMediRecord != null) && (idtMediRecord.Rows.Count > 0))
            //  {
            dGV_Medi.DataSource = idtMediRecord;
            dGV_Medi.Refresh();

            DataTable idtSumMedi;
            string isqlSumMedi = "SELECT sum(MediRecord_total) as MediAmt  FROM tb_MediRecord WHERE HealRecord_ID = '" + ilbHealRecordID + "' ";
            idtSumMedi = iConnect.SelectByCommand(isqlSumMedi);
            lb_MediAmt.DataBindings.Clear();
            Binding b = new Binding("Text", idtSumMedi, "MediAmt");
            lb_MediAmt.DataBindings.Add(b);
            // }
        }

        private void loadHealRecord()
        {
            string ilbHealRecordid = lb_HealRecordID.Text.Trim();
            if ((ilbHealRecordid != "") && (ilbHealRecordid != null))
            {
                DataTable idtHealRecord;
                string isqlHealRecord = "SELECT tb_healrecord.*,tb_employee.Em_Name FROM tb_healrecord,tb_employee where HealRecord_ID = " + ilbHealRecordid + " AND tb_healRecord.Em_ID = tb_Employee.Em_ID";
                idtHealRecord = iConnect.SelectByCommand(isqlHealRecord);
                if (idtHealRecord.Rows.Count > 0)
                {
                    txb_PetID.Text = idtHealRecord.Rows[0].Field<string>(1).ToString();
                    txb_Em.Text = idtHealRecord.Rows[0].Field<string>(13).ToString();
                    //////
                    txb_HealRecordSymptom.Text = idtHealRecord.Rows[0].Field<string>(3);
                    txb_HealRecordRemark.Text = idtHealRecord.Rows[0].Field<string>(4);

                    txb_Weight.Text = idtHealRecord.Rows[0].Field<decimal>(5).ToString();
                    txb_Temp.Text = idtHealRecord.Rows[0].Field<decimal>(6).ToString();
                    txb_HR.Text = idtHealRecord.Rows[0].Field<decimal>(7).ToString();
                    txb_RR.Text = idtHealRecord.Rows[0].Field<decimal>(8).ToString();
                    dTP_HealRecordDate.Value = Convert.ToDateTime(idtHealRecord.Rows[0].Field<DateTime>(9));

                    txb_HealRecordTotal.Text = idtHealRecord.Rows[0].Field<decimal>(10).ToString();
                    txb_HealRecordDC.Text = idtHealRecord.Rows[0].Field<decimal>(11).ToString();
                    txb_HealRecordNet.Text = idtHealRecord.Rows[0].Field<decimal>(12).ToString();
                }
            }
        }

        private void lb_HealRecordID_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            if ((lb_HealRecordID.Text != null)&&(lb_HealRecordID.Text != string.Empty))
            {
                bt_PrintBill.Enabled = true;
                bt_PrintDate.Enabled = true;
            }
            else
            {
                bt_PrintBill.Enabled = false;
                bt_PrintDate.Enabled = false;
            }
        }

        private void bt_PrintDate_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD22))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD22 iFrmRecorD22 = new FrmRecorD22();
            iFrmRecorD22.MdiParent = MainForm.ActiveForm;
            iFrmRecorD22.lb_HealRecordID.Text = lb_HealRecordID.Text;
            iFrmRecorD22.lb_PetID.Text = txb_PetID.Text;
            iFrmRecorD22.Show(); 
        }

        private void bt_PrintBill_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmNRePort31))
                {
                    form.Activate();
                    return;
                }
            }
            FrmNRePort31 iFrmMM341 = new FrmNRePort31();
            iFrmMM341.MdiParent = MainForm.ActiveForm;
            iFrmMM341.txb_ReferID.Text = lb_HealRecordID.Text;
            iFrmMM341.Show();  
        }

        
    }
}
