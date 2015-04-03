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
    public partial class FrmMM24 : Form
    {
        private MySQLDBConnect iConnect;
        DataTable /* idtProduct,idtProductSale , */idtProductSaleDetail, idtEmployee;
        public FrmMM24()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void FrmMM22_Load(object sender, EventArgs e)
        {
            loadEmployee();
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH"); //ดึงข้อมูล ปี และกำหนดให้เป็นแบบไทย
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            lbyear.Text = DateTime.Now.ToString("yy");
            loadData();
        }
        private void loadData()
        {
            loadProductSaleDetail();
            Calculate();
        }
        decimal iProductAmt = 0;
        private void Calculate()
        {
            txb_ProductSaleTotal.Text = iProductAmt.ToString();
            decimal iTotal = 0;
            if ((txb_ProductSaleTotal.Text != null) && (txb_ProductSaleTotal.Text != ""))
            {
                iTotal = Convert.ToDecimal(txb_ProductSaleTotal.Text);
            }
            decimal iDC = 0;
            if ((txb_ProductSaleDC.Text != null) && (txb_ProductSaleDC.Text != ""))
            {
                iDC = Convert.ToDecimal(txb_ProductSaleDC.Text);
            }
            decimal iNet = 0;
            if ((txb_ProductSaleNet.Text != null) && (txb_ProductSaleNet.Text != ""))
            {
                iNet = Convert.ToDecimal(txb_ProductSaleNet.Text);
            }
            iNet = iTotal - iDC;
            txb_ProductSaleNet.Text = iNet.ToString();
        }
       
        private void loadProductSaleDetail()
        {
            string ilbproductSaleID = lb_ProductSaleID.Text.Trim();
            string isqlProductSaleDetail = "SELECT tb_productsaledetail.*,tb_Product.Product_Des  FROM tb_Product,tb_productsaledetail "+
            "WHERE (tb_productsaledetail.ProductSale_ID = '" + ilbproductSaleID + "' AND tb_Product.Product_ID = tb_productsaledetail.Product_ID)";
            idtProductSaleDetail = iConnect.SelectByCommand(isqlProductSaleDetail);
            dGV_Product.DataSource = idtProductSaleDetail;
            dGV_Product.Refresh();

            DataTable idtSumProduct;
            string isqlSumProduct = "SELECT sum(ProductSale_Total) as ProductSaleTotal FROM tb_productsaledetail WHERE tb_productsaledetail.ProductSale_ID = '" + ilbproductSaleID + "' ";
            idtSumProduct = iConnect.SelectByCommand(isqlSumProduct);

            foreach (DataRow row in idtSumProduct.Rows)
            {
                object value = row["ProductSaleTotal"];
                if (value == DBNull.Value)
                {
                    iProductAmt = 0;
                }
                else
                {
                    iProductAmt = idtSumProduct.Rows[0].Field<decimal>(0);
                }
            }
          //  lb_PriceAmt.DataBindings.Clear();
          //  Binding b = new Binding("Text", idtSumProduct, "ProductSaleTotal");
          //  lb_PriceAmt.DataBindings.Add(b);
        }

        private void loadEmployee()
        {
            string isqlEmployee = "SELECT * FROM tb_employee where Em_Status = 1";
            idtEmployee = iConnect.SelectByCommand(isqlEmployee);
            cb_Em.DisplayMember = idtEmployee.Columns["Em_Name"].ColumnName;
            cb_Em.ValueMember = idtEmployee.Columns["Em_ID"].ColumnName;
            cb_Em.DataSource = idtEmployee;
        }
        private void AddRecordProductSale() //สร้างรหัส และ อัพเดต Total DC Net
        {
            string ilbProductSaleID = lb_ProductSaleID.Text.Trim();
            string icb_Em = cb_Em.SelectedValue.ToString();
            string itxbRemark = txb_Remark.Text.Trim();
            string itxbProductSaletotal = txb_ProductSaleTotal.Text.Trim();
            string itxbProductSaleDC = txb_ProductSaleDC.Text.Trim();
            string itxbProductSaleNet = txb_ProductSaleNet.Text.Trim();

            string ilbyear = lbyear.Text.Trim();
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            string idTP_ProductSaleDate = dTP_ProductSaleDate.Value.ToString("yyyy-MM-dd");
            if ((lb_ProductSaleID.Text == "")||(lb_ProductSaleID.Text == null)) {
                DialogResult iConfirmResult = MessageBox.Show("ต้องการบันทึกข้อมูลการรักษาใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlProductSale = "INSERT INTO `tb_productsale` (`ProductSale_ID`, `Em_ID`, `ProductSale_Date`, `Productsale_Total`, `Productsale_DC`, `Productsale_Net`, `Productsale_Remark`) "+
                        "VALUES (CONCAT('" + ilbyear + "99', LPAD(  IFNULL( (SELECT SUBSTR(`ProductSale_ID`, 5) FROM `tb_productsale` AS `alias` WHERE SUBSTR(`ProductSale_ID`, 1, 2) = ('" + ilbyear + "')  "+
                        "ORDER BY `ProductSale_ID` DESC LIMIT 1 ) + 1, 1 ),  5, '0' )) , '" + icb_Em + "', '" + idTP_ProductSaleDate + "', '" + itxbProductSaletotal + "', '" + itxbProductSaleDC + "', '" + itxbProductSaleNet + "', '" + itxbRemark + "')";
                    iConnect.Insert(isqlProductSale);

                    DataTable idtProductSaleID; //เรียกไอดีเดิมขึ้นมาโชว์
                    string isqProductSaleID = "SELECT ProductSale_ID FROM `tb_productsale` AS `alias` WHERE SUBSTR(`ProductSale_ID`, 1, 2) = ('" + ilbyear + "')  ORDER BY `ProductSale_ID` DESC LIMIT 1";
                    idtProductSaleID = iConnect.SelectByCommand(isqProductSaleID);
                    loadData();
                    lb_ProductSaleID.Text = idtProductSaleID.Rows[0].Field<string>(0);
                }
            }
            else
            {
                //ส่วนอัพเดต
                string isqlUpdate = "UPDATE `petshop`.`tb_productsale` SET `Em_ID`='"+icb_Em+"', `Productsale_Total`='"+itxbProductSaletotal+"', `Productsale_DC`='"+itxbProductSaleDC+"', `Productsale_Net`='"+itxbProductSaleNet+"', `Productsale_Remark`='"+itxbRemark+"' WHERE `ProductSale_ID`='"+ilbProductSaleID+"'";
                //iConnect.Insert(isqlUpdate);
                MessageBox.Show("บันทึกข้อมูลแล้ว");
            }
           
        }
        private void BuyProduct()
        {
            string ilbProductSaleID = lb_ProductSaleID.Text.Trim();
            string itxbProductID = txb_ProductID.Text.Trim();
            string inUDProductUnit = nUD_ProductUnit.Text.Trim();
            if ((itxbProductID != null) && (itxbProductID != ""))
            {
            if ((ilbProductSaleID !="")&&(ilbProductSaleID !=null)){
                

                DataTable idtProductCheck;
                string isqlProductCheck = "SELECT * FROM `tb_product` where Product_ID = " + itxbProductID + "";
                idtProductCheck = iConnect.SelectByCommand(isqlProductCheck);

                if ((idtProductCheck != null) && (idtProductCheck.Rows.Count > 0)) 
                {
                    
                    decimal iUnit = Convert.ToDecimal(nUD_ProductUnit.Value);
                    decimal iPrice = idtProductCheck.Rows[0].Field<decimal>(4);
                    decimal iProductSale_Total = iPrice * iUnit;
                    string iProductName = idtProductCheck.Rows[0].Field<string>(1);
                    UInt32 iProductUnitAmt = idtProductCheck.Rows[0].Field<UInt32>(8);
                    UInt32 iProductUnitOrder = idtProductCheck.Rows[0].Field<UInt32>(9);
                    UInt64 iStock = idtProductCheck.Rows[0].Field<UInt64>(10);

                    int iResult = 0;
                    if(iStock == 0){
                        iResult = 1;
                    }
                    else
                    {
                       
                        if ((iProductUnitAmt > iUnit) || (iProductUnitAmt == iUnit))
                        {
                            iResult = 1;
                            if((iProductUnitAmt < iProductUnitOrder)||(iProductUnitAmt == iProductUnitOrder))
                            {
                                MessageBox.Show("สินค้า "+iProductName +"ใกล้หมด เหลือเพียง"+iProductUnitAmt+"");
                            }
                            string isqlreStock = "UPDATE `tb_product` SET `Product_Unit_Amt`= Product_Unit_Amt -" + iUnit + " WHERE `Product_ID`='" + itxbProductID + "'";
                            iConnect.Insert(isqlreStock);
                        }
                        else
                        {
                            MessageBox.Show("สินค้า "+iProductName+" มีไม่เพียงพอ เหลือเพียง "+ iProductUnitAmt +"");
                        }
                    }
                    if(iResult == 1)
                    {
                        
                        DataTable idtProductSaleCheck;
                        string isqlProductSaleCheck = "SELECT * FROM `tb_productsaledetail` where ProductSale_ID = " + ilbProductSaleID + " AND Product_ID = " + itxbProductID + "";
                        idtProductSaleCheck = iConnect.SelectByCommand(isqlProductSaleCheck);
                        if((idtProductSaleCheck !=null)&&(idtProductSaleCheck.Rows.Count >0 )){
                            string isqlProductSaleUpdate = "UPDATE `tb_productsaledetail` SET `Productsale_Unit` = Productsale_Unit+" + inUDProductUnit + ", `ProductSale_Total` = ProductSale_Total+'" + iProductSale_Total + "' " +
                            "WHERE `tb_productsaledetail`.`ProductSale_ID` = '" + ilbProductSaleID + "' AND `tb_productsaledetail`.`Product_ID` = '" + itxbProductID + "'";
                            iConnect.Insert(isqlProductSaleUpdate);
                        }
                        else
                        {
                            string isqlProductSale = "INSERT INTO `tb_productsaledetail` (`ProductSale_ID`, `Product_ID`, `Productsale_Unit`, `Product_Sale`, `ProductSale_Total`) " +
                                        "VALUES ('" + ilbProductSaleID + "', '" + itxbProductID + "', '" + inUDProductUnit + "', '" + iPrice + "', '" + iProductSale_Total + "')";
                            iConnect.Insert(isqlProductSale);
                        }
                        nUD_ProductUnit.Text = "1";
                        txb_ProductID.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูล สินค้า");
                }
            }
            else
            {
                AddRecordProductSale();
                //BuyProduct();
            }
            loadData();
        }

        }

        private void txb_Buy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter ) {
                BuyProduct();
            }
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            AddRecordProductSale();
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM32))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM32 iFrmMM32 = new FrmMM32();
            iFrmMM32.MdiParent = MainForm.ActiveForm;
            iFrmMM32.Show();
            iFrmMM32.txb_ReferID.Text = lb_ProductSaleID.Text.Trim();
        }

        private void bt_AddProductSale_Click(object sender, EventArgs e)
        {
            BuyProduct();
        }

        private void bt_CancelBuy_Click(object sender, EventArgs e)
        {
            string ilbProductSaleID = lb_ProductSaleID.Text.Trim();
            string ilbProductID = lb_ProductID.Text.Trim();
            string ilbProductUnit = lb_ProductUnit.Text.Trim();
             DialogResult iConfirmResult = MessageBox.Show("ต้องการยกเลิกรายการสินค้า ?", "ยกเลิกรายการสินค้า..", MessageBoxButtons.YesNo);
             if (iConfirmResult == DialogResult.Yes)
             {
                 DataTable idtCheckProduct;
                 string isqlCheckProduct = "SELECT * FROM tb_Product where Product_ID = '" + ilbProductID + "'";
                 idtCheckProduct = iConnect.SelectByCommand(isqlCheckProduct);

                 UInt64 iStock = idtCheckProduct.Rows[0].Field<UInt64>(10);

                 int iResult = 0;
                 if (iStock == 0)
                 {
                     iResult = 1;
                 }
                 else
                 {
                     iResult = 1;
                     string isqlreStock = "UPDATE `tb_Product` SET `Product_Unit_Amt`= Product_Unit_Amt +" + ilbProductUnit + " WHERE `Product_ID`='" + ilbProductID + "'";
                     iConnect.Insert(isqlreStock);
                 }
                 if (iResult == 1)
                 {
                     string isqlDelProductSale = "DELETE FROM `tb_ProductSaledetail` WHERE `ProductSale_ID`='" + ilbProductSaleID + "' and `Product_ID`='" + ilbProductID + "'";
                     iConnect.Insert(isqlDelProductSale);
                     loadProductSaleDetail();
                     lb_ProductID.Text = "";
                     lb_ProductUnit.Text = "";
                 }
             }
        }

        private void dGV_Product_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_Product.SelectedRows)
            {
                lb_ProductID.Text = row.Cells["ccProduct_ID"].Value.ToString();
                lb_ProductUnit.Text = row.Cells["ccProductSale_Unit"].Value.ToString();
            }
        }

        private void txb_ProductSaleDC_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void bt_RecordBuy_Click(object sender, EventArgs e)
        {
            AddRecordProductSale();
        }

        private void lb_ProductSaleID_TextChanged(object sender, EventArgs e)
        {
            if ((lb_ProductSaleID.Text != null) && (lb_ProductSaleID.Text != ""))
            {
                txb_ProductID.Enabled = true;
                nUD_ProductUnit.Enabled = true;
                bt_AddProductSale.Enabled = true;
                bt_CancelBuy.Enabled = true;
                bt_Print.Enabled = true;
               // txb_ProductID.Enabled = true;
                bt_RecordBuy.Enabled = false;
            }
        }
    }
}
