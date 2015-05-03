using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Petshop
{
    public partial class FrmSetting12 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmSetting12()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void Bt_LoadPD_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            LoadUnit();
            LoadProduct();
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
            dGV_Product.DataSource = idtProduct;
            dGV_Product.Refresh();
            lb_SearchProduct.Text = idtProduct.Rows.Count.ToString();
        }
        string iAddEditProduct; 
        private void bt_AddProduct_Click(object sender, EventArgs e)
        {
            iAddEditProduct = "AddProduct";
            AddEditProduct();
        }

        private void AddEditProduct()
        {
             epCheck.Clear();
            Regex RegID = new Regex(@"[a-zA-Z0-9]{6,16}$");
            Regex RegMoney = new Regex(@"^((\d{1,8})|(\d{1,6}\.\d{1,2}))$");
            Regex RegInt = new Regex(@"^(\d{1,3})$");
            //Regex RegDate = new Regex(@"^\d{1,3}$");
            int iStock = 0;
            if (CheckBox_Stock.Checked == true)
            {
                iStock = 1;
            }
            else
            {
                txb_ProductOrder.Text = "0";
            }
            if (!RegID.IsMatch(txb_ProductID.Text))
            {
                epCheck.SetError(txb_ProductID, "***กรุณากรอกรหัสสินค้าอย่างน้อย 6 หลัก *ตัวอย่าง Aa0001");
                txb_ProductID.Focus();
            }
            else if (txb_ProductName.Text == string.Empty)
            {
                epCheck.SetError(txb_ProductName, "***กรุณากรอกชื่อสินค้า");
                txb_ProductName.Focus();
            }
            else if (!RegMoney.IsMatch(txb_ProductPrice.Text))
            {
                epCheck.SetError(txb_ProductPrice, "***กรุณาใส่ค่าให้ถูกต้อง เช่น 777 หรือ 777.25");
                txb_ProductPrice.Focus();
            }
            else if (!RegMoney.IsMatch(txb_ProductSale.Text))
            {
                epCheck.SetError(txb_ProductSale, "***กรุณาใส่ค่าให้ถูกต้อง เช่น 777 หรือ 777.25");
                txb_ProductSale.Focus();
            }
            else if (cb_ProductUnit.SelectedValue == null)
            {
                MessageBox.Show("ไม่พบหน่วย กรุณาเพิ่มหน่วย");
                epCheck.SetError(cb_ProductUnit, "กรุณาเลือกหน่วย");
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmSetting14))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmSetting14 iFrmMM13 = new FrmSetting14();
                iFrmMM13.MdiParent = MainForm.ActiveForm;
                iFrmMM13.Show();
                cb_ProductUnit.Focus();
            }
            else if (!RegInt.IsMatch(txb_ProductAmt.Text))
            {
                epCheck.SetError(txb_ProductAmt, "***คุณกรอกจำนวนไม่ถูกต้อง");
                txb_ProductAmt.Focus();
            }
            else if (!RegInt.IsMatch(txb_ProductOrder.Text))
            {
                epCheck.SetError(txb_ProductOrder, "***คุณกรอกจำนวนไม่ถูกต้อง");
                txb_ProductOrder.Focus();
            }
            else
            {
                string itxbProductID = txb_ProductID.Text.Trim();
                string itxbProductName = txb_ProductName.Text.Trim();
                string itxbProductDetail = txb_ProductDetail.Text.Trim();
                string itxbProductPrice = txb_ProductPrice.Text.Trim();
                string itxbProductSale = txb_ProductSale.Text.Trim();
                string icbProductUnit = cb_ProductUnit.SelectedValue.ToString();

                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

                string idtpProduct = dTP_Product.Value.ToString("yyyy-MM-dd");
                string idtpExpired = dTP_Expired.Value.ToString("yyyy-MM-dd");
                string itxbProductAmt = txb_ProductAmt.Text.Trim();
                string itxbProductOrder = txb_ProductOrder.Text.Trim();
                string ilbProductID = lb_ProductIDh.Text.Trim();
                

                DataTable idtProductCheck;
                string isqlProductCheck = "SELECT * FROM petshop.tb_product where Product_ID = '" + itxbProductID + " '";
                idtProductCheck = iConnect.SelectByCommand(isqlProductCheck);

                if (iAddEditProduct == "AddProduct")
                {
                    if (idtProductCheck.Rows.Count > 0)
                    {
                        MessageBox.Show("มีสินค้ารหัส " + itxbProductID + " อยู่ในระบบแล้ว","ตรวจสอบ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult iConfirmResult = MessageBox.Show("เพิ่มสินค้า " + itxbProductName + " มั๊ย?", "เพิ่มสินค้า..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {
                            string isqlAddProduct = "INSERT INTO `tb_product` (`Product_ID`, `Product_Des`, `Product_Detail`, `Product_Price`, `Product_Sale`, `Unit_ID`, `Product_Product`, `Product_Expired`, `Product_Unit_Amt`, `Product_Unit_Order`,Product_Stock) " +
                            "VALUES ('" + itxbProductID + "','" + itxbProductName + "', '" + itxbProductDetail + "', '" + itxbProductPrice + "', '" + itxbProductSale + "', '" + icbProductUnit + "', '" + idtpProduct + "', '" + idtpExpired + "', '" + itxbProductAmt + "', '" + itxbProductOrder + "',b'" + iStock + "')";
                            iConnect.Insert(isqlAddProduct);
                            LoadProduct();
                            ClearTxtProduct();
                            iAddEditProduct = string.Empty;
                        }
                    }
                }
                else if (iAddEditProduct == "EditProduct")
                {
                    if (idtProductCheck.Rows.Count > 0)
                    {
                        if ((itxbProductID != null) && (itxbProductID != string.Empty))
                        {
                            DialogResult iConfirmResult = MessageBox.Show("แก้ไข " + itxbProductName + " มั๊ย?", "แก้ไขข้อมูล..", MessageBoxButtons.YesNo);
                            if (iConfirmResult == DialogResult.Yes)
                            {
                                string isqlAddProduct = "UPDATE `tb_product` SET `Product_Des` = '" + itxbProductName + "', `Product_Detail` = '" + itxbProductDetail + "', `Product_Price` = '" + itxbProductPrice + "', `Product_Sale` = '" + itxbProductSale + "', `Unit_ID` = '" + icbProductUnit + "', `Product_Product` = '" + idtpProduct + "', `Product_Expired` = '" + idtpExpired + "', `Product_Unit_Amt` = '" + itxbProductAmt + "', `Product_Unit_Order` = '" + itxbProductOrder + "',Product_Stock = b'" + iStock + "' WHERE `tb_product`.`Product_ID` = '" + ilbProductID + "'";                
                                //string isqlAddProduct = "UPDATE `tb_product` SET Product_ID = '" + itxbProductID + "',`Product_Des` = '" + itxbProductName + "', `Product_Detail` = '" + itxbProductDetail + "', `Product_Price` = '" + itxbProductPrice + "', `Product_Sale` = '" + itxbProductSale + "', `Unit_ID` = '" + icbProductUnit + "', `Product_Product` = '" + idtpProduct + "', `Product_Expired` = '" + idtpExpired + "', `Product_Unit_Amt` = '" + itxbProductAmt + "', `Product_Unit_Order` = '" + itxbProductOrder + "',Product_Stock = b'" + iStock + "' WHERE `tb_product`.`Product_ID` = '" + ilbProductID + "';";
                                iConnect.Insert(isqlAddProduct);
                                LoadProduct();
                                ClearTxtProduct();
                                iAddEditProduct = string.Empty;
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
                DataGridViewRow row = this.dGV_Product.Rows[e.RowIndex]; //ขาด Combox DateTimePicker 3 ชิ้น 

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
            iAddEditProduct = "EditProduct";
            AddEditProduct();
        }
        private void ClearTxtProduct()
        {
            lb_ProductIDh.Text = "";
            txb_ProductID.Clear();
            txb_ProductName.Clear();
            txb_ProductDetail.Clear();
            txb_ProductPrice.Clear();
            txb_ProductSale.Clear();
            dTP_Product.Value = DateTime.Today;
            dTP_Expired.Value = DateTime.Today;
            txb_ProductAmt.Clear();
            txb_ProductOrder.Clear();
            txb_ProductID.Focus();
        }
        private void bt_Unit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting14))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting14 iFrmMM13 = new FrmSetting14();
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

        private void txb_ProductID_TextChanged(object sender, EventArgs e)
        {
            int icount = 16;
            int iProductID = txb_ProductID.Text.Length;
            int ichar = icount - iProductID;
            lb_count.Text = ichar.ToString();
            if((txb_ProductID.Text == null)||(txb_ProductID.Text == string.Empty)){

                bt_EditProduct.Enabled = false;
                bt_DelProduct.Enabled = false;
            }
            else
            {
                bt_EditProduct.Enabled = true;
                bt_DelProduct.Enabled = true;
            }
        }

        private void bt_reSetProduct_Click(object sender, EventArgs e)
        {
            ClearTxtProduct();
        }

        private void bt_DelProduct_Click(object sender, EventArgs e)
        {
            string itxbProductID = lb_ProductIDh.Text.Trim();
            string itxbProductName = txb_ProductName.Text.Trim();
            if ((itxbProductID != null) && (itxbProductID != ""))
            {
                DataTable idtProductCheck;
                string isqlProductCheck = "SELECT tb_productsaledetail.Product_ID FROM petshop.tb_productsaledetail where Product_ID = '" + itxbProductID + "'";
                idtProductCheck = iConnect.SelectByCommand(isqlProductCheck);
                if (idtProductCheck.Rows.Count == 0)
                {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxbProductName + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    
                        string isqlDelProduct = "DELETE FROM `tb_Product` WHERE `Product_ID`='" + itxbProductID + "'";
                        iConnect.Insert(isqlDelProduct);
                        MessageBox.Show("ทำการลบสินค้าออกแล้ว");
                        ClearTxtProduct();
                }   
                }
                else
                {
                    MessageBox.Show("ไม่สามารถลบได้");
                }
                LoadProduct();
            }
        }

        private void bt_SearchProduct_Click(object sender, EventArgs e)
        {
            SearchProduct();
            
        }

        private void SearchProduct()
        {
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            if (RegString.IsMatch(txb_SearchProduct.Text))
            {
                string iSearchProduct = txb_SearchProduct.Text.Trim();
                DataTable idtProduct;
                string isqlCommand = "SELECT * FROM `tb_Product` where Product_Des like '%" + iSearchProduct + "%' OR Product_ID like '%" + iSearchProduct + "%' ";
                idtProduct = iConnect.SelectByCommand(isqlCommand);
                dGV_Product.DataSource = idtProduct;
                dGV_Product.Refresh();
                lb_SearchProduct.Text = idtProduct.Rows.Count.ToString();
            }
            else
            {
                LoadProduct();
            }
        }

        private void txb_SearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchProduct();
            }
        }

        private void cb_ProductUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_ProductAmt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        
     }
}
