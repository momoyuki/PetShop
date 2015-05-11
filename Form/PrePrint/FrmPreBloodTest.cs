using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Petshop
{
    public partial class FrmPreBloodTest : Form
    {
        private MySQLDBConnect iConnect;
        public FrmPreBloodTest()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            SearchBloodTest();
        }

        private void SearchBloodTest()
        {
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);

            string ilbBloodTestID = lb_BloodTestID.Text.Trim();
            DataTable idtBloodTest;
            string isqlBloodTest = "SELECT tb_bloodtest.*,tb_employee.Em_Name,tb_petprofile.Pet_Name,tb_petprofile.Owner_Name,tb_petprofile.Owner_Tel FROM petshop.tb_bloodtest,tb_employee,tb_petprofile "
                + "where tb_bloodtest.BloodTest_ID = '"+ilbBloodTestID+"'  AND tb_petprofile.Pet_ID = tb_bloodtest.Pet_ID AND tb_bloodtest.Em_ID = tb_employee.Em_ID";
            idtBloodTest = iConnect.SelectByCommand(isqlBloodTest);

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            ReportDocument rpt = new ReportDocument();
            //rpt.Load("D:\\Petshop\\CrBloodTest.rpt");
            rpt.Load("CrBloodTest.rpt");
            rpt.SetDataSource(idtBloodTest);
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            this.crViewerBloodtest.ReportSource = rpt;
            this.crViewerBloodtest.Refresh();
        }

        private void lb_BloodTestID_TextChanged(object sender, EventArgs e)
        {
            SearchBloodTest();
        }
    }
}
