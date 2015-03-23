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
    public partial class FrmBillreview : Form
    {
        private MySQLDBConnect iConnect;
        public FrmBillreview()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void Bt_Report_Click(object sender, EventArgs e)
        {
            LoadBill();
        }
        private void LoadBill() //ข้อมูลใบเสร็จ //Master
        {
            string ilbBillid = lb_BillID.Text.Trim();
            DataTable idtBillDetail;
            string isqlBillDetail = "SELECT tb_servicebill.Service_ID as ServiceMedi_ID,tb_service.Service_Des as ServiceMedi_Des ," +
                                    "tb_servicebill.Service_Bill_Price as  ServiceMedi_Price ," +
                                    "tb_servicebill.Service_Bill_Unit as ServiceMedi_Unit ," +
                                    "tb_servicebill.Service_Bill_Amt as ServiceMedi_Amt " +
                                    "From tb_servicebill,tb_service where tb_servicebill.Bill_ID = '" + ilbBillid + "' AND tb_servicebill.Service_ID = tb_service.Service_ID " +
                                    "union " +
                                    "SELECT tb_medibill.Medi_ID as ServiceMedi_ID,tb_medicine.Medi_Des as ServiceMedi_Des ," +
                                    "tb_medibill.Medi_Bill_Price as  ServiceMedi_Price ," +
                                    "tb_medibill.Medi_Bill_Unit as ServiceMedi_Unit ," +
                                    "tb_medibill.Medi_Bill_Amt as ServiceMedi_Amt " +
                                    "From tb_medibill,tb_medicine where tb_medibill.Bill_ID = '" + ilbBillid + "' AND tb_medibill.Medi_ID = tb_medicine.Medi_ID ";

            idtBillDetail = iConnect.SelectByCommand(isqlBillDetail);
            //////////////////////////////////////////////Load Company//////////////////////////////////////////////////////////
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            ////////////////////////////////////////////Load Bill Master//////////////////////////////////////////////////////////////
            DataTable idtbill;
            string isqlBill = "SELECT tb_bill.*,tb_employee.Em_Name FROM tb_bill,tb_employee where Bill_ID ='" + ilbBillid +"' AND tb_bill.Em_ID = tb_employee.Em_ID";
            idtbill = iConnect.SelectByCommand(isqlBill);
            
            ReportDocument rpt = new ReportDocument();
            //string iFolder = Application.ExecutablePath;
            rpt.Load("E:\\Petshop\\Petshop\\Resources\\CrBill.rpt");
            /////////////////////////////Main Detail/////////////////////////////////
            rpt.SetDataSource(idtBillDetail);
            /////////////////////////////Sub Company////////////////////////////////
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            ////////////////////////////Sub Bill Master////////////////////////////////
            rpt.Subreports["Bill_Sub_Report"].Database.Tables[0].SetDataSource(idtbill);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }


 
        private void FrmBillreview_Load(object sender, EventArgs e)
        {
        }
    }
}
