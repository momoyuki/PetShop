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
    public partial class FrmRePort32 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmRePort32()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            SearchReport();
        }

        private void SearchReport()
        {
            string idtpDate = dTP_Date.Value.ToString();
            string idtpToDate = dTP_ToDate.Value.ToString();
            string isqlOutlay = "SELECT tb_outlaydetail.*,tb_outlay.outlay_Detail,tb_employee.Em_Name FROM tb_outlaydetail,tb_outlay,tb_employee where tb_outlay.outlay_ID = tb_outlaydetail.outlay_ID AND tb_outlaydetail.Em_ID = tb_employee.Em_ID ";
            DataTable idtOutlay;
            idtOutlay = iConnect.SelectByCommand(isqlOutlay);


            ReportDocument rpt = new ReportDocument();
            rpt.Load("D:\\PetShop\\CrOutlay.rpt");
            rpt.SetDataSource(idtOutlay);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }
    }
}
