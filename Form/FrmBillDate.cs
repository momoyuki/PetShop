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
using System.Text.RegularExpressions;

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
            Regex Regint = new Regex(@"^\d{1,3}$");
            if(!Regint.IsMatch(txb_UnitList.Text.Trim()))
            {
                txb_UnitList.Text = "5";
            }
            string itxbUnitList = txb_UnitList.Text.Trim();
            string ilbPetID = lb_PetID.Text.Trim();
            DataTable idtDateDetail;
            string isqlDateDetail = "SELECT tb_healdate.*,tb_service.Service_Des FROM tb_healdate,tb_service where tb_HealDate.Pet_ID ='" + ilbPetID + "' AND tb_healdate.Service_ID = tb_service.Service_ID AND HealDate_Status = 0 Order By HealDate_Day asc limit "+itxbUnitList+"";

            idtDateDetail = iConnect.SelectByCommand(isqlDateDetail);
            //////////////////////////////////////////////Load Company//////////////////////////////////////////////////////////
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);

            ////////////////////////////////////////////Load Bill Master//////////////////////////////////////////////////////////////
            DataTable idtProfile;
            string isqlProfile = "SELECT * FROM tb_petprofile";
            idtProfile = iConnect.SelectByCommand(isqlProfile);


            ReportDocument rpt = new ReportDocument();
            //string iFolder = Application.ExecutablePath;
            //rpt.Load("D:\\Petshop\\Resources\\CrBillDate.rpt");
            rpt.Load("CrBillDate.rpt"); 
            /////////////////////////////Main Detail/////////////////////////////////
            rpt.SetDataSource(idtDateDetail);
            /////////////////////////////Sub Company////////////////////////////////
            rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            ////////////////////////////Sub Bill Master////////////////////////////////
           // rpt.Subreports["Bill_Sub_Report"].Database.Tables[0].SetDataSource(idtBillDetail);
            rpt.Subreports["Profile_Sub_Report"].Database.Tables[0].SetDataSource(idtProfile);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }

        private void lb_PetID_TextChanged(object sender, EventArgs e)
        {
            if ((lb_PetID.Text != string.Empty) && (lb_PetID.Text != null))
            {
                loadBill();
            }
        }

        private void FrmBillDate_Load(object sender, EventArgs e)
        {

        }
    }
}
