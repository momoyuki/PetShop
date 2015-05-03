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
        string ReportDate;
        string ReportToDate;
        private void bt_Search_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ReportDate = dTP_Date.Value.ToString("dd MMMM yyyy");
            ReportToDate = dTP_Date.Value.ToString("dd MMMM yyyy");
            SearchReport();
        }

        private void SearchReport()
        {
            //////////////////////ข้อมูลองค์กร//////////////////////////
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            ////////////////////ช่วงเวลาที่โหลดข้อมูล//////////////////////////
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            string idtpDate = dTP_Date.Value.ToString("yyyy-MM-dd");
            string idtpToDate = dTP_ToDate.Value.ToString("yyyy-MM-dd");
            ///////////////////////////[[รายงานส่วนแรก]]//////////////////////////////////
            DataTable idtOutlay;
            string isqlOutlay = "SELECT tb_outlaydetail.*,tb_outlay.outlay_Detail,tb_employee.Em_Name FROM tb_outlaydetail,tb_outlay,tb_employee where tb_outlay.outlay_ID = tb_outlaydetail.outlay_ID AND tb_outlaydetail.Em_ID = tb_employee.Em_ID AND (STR_TO_DATE(`outlayDetail_Date`,'%Y-%m-%d') between  '" + idtpDate + "' AND  '" + idtpToDate + "' )";
            idtOutlay = iConnect.SelectByCommand(isqlOutlay);
            ////////////////////แบบที่สอง/////////////////////////
            //DataTable idtOutlayAmt;
            //string isqlOutlayAmt = "SELECT tb_outlaydetail.outlay_ID,tb_outlay.outlay_Detail,tb_outlaydetail.outlayDetail_Amt FROM tb_outlaydetail,tb_outlay where tb_outlay.outlay_ID = tb_outlaydetail.outlay_ID  AND (STR_TO_DATE(`outlayDetail_Date`,'%Y-%m-%d') between  '" + idtpDate + "' AND  '" + idtpToDate + "' ) group by Outlay_ID";
            //idtOutlayAmt = iConnect.SelectByCommand(isqlOutlayAmt);
            ////////////////////////////////////////////////////
            DataTable idtOutlayTotal;
            string isqlOutlayTotal = "SELECT sum(outlayDetail_Amt) as outlayDetail_Total FROM petshop.tb_outlaydetail where (STR_TO_DATE(`outlayDetail_Date`,'%Y-%m-%d') between  '" + idtpDate + "' AND  '" + idtpToDate + "' )";
            idtOutlayTotal = iConnect.SelectByCommand(isqlOutlayTotal);
            ///////////////////ประกาศช่วงบนหัวเอกสาร///////////////////////
            DataTable idtHead = new DataTable("date");
            DataRow dr = null;
            idtHead.Columns.Add(new DataColumn("ReportDate", typeof(string)));
            idtHead.Columns.Add(new DataColumn("ReportToDate", typeof(string)));
            dr = idtHead.NewRow();
            
            dr["ReportDate"] = ReportDate;
            dr["ReportToDate"] = ReportToDate;
            idtHead.Rows.Add(dr);
            /////////////////////////////////////////////////////////
            ReportDocument rpt = new ReportDocument();
            rpt.Load("CrOutlay.rpt");
            rpt.SetDataSource(idtOutlay);
            rpt.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rpt.Subreports["Outlay_Sub_Report"].Database.Tables[0].SetDataSource(idtOutlayTotal);
            //rpt.Subreports["Outlay_Sub_ReportA"].Database.Tables[0].SetDataSource(idtOutlayAmt);
           
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
            /////////////////////////////////////[[รายงานส่วนที่ 2]]//////////////////////////////////////////
            DataTable idtService;
            string isqlService = "SELECT tb_medirecord.Medi_ID as Product_ID,tb_medicine.Medi_Des as Product_Des, "
                                    + "sum(tb_medirecord.MediSale_Unit) as ProductSale_Unit,tb_medirecord.Medi_Sale as Product_Sale, "
                                    + "sum(tb_medirecord.MediRecord_Total) as ProductSale_Total FROM tb_medirecord,tb_medicine,tb_healrecord "
                                    + "where (tb_healrecord.HealRecord_Date between '" + idtpDate + "' AND '" + idtpToDate + "') "
                                    + "AND (tb_medirecord.Medi_ID = tb_medicine.Medi_ID) group by Product_ID";
            idtService = iConnect.SelectByCommand(isqlService);
            ///////////////////////////////////////////////////
            DataTable idtServiceTotal;
            string isqlServiceTotal = "SELECT sum(tb_medirecord.MediRecord_Total) as income_Total "
                                     +"FROM tb_medirecord,tb_healrecord "
                                     +"WHERE (tb_healrecord.HealRecord_Date between '" + idtpDate + "' AND '" + idtpToDate + "')";
            idtServiceTotal = iConnect.SelectByCommand(isqlServiceTotal);
            /////////////////////////////////////////////////////////////
            ReportDocument rptService = new ReportDocument();
            rptService.Load("CrIncome.rpt");
            rptService.SetDataSource(idtService);
            rptService.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rptService.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rptService.Subreports["income_Sub_Report"].Database.Tables[0].SetDataSource(idtServiceTotal);

            this.crystalReportViewer2.ReportSource = rptService;
            this.crystalReportViewer2.Refresh();
            
            ////////////////////////////////[[รายงานส่วนที่ 3]]///////////////////////////////////////////////
            DataTable idtProductSale;
            string isqlProductSale = "SELECT tb_productsaledetail.Product_ID,tb_Product.Product_Des,sum(productsale_Unit) "+
            "as ProductSale_Unit,tb_productsaledetail.Product_Sale,sum(tb_productsaledetail.ProductSale_Total) as ProductSale_Total " +
            "FROM tb_Product,tb_productsale,tb_productsaledetail "+
            "WHERE (tb_productsale.ProductSale_Date between '"+idtpDate+"' AND '"+idtpToDate+"') "+
            "AND (tb_Product.Product_ID = tb_productsaledetail.Product_ID) group by product_ID";
            idtProductSale = iConnect.SelectByCommand(isqlProductSale);
            /////////////////////////////////////////////////////////////////////////////////////
            DataTable idtProductTotal;
            string isqlProductTotal = "SELECT sum(tb_productsaledetail.ProductSale_Total) as income_Total " +
            "FROM tb_productsale,tb_productsaledetail " +
            "WHERE (tb_productsale.ProductSale_Date between '" + idtpDate + "' AND '" + idtpToDate + "') ";
            idtProductTotal = iConnect.SelectByCommand(isqlProductTotal);
            ReportDocument rptSerMe = new ReportDocument();
            ////////////////////////////////////////////////////////////////////////////////////
            rptSerMe.Load("CrIncome.rpt");
            rptSerMe.SetDataSource(idtProductSale);
            rptSerMe.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rptSerMe.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rptSerMe.Subreports["income_Sub_Report"].Database.Tables[0].SetDataSource(idtProductTotal);

            this.crystalReportViewer3.ReportSource = rptSerMe;
            this.crystalReportViewer3.Refresh();
        }

        private void FrmRePort32_Load(object sender, EventArgs e)
        {

        }
    }
}
