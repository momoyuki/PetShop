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
    public partial class FrmBillProd : Form
    {
        private MySQLDBConnect iConnect;
        public FrmBillProd()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void Bt_Report_Click(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void LoadBill()
        {
            string ilbBillid = lb_BillID.Text.Trim();
            DataTable idtBillDetail;
            string isqlBillDetail = "SELECT tb_productsalebill.*,tb_product.Product_Des FROM tb_productsalebill,tb_product where Bill_ID = '" + ilbBillid + "' AND tb_productsalebill.Product_ID = tb_product.Product_ID";
                                   

            idtBillDetail = iConnect.SelectByCommand(isqlBillDetail);
            //////////////////////////////////////////////Load Company//////////////////////////////////////////////////////////
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            ////////////////////////////////////////////Load Bill Master//////////////////////////////////////////////////////////////
            DataTable idtbill;
            string isqlBill = "SELECT tb_bill.*,tb_employee.Em_Name FROM tb_bill,tb_employee where Bill_ID ='" + ilbBillid + "' AND tb_bill.Em_ID = tb_employee.Em_ID";
            idtbill = iConnect.SelectByCommand(isqlBill);

            ReportDocument rpt = new ReportDocument();
            //string iFolder = Application.ExecutablePath;
            rpt.Load("E:\\Petshop\\Resources\\CrBillProd.rpt");
            /////////////////////////////Main Detail/////////////////////////////////
            rpt.SetDataSource(idtBillDetail);
            /////////////////////////////Sub Company////////////////////////////////
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            ////////////////////////////Sub Bill Master////////////////////////////////
            rpt.Subreports["Bill_Sub_Report"].Database.Tables[0].SetDataSource(idtbill);
            rpt.Subreports["Bill_Sub_ReportM"].Database.Tables[0].SetDataSource(idtbill);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }
    }
}
