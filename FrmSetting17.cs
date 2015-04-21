using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Petshop
{
    public partial class FrmSetting17 : Form
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        DataTable idtCompany;
        public FrmSetting17()
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
            txb_CompanyRemark.Text = idtCompany.Rows[0]["Company_Remark"].ToString();
            txb_CoService.Text = idtCompany.Rows[0]["CoService"].ToString();
            txb_CoSale.Text = idtCompany.Rows[0]["CoSale"].ToString();
            txb_CoBill.Text = idtCompany.Rows[0]["CoBill"].ToString();
            lb_CoIDH.Text = idtCompany.Rows[0]["Company_ID"].ToString();
                
            string FP = idtCompany.Rows[0]["CoLogo"].ToString();
                if((FP!=null)&&(FP!="")){
                    picBoxLogo.Image = Image.FromFile(FP);
                }
            }
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            Regex RegInt2 = new Regex(@"^(\d{2})$");
            if (txb_Company_Name.Text == string.Empty) {
                epCheck.SetError(txb_Company_Name,"กรุณาระบุชื่อองค์กร");
                txb_Company_Name.Focus();
            }
            else if(txb_CompanyAddr.Text == string.Empty)
            {
                epCheck.SetError(txb_CompanyAddr, "กรุณาระบุที่อยู่");
                txb_CompanyAddr.Focus();
            }
            else if(txb_CompanyTel.Text == string.Empty)
            {
                epCheck.SetError(txb_CompanyTel, "กรุณาระบุเบอร์โทรศัพท์");
                txb_CompanyTel.Focus();
            }
            else if (!RegInt2.IsMatch(txb_CoID.Text)) 
            {
                epCheck.SetError(txb_CoID, "กรุณาระบุรหัสสาขา 2 ตำแหน่ง");
                txb_CoID.Focus();
            }
            else if (!RegInt2.IsMatch(txb_CoService.Text))
            {
                epCheck.SetError(txb_CoService, "กรุณาระบุรหัสบริการ 2 ตำแหน่ง");
                txb_CoService.Focus();
            }
            else if (!RegInt2.IsMatch(txb_CoSale.Text))
            {
                epCheck.SetError(txb_CoSale, "กรุณาระบุรหัสขายสินค้า 2 ตำแหน่ง");
                txb_CoSale.Focus();
            }
            else if (!RegInt2.IsMatch(txb_CoBill.Text))
            {
                epCheck.SetError(txb_CoBill, "กรุณาระบุรหัสใบเสร็จ 2 ตำแหน่ง");
                txb_CoBill.Focus();
            }
            else
            {
                string itxbCompanyID = txb_CoID.Text.Trim();
                string ilbCoID = lb_CoIDH.Text.Trim();
                string itxbCompanyName = txb_Company_Name.Text.Trim();
                string itxbCompanyAddr = txb_CompanyAddr.Text.Trim();
                string itxbCompanyTel = txb_CompanyTel.Text.Trim();
                string itxbCompanyremark = txb_CompanyRemark.Text.Trim();
                string itxbCoService = txb_CoService.Text.Trim();
                string itxbCoSale = txb_CoSale.Text.Trim();
                string itxbCoBill = txb_CoBill.Text.Trim();

                DialogResult iConfirmResult = MessageBox.Show("บันทึกข้อมูลองค์กร?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    if (idtCompany.Rows.Count > 0)
                    {
                        string isqlCompanyUpdate = "UPDATE `tb_company` SET `Company_ID`='" + itxbCompanyID + "', `Company_Name`='" + itxbCompanyName + "', `Company_Addr`='" + itxbCompanyAddr + "', `Company_Tel`='" + itxbCompanyTel + "', `Company_Remark`='" + itxbCompanyremark + "', `CoService`='" + itxbCoService + "', `CoSale`='" + itxbCoSale + "', `CoBill`='" + itxbCoBill + "' WHERE `Company_ID`='" + ilbCoID + "'";
                        iConnect.Insert(isqlCompanyUpdate);
                        MessageBox.Show("ทำการปรับข้อมูลแล้ว");
                        ClearTxb();
                        LoadData();
                    }
                    else
                    {
                        string isqlCompanyAdd = "INSERT INTO `tb_company` (`Company_ID`, `Company_Name`, `Company_Addr`, `Company_Tel`, `Company_Remark`, `CoService`, `CoSale`, `CoBill`) VALUES ('" + itxbCompanyID + "', '" + itxbCompanyName + "', '" + itxbCompanyAddr + "', '" + itxbCompanyTel + "', '" + itxbCompanyremark + "', '" + itxbCoService + "', '" + itxbCoSale + "', '" + itxbCoBill + "')";
                        iConnect.Insert(isqlCompanyAdd);
                        MessageBox.Show("ทำการเพิ่มข้อมูลแล้ว");
                        ClearTxb();
                        LoadData();
                    }
                }
            }
        }

        private void ClearTxb()
        {
            txb_Company_Name.Clear();
            txb_CompanyAddr.Clear();
            txb_CompanyTel.Clear();
            txb_CompanyRemark.Clear();
            txb_CoID.Clear();
            txb_CoBill.Clear();
            txb_CoSale.Clear();
            txb_CoService.Clear();
            txb_Image.Clear();
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
            
            if ((ImagePath != null) && (ImagePath !=string.Empty))
            {
                string isqlAddLogo = "UPDATE `tb_company` SET CoLogo ='" + escapedPath + "'";
                iConnect.Insert(isqlAddLogo);
                MessageBox.Show("บันทึกภาพนี้แล้ว");
            }
        }

        private void txb_Company_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_CompanyAddr.Focus();
            }
        }
        private void txb_CompanyTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_CompanyRemark.Focus();
            }
        }
        private void txb_CompanyRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_CoID.Focus();
            }
        }
        private void txb_CoID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                txb_CoBill.Focus();
            }
        }

        private void txb_CoBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_CoSale.Focus();
            }
        }
        private void txb_CoSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_CoService.Focus();
            }
        }
        private void txb_CoService_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Update.Select();
            }
        }        
    }
}
