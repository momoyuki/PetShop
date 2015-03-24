using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Petshop
{
    public partial class FrmMM16 : Form
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        DataTable idtCompany;
        public FrmMM16()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }

        private void bt_LoadCompany_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string isqlCommand = "SELECT * FROM `tb_company`";
            idtCompany = iConnect.SelectByCommand(isqlCommand);
            if (idtCompany.Rows.Count >0) {
            txb_CoID.Text = idtCompany.Rows[0]["Company_ID"].ToString();
            txb_Company_Name.Text = idtCompany.Rows[0]["Company_Name"].ToString();
            txb_CompanyAddr.Text = idtCompany.Rows[0]["Company_Addr"].ToString();
            txb_CompanyTel.Text = idtCompany.Rows[0]["Company_Tel"].ToString();
            txb_CompanyOwner.Text = idtCompany.Rows[0]["Company_Own"].ToString();
            txb_CoService.Text = idtCompany.Rows[0]["CoService"].ToString();
            txb_CoSale.Text = idtCompany.Rows[0]["CoSale"].ToString();
            txb_CoBill.Text = idtCompany.Rows[0]["CoBill"].ToString();
            lb_CoIDH.Text = idtCompany.Rows[0]["Company_ID"].ToString();
            string FP = idtCompany.Rows[0]["CoLogo"].ToString();
            picBoxLogo.Image = Image.FromFile(FP);
                }
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            string itxbCompanyID = txb_CoID.Text.Trim();
            string ilbCoID = lb_CoIDH.Text.Trim();
            string itxbCompanyName = txb_Company_Name.Text.Trim();
            string itxbCompanyAddr = txb_CompanyAddr.Text.Trim();
            string itxbCompanyTel = txb_CompanyTel.Text.Trim();
            string itxbCompanyOwner = txb_CompanyOwner.Text.Trim(); 
            string itxbCoService= txb_CoService.Text.Trim(); 
            string itxbCoSale= txb_CoSale.Text.Trim();
            string itxbCoBill = txb_CoBill.Text.Trim();
           
            DialogResult iConfirmResult = MessageBox.Show("บันทึกข้อมูลองค์กร?", "Insert..", MessageBoxButtons.YesNo);
             if (iConfirmResult == DialogResult.Yes)
             {
                     if (idtCompany.Rows.Count > 0)
                     {
                         string isqlCompanyUpdate = "UPDATE `tb_company` SET `Company_ID`='" + itxbCompanyID + "', `Company_Name`='" + itxbCompanyName + "', `Company_Addr`='" + itxbCompanyAddr + "', `Company_Tel`='" + itxbCompanyTel + "', `Company_Own`='" + itxbCompanyOwner + "', `CoService`='" + itxbCoService + "', `CoSale`='" + itxbCoSale + "', `CoBill`='" + itxbCoBill + "' WHERE `Company_ID`='" + ilbCoID + "'";
                         iConnect.Insert(isqlCompanyUpdate);
                         MessageBox.Show("ทำการปรับข้อมูลแล้ว");
                     }
                 
                 else
                 {
                     string isqlCompanyAdd = "INSERT INTO `tb_company` (`Company_ID`, `Company_Name`, `Company_Addr`, `Company_Tel`, `Company_Own`, `CoService`, `CoSale`, `CoBill`) VALUES ('" + itxbCompanyID + "', '" + itxbCompanyName + "', '" + itxbCompanyAddr + "', '" + itxbCompanyTel + "', '" + itxbCompanyOwner + "', '" + itxbCoService + "', '" + itxbCoSale + "', '" + itxbCoBill + "')";
                     iConnect.Insert(isqlCompanyAdd);
                     MessageBox.Show("ทำการเพิ่มข้อมูลแล้ว");
                 }
                 
             }
             LoadData();
        }

        private void FrmMM16_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Browse = new OpenFileDialog();
            Browse.FileName = "";
            Browse.Filter = "All Pictures (*.png;*.gif;*.jpg)|*.png;*.gif;*.jpg";
            Browse.RestoreDirectory = true;
            Browse.InitialDirectory = "C:\\";
            if (Browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ImagePath = Browse.FileName;
                picBoxLogo.ImageLocation = ImagePath;
                txb_Image.Text = ImagePath;
            }
        }

        private void bt_UseImage_Click(object sender, EventArgs e)
        {
            string ImagePath = txb_Image.Text;
            string escapedPath = ImagePath.Replace(@"\", @"\\").Replace("'", @"\'");    
            
            if ((ImagePath != null) && (ImagePath !=""))
            {
                string isqlAddLogo = "UPDATE `tb_company` SET CoLogo ='" + escapedPath + "'";
                iConnect.Insert(isqlAddLogo);
            }
        }
    }
}
