using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Petshop
{
    public partial class FrmMM12 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmMM12()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void Bt_LoadPD_Click(object sender, EventArgs e)
        {
            LoadProduct();
            LoadUnit();
        }

        private void LoadUnit()
        {
            DataTable idtUnit;
            string isqlcommand = "SELECT * FROM `tb_unit` ";
            idtUnit = iConnect.SelectByCommand(isqlcommand);

            cb_ProductUnit.DisplayMember = idtUnit.Columns["Unit_Name"].ColumnName;
            cb_ProductUnit.ValueMember = idtUnit.Columns["Unit_ID"].ColumnName;
            cb_ProductUnit.DataSource = idtUnit;
        }

        private void LoadProduct()
        {
            DataTable idtProduct;
            string isqlCommand = "SELECT tb_product.*,tb_unit.Unit_Name FROM `tb_product`,tb_unit where tb_product.unit_Id = tb_unit.Unit_ID";
            idtProduct = iConnect.SelectByCommand(isqlCommand);
            dGV_PD.DataSource = idtProduct;
            dGV_PD.Refresh();
        }
        private void bt_AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void AddProduct()
        {
            /*tb_ProductID.Enabled = true; //อย่าลืมปิด
            tb_ProductName.Enabled = true;
            tb_ProductDetail.Enabled = true;
            tb_ProductPrice.Enabled = true;
            tb_ProductSale.Enabled = true;
            tb_ProductUnit.Enabled = true;
          
            dTP_Product.Enabled = true;
            dTP_Expired.Enabled = true;

            tb_ProductAmt.Enabled = true;
            tb_ProductOrder.Enabled = true;

            tb_ProductName.Focus(); */

            string itxbProductID = txb_ProductID.Text.Trim();
            string itxbProductName = txb_ProductName.Text.Trim();
            string itxbProductDetail = txb_ProductDetail.Text.Trim();
            if ((txb_ProductPrice.Text == "") || (txb_ProductPrice.Text == null))
            {
                txb_ProductPrice.Text = "0.00";
            }
            string itxbProductPrice = txb_ProductPrice.Text.Trim();
            if ((txb_ProductSale.Text == "") || (txb_ProductSale.Text == null))
            {
                txb_ProductSale.Text = "0.00";
            }
            string itxbProductSale = txb_ProductSale.Text.Trim();

            //string itbProductUnit = tb_ProductUnit.Text.Trim();
            string icbProductUnit = cb_ProductUnit.SelectedValue.ToString();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            string idtpProduct = dTP_Product.Value.ToString("yyyy-MM-dd");
            string idtpExpired = dTP_Expired.Value.ToString("yyyy-MM-dd");
            if ((txb_ProductAmt.Text == "") || (txb_ProductAmt.Text == null))
            {
                txb_ProductAmt.Text = "0";
            }
            string itxbProductAmt = txb_ProductAmt.Text.Trim();
            if ((txb_ProductOrder.Text == "") || (txb_ProductOrder.Text == null))
            {
                txb_ProductOrder.Text = "0";
            }
            string itxbProductOrder = txb_ProductOrder.Text.Trim();

            int iStock = 0;
            if (CheckBox_Stock.Checked == true)
            {
                iStock = 1;
            }

            string isqlAddProduct = "INSERT INTO `tb_product` (`Product_ID`, `Product_Des`, `Product_Detail`, `Product_Price`, `Product_Sale`, `Unit_ID`, `Product_Product`, `Product_Expired`, `Product_Unit_Amt`, `Product_Unit_Order`,Product_Stock) " +
                "VALUES ('" + itxbProductID + "','" + itxbProductName + "', '" + itxbProductDetail + "', '" + itxbProductPrice + "', '" + itxbProductSale + "', '" + icbProductUnit + "', '" + idtpProduct + "', '" + idtpExpired + "', '" + itxbProductAmt + "', '" + itxbProductOrder + "',b'" + iStock + "')";

            //string isqlAddProduct = "INSERT INTO `tb_product` (`Product_ID`, `Product_Des`, `Product_Detail`, `Product_Price`, `Product_Sale`, `Unit_ID`, `Product_Product`, `Product_Expired`, `Product_Unit_Amt`, `Product_Unit_Order`) VALUES (CONCAT('P',LPAD((SELECT SUBSTR(`Product_ID`, 2) FROM `tb_product` as `alias` Order By Product_ID DESC Limit 1)+1,5,'0')), '" + itbProductName + "', '" + itbProductDetail + "', '" + itbProductPrice + "', '" + itbProductSale + "', '" + icbProductUnit + "', '" + idtpProduct + "', '" + idtpExpired + "', '" + itbProductAmt + "', '" + itbProductOrder + "')";
            if ((itxbProductID != null) || (itxbProductID != ""))
            {
                if ((itxbProductName != null) || (itxbProductName != ""))
                {
                    DataTable idtProductCheck;
                    string isqlProductCheck = "SELECT * FROM petshop.tb_product where Product_ID = '" + itxbProductID + " '";
                    idtProductCheck = iConnect.SelectByCommand(isqlProductCheck);
                    if (idtProductCheck != null)
                    {
                        if (idtProductCheck.Rows.Count > 0)
                        {
                            MessageBox.Show("มีสินค้ารหัส " + itxbProductID + " อยู่ในระบบแล้ว");
                        }
                        else
                        {
                            DialogResult iConfirmResult = MessageBox.Show("เพิ่ม " + itxbProductName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                            if (iConfirmResult == DialogResult.Yes)
                            {
                                iConnect.Insert(isqlAddProduct);
                                LoadProduct();
                            }
                        }

                    }
                }
            }
        }

        private void dGV_PD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_PD.Rows[e.RowIndex]; //ขาด Combox DateTimePicker 3 ชิ้น 

                txb_ProductID.Text = row.Cells["ccProduct_ID"].Value.ToString();
                lb_ProductIDh.Text = row.Cells["ccProduct_ID"].Value.ToString();
                txb_ProductName.Text = row.Cells["ccProduct_Des"].Value.ToString();
                txb_ProductDetail.Text = row.Cells["ccProduct_Detail"].Value.ToString();
                txb_ProductPrice.Text = row.Cells["ccProduct_Price"].Value.ToString();
                txb_ProductSale.Text = row.Cells["ccProduct_Sale"].Value.ToString();

                cb_ProductUnit.SelectedValue = row.Cells["ccUnit_ID"].Value;
                txb_ProductAmt.Text = row.Cells["ccProduct_Unit_Amt"].Value.ToString();

                DateTime iProductDate = Convert.ToDateTime(row.Cells["ccProduct_Product"].Value);
                dTP_Product.Value = iProductDate;
                DateTime iExpiredDate = Convert.ToDateTime(row.Cells["ccProduct_Expired"].Value);
                dTP_Expired.Value = iExpiredDate;
                txb_ProductOrder.Text = row.Cells["ccProduct_Unit_Order"].Value.ToString();
                int iStock = Convert.ToInt32(row.Cells["ccProduct_Stock"].Value);
                if (iStock == 1)
                {
                    CheckBox_Stock.Checked = true;
                }
                else
                {
                    CheckBox_Stock.Checked = false;
                }
            }
        }
        private void FrmMM12_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadUnit();
        }
        private void bt_EditProduct_Click(object sender, EventArgs e)
        {
            string itxbProductID = txb_ProductID.Text.Trim();
            string ilbProductID = lb_ProductIDh.Text.Trim();
            string itxbProductName = txb_ProductName.Text.Trim();
            string itxbProductDetail = txb_ProductDetail.Text.Trim();
            string itxbProductPrice = txb_ProductPrice.Text.Trim();
            string itxbProductSale = txb_ProductSale.Text.Trim();
            //string itbProductUnit = tb_ProductUnit.Text.Trim();
            string icbProductUnit = cb_ProductUnit.SelectedValue.ToString();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            string idtpProduct = dTP_Product.Value.ToString("yyyy-MM-dd");
            string idtpExpired = dTP_Expired.Value.ToString("yyyy-MM-dd");

            string itxbProductAmt = txb_ProductAmt.Text.Trim();
            string itxbProductOrder = txb_ProductOrder.Text.Trim();

            int iStock = 0;
            if (CheckBox_Stock.Checked == true)
            {
                iStock = 1;
            }
            DataTable idtProductCheck;
            string isqlProd = "SELECT * FROM tb_product where Product_ID = '"+ilbProductID+"'";
            idtProductCheck = iConnect.SelectByCommand(isqlProd);
            if (idtProductCheck.Rows.Count > 0)
            {
                if ((itxbProductID != null) || (itxbProductID != ""))
                {
                    DialogResult iConfirmResult = MessageBox.Show("เพิ่ม " + itxbProductName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlAddProduct = "UPDATE `tb_product` SET Product_ID = '"+itxbProductID+"',`Product_Des` = '" + itxbProductName + "', `Product_Detail` = '" + itxbProductDetail + "', `Product_Price` = '" + itxbProductPrice + "', `Product_Sale` = '" + itxbProductSale + "', `Unit_ID` = '" + icbProductUnit + "', `Product_Product` = '" + idtpProduct + "', `Product_Expired` = '" + idtpExpired + "', `Product_Unit_Amt` = '" + itxbProductAmt + "', `Product_Unit_Order` = '" + itxbProductOrder + "',Product_Stock = b'" + iStock + "' WHERE `tb_product`.`Product_ID` = '" + ilbProductID + "';";
                        iConnect.Insert(isqlAddProduct);
                        LoadProduct();
                        ClearTxtProduct();
                    }
                }
             }
         }
        private void ClearTxtProduct()
        {
            lb_ProductIDh.Text = "";
            txb_ProductID.Clear();
            txb_ProductName.Clear();
            txb_ProductDetail.Clear();
            txb_ProductPrice.Clear();
            txb_ProductSale.Clear();
            txb_ProductAmt.Clear();
            txb_ProductOrder.Clear();
        }
        private void bt_Unit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM13))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM13 iFrmMM13 = new FrmMM13();
            iFrmMM13.MdiParent = MainForm.ActiveForm;
            iFrmMM13.Show();
        }
        private void txb_ProductID_Enter(object sender, EventArgs e)
        {
            dynamic TypeOfLanguage = new System.Globalization.CultureInfo("En");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }
        private void txb_ProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_ProductName.Focus();
            }
        }
        private void txb_ProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_ProductDetail.Focus();
            }
        }

        private void txb_ProductDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
             txb_ProductPrice.Focus();
            }
        }
         private void txb_ProductPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_ProductSale.Focus();
            }
        }
        private void txb_ProductSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               cb_ProductUnit.Focus();
            }
        }
        private void txb_ProductAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_ProductOrder.Focus();
            }
        }

        private void txb_ProductOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_AddProduct.Select();
            }
        }
     }
}
