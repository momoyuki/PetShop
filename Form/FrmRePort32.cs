﻿using System;
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

            ///////////////////////////[[รายงานส่วนรายจ่าย]]//////////////////////////////////
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

            ReportDocument rpt = new ReportDocument();
            rpt.Load("D:\\PetShop\\CrOutlay.rpt");
            rpt.SetDataSource(idtOutlay);
            rpt.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rpt.Subreports["Outlay_Sub_Report"].Database.Tables[0].SetDataSource(idtOutlayTotal);
            //rpt.Subreports["Outlay_Sub_ReportA"].Database.Tables[0].SetDataSource(idtOutlayAmt);
            this.crViewerOutlay.ReportSource = rpt;
            this.crViewerOutlay.Refresh();
            //////////////////////////////////////////////////////////////////////////////////////////////
            //
            //
            //
            /////////////////////////////////////[[รายงานส่วนยา]]//////////////////////////////////////////
            DataTable idtService;
            string isqlService =      "SELECT tb_medirecord.Medi_ID as ProMedi_ID,tb_medicine.Medi_Des as ProMedi_Des, "
                                    + "sum(tb_medirecord.MediSale_Unit) as ProMedi_Unit,tb_medirecord.Medi_Sale as ProMedi_Sale, "
                                    + "sum(tb_medirecord.MediRecord_Total) as ProMedi_Total FROM tb_medirecord,tb_medicine,tb_healrecord "
                                    + "where (tb_healrecord.HealRecord_Date between '" + idtpDate + "' AND '" + idtpToDate + "') "
                                    + "AND (tb_medirecord.Medi_ID = tb_medicine.Medi_ID) group by ProMedi_ID";
            idtService = iConnect.SelectByCommand(isqlService);
            ///////////////////////////////////////////////////
            DataTable idtServiceTotal;
            string isqlServiceTotal = "SELECT sum(tb_medirecord.MediRecord_Total) as ProMedi_Total, "
                                    +"(sum(tb_medirecord.MediRecord_Total)-sum(tb_medirecord.MediSale_Unit)*tb_medicine.Medi_Price) "
                                    +"as ProMedi_Price,(sum(tb_medirecord.MediRecord_Total))-(sum(tb_medirecord.MediRecord_Total) "
                                    +"- sum(tb_medirecord.MediSale_Unit)*tb_medicine.Medi_Price) as ProMedi_PriceTotal "
                                    +"FROM tb_medirecord,tb_medicine,tb_healrecord "
                                    +"where tb_medirecord.Medi_ID = tb_medicine.Medi_ID AND tb_medirecord.HealRecord_ID = tb_healrecord.HealRecord_ID AND (tb_healrecord.HealRecord_Date between '" + idtpDate + "' AND '" + idtpToDate + "') ";
            idtServiceTotal = iConnect.SelectByCommand(isqlServiceTotal);
            /////////////////////////////////////////////////////////////
            ReportDocument rptService = new ReportDocument();
            rptService.Load("D:\\PetShop\\CrProMe.rpt");
            rptService.SetDataSource(idtService);
            rptService.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rptService.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rptService.Subreports["ProMedi_Sub_Report"].Database.Tables[0].SetDataSource(idtServiceTotal);

            this.crViewerMedi.ReportSource = rptService;
            this.crViewerMedi.Refresh();
            
           /* ////////////////////////////////[[รายงานส่วนสินค้า]]///////////////////////////////////////////////
            DataTable idtProductSale;
            string isqlProductSale = "SELECT tb_productsaledetail.Product_ID,tb_Product.Product_Des,sum(productsale_Unit) "+
            "as ProductSale_Unit,tb_productsaledetail.Product_Sale,sum(tb_productsaledetail.ProductSale_Total) as ProductSale_Total " +
            "FROM tb_Product,tb_productsale,tb_productsaledetail "+
            "WHERE (tb_productsale.ProductSale_Date between '"+idtpDate+"' AND '"+idtpToDate+"') "+
            "AND (tb_Product.Product_ID = tb_productsaledetail.Product_ID) group by product_ID ";
            idtProductSale = iConnect.SelectByCommand(isqlProductSale);
            /////////////////////////////////////////////////////////////////////////////////////
            DataTable idtProductTotal;
            string isqlProductTotal = "SELECT sum(tb_productsaledetail.ProductSale_Total) as income_Total " +
            "FROM tb_productsale,tb_productsaledetail " +
            "WHERE (tb_productsale.ProductSale_Date between '" + idtpDate + "' AND '" + idtpToDate + "') ";
            idtProductTotal = iConnect.SelectByCommand(isqlProductTotal);
            ReportDocument rptSerMe = new ReportDocument();
            ////////////////////////////////////////////////////////////////////////////////////
            rptSerMe.Load("D:\\PetShop\\CrIncome.rpt");
            rptSerMe.SetDataSource(idtProductSale);
            rptSerMe.Subreports["Head_Sub_Report"].Database.Tables[0].SetDataSource(idtHead);
            rptSerMe.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            rptSerMe.Subreports["income_Sub_Report"].Database.Tables[0].SetDataSource(idtProductTotal);

            this.crViewerProduct.ReportSource = rptSerMe;
            this.crViewerProduct.Refresh(); */
        }

        private void FrmRePort32_Load(object sender, EventArgs e)
        {

        }
    }
}
