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
    public partial class FrmPreMemberCard : Form
    {
        private MySQLDBConnect iConnect;
        public FrmPreMemberCard()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
           
            string itxbPetID = txb_PetID.Text.ToString();
            
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM petshop.tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);


            DataTable idtPetProfile;
            string isqlPetProfile;
            if ((txb_PetID.Text == string.Empty) || (txb_PetID.Text == null))
            {
                isqlPetProfile = "SELECT * FROM petshop.tb_petprofile limit 40";
            }
            else
            {
                isqlPetProfile = "SELECT * FROM petshop.tb_petprofile where pet_ID between '" + itxbPetID + "' AND '" + itxbPetID + "'+7";
            }
            idtPetProfile = iConnect.SelectByCommand(isqlPetProfile);

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            ReportDocument rpt = new ReportDocument();
           //rpt.Load("D:\\PetShop\\CrmemberCard.rpt");
           rpt.Load("CrmemberCard.rpt");
           rpt.SetDataSource(idtPetProfile);
           rpt.Subreports["Company_Sub_Report"].Database.Tables[0].SetDataSource(idtCompany);
            this.crViewerBloodtest.ReportSource = rpt;
            this.crViewerBloodtest.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
