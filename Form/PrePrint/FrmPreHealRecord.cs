using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace Petshop
{
    public partial class FrmPreHealRecord : Form
    {
        private MySQLDBConnect iConnect;
        public FrmPreHealRecord()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }
        string ReportDate;
        string ReportToDate;
        string idtpDate;
        string idtpToDate;
        private void bt_Search_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            idtpDate = dTP_Date.Value.ToString("yyyy-MM-dd");
            idtpToDate = dTP_ToDate.Value.ToString("yyyy-MM-dd");
            SearchHealRecord();
        }

        private void SearchHealRecord()
        {
            string itxbPetID = "%%";
            if (CheckBox_PetID.Checked == true)
            {
                itxbPetID = txb_PetID.Text.Trim();
            }
            
            //////////////////////ข้อมูลองค์กร//////////////////////////
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            /////////////////////////////////////////////////////////
            

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ReportDate = dTP_Date.Value.ToString("dd MMMM yyyy");
            ReportToDate = dTP_Date.Value.ToString("dd MMMM yyyy");
            ///////////////////////////////////////////////////////////
            DataTable idtHead = new DataTable("date");
            DataRow dr = null;
            idtHead.Columns.Add(new DataColumn("ReportDate", typeof(string)));
            idtHead.Columns.Add(new DataColumn("ReportToDate", typeof(string)));
            dr = idtHead.NewRow();
            dr["ReportDate"] = ReportDate;
            dr["ReportToDate"] = ReportToDate;
            idtHead.Rows.Add(dr);
            ///////////////////////[[ส่วนบันทึกส่วนหลัก]]//////////////////////////
            DataTable idtHealRecord;
            string isqlHealRecord = "SELECT tb_healRecord.*,tb_petprofile.Pet_Name,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel,tb_employee.Em_Name " + 
                                   "FROM tb_healrecord,tb_petprofile,tb_employee "+
                                   "where tb_petprofile.Pet_ID = tb_healRecord.Pet_ID AND tb_employee.Em_ID = tb_healRecord.Em_ID AND tb_healRecord.Pet_ID like '" + itxbPetID + "'" +
                                   "AND (tb_healrecord.HealRecord_Date between '" + idtpDate + "' AND '" + idtpToDate + "') ";
            idtHealRecord = iConnect.SelectByCommand(isqlHealRecord);
            /////////////////////////ส่วนบริการ////////////////////////////////
            DataTable idtServiceRecord;
            string isqlServiceRecord = "SELECT tb_servicerecord.*,tb_service.Service_Des "+
                                        "FROM petshop.tb_servicerecord,tb_service "+
                                        "where tb_service.service_ID = tb_servicerecord.service_ID";
            idtServiceRecord = iConnect.SelectByCommand(isqlServiceRecord);
            ////////////////////////ส่วนยา///////////////////////////////////
            DataTable idtMediRecord;
            string isqlMediRecord = "SELECT tb_medirecord.*,tb_medicine.Medi_Des "+
                                    "FROM petshop.tb_medirecord,tb_medicine "+
                                    "where tb_medicine.Medi_ID = tb_medirecord.Medi_ID";
            idtMediRecord = iConnect.SelectByCommand(isqlMediRecord);

            ReportDocument rpt = new ReportDocument();
            //rpt.Load("D:\\Petshop\\CrHealRecord.rpt");
            rpt.Load("CrHealRecord.rpt");
            rpt.SetDataSource(idtHealRecord);
            rpt.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rpt.Subreports["ServiceRecord_Sub_Report"].Database.Tables[0].SetDataSource(idtServiceRecord);
            rpt.Subreports["MediRecord_Sub_Report"].Database.Tables[0].SetDataSource(idtMediRecord);
            rpt.Subreports["HealRecord_Sub_Report"].Database.Tables[0].SetDataSource(idtHealRecord);
            this.crViewerHealRecord.ReportSource = rpt;
            this.crViewerHealRecord.Refresh();
        }
    }
}
