using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace Petshop
{
    public partial class FrmBillDate : Form
    {
        private MySQLDBConnect iConnect;
        public FrmBillDate()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void Bt_Report_Click(object sender, EventArgs e)
        {
            loadBill();
        }

        private void loadBill()
        {
            string itxbUnitList = tb_UnitList.Text.Trim();
            string ilbHealDateID = lb_HealDateID.Text.Trim();
            DataTable idtBillDetail;
            string isqlBillDetail = "SELECT tb_healdate.*,tb_service.Service_Des FROM tb_healdate,tb_service where tb_HealDate.Pet_ID ='" + ilbHealDateID + "' AND tb_healdate.Service_ID = tb_service.Service_ID AND HealDate_Status = 0 Order By HealDate_Day asc limt '"+itxbUnitList+"'";

            idtBillDetail = iConnect.SelectByCommand(isqlBillDetail);
            //////////////////////////////////////////////Load Company//////////////////////////////////////////////////////////
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            ////////////////////////////////////////////Load Bill Master//////////////////////////////////////////////////////////////
            //DataTable idtbill;
           // string isqlBill = "";
           // idtbill = iConnect.SelectByCommand(isqlBill);

            ReportDocument rpt = new ReportDocument();
            //string iFolder = Application.ExecutablePath;
            rpt.Load("D:\\Petshop\\Resources\\CrBillDate.rpt");
            /////////////////////////////Main Detail/////////////////////////////////
            rpt.SetDataSource(idtBillDetail);
            /////////////////////////////Sub Company////////////////////////////////
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            ////////////////////////////Sub Bill Master////////////////////////////////
           // rpt.Subreports["Bill_Sub_Report"].Database.Tables[0].SetDataSource(idtBillDetail);
            rpt.Subreports["Date_Sub_ReportM"].Database.Tables[0].SetDataSource(idtBillDetail);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }
    }
}
