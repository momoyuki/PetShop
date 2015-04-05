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
    public partial class FrmMM32 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmMM32()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            loadEmployee();
            loadCompany();
            loadProductSale();
            loaddata();
        }
        private void FrmMM32_Load(object sender, EventArgs e)
        {
            loadEmployee();
            loadCompany();
            loadProductSale();
            loaddata();
        }

        private void loaddata()
        {
            loadProductSaleBill();
            Calculate();
        }
       
        decimal iProductAmt = 0;

        private void Calculate()
        {
            txb_BillTotal.Text = iProductAmt.ToString();
            decimal iTotal = 0;
            if ((txb_BillTotal.Text != null) && (txb_BillTotal.Text != ""))
            {
                iTotal = Convert.ToDecimal(txb_BillTotal.Text);
            }
            decimal iDC = 0;
            if ((txb_BillDC.Text != null) && (txb_BillDC.Text != ""))
            {
                iDC = Convert.ToDecimal(txb_BillDC.Text);
            }
            decimal iNet = 0;
            if ((txb_BillNet.Text != null) && (txb_BillNet.Text != ""))
            {
                iNet = Convert.ToDecimal(txb_BillNet.Text);
            }
            iNet = iTotal - iDC;
            txb_BillNet.Text = iNet.ToString();
        }      

        private void loadProductSaleBill()
        {
            if ((Lb_BillID.Text != null)&&(Lb_BillID.Text != string.Empty))
            {
                string ilbBillID = Lb_BillID.Text.Trim();
                DataTable idtSumBill;
                string isqlSumDetail = "SELECT sum(ProductSale_Bill_Amt) as ProductAmt FROM tb_productsalebill where Bill_ID = '" + ilbBillID + "'";
                idtSumBill = iConnect.SelectByCommand(isqlSumDetail);
                foreach (DataRow row in idtSumBill.Rows)
                {
                    object value = row["ProductAmt"];
                    if (value == DBNull.Value)
                    {
                        iProductAmt = 0;
                    }
                    else
                    {
                        iProductAmt = idtSumBill.Rows[0].Field<decimal>(0);
                    }
                }
            }
        }

        private void loadProductSale()
        {
            if((txb_ReferID.Text !=null)&&(txb_ReferID.Text !=string.Empty)){
                DataTable idtProduct;
                string itxbReferID = txb_ReferID.Text.Trim();
                string isqlProduct = "SELECT tb_productsaledetail.*,tb_product.Product_Des FROM tb_productsaledetail,tb_product where tb_productsaledetail.Product_ID = tb_product.Product_ID AND tb_productsaledetail.ProductSale_ID ='" + itxbReferID + "'";
                idtProduct = iConnect.SelectByCommand(isqlProduct);
                dGV_Product.DataSource = idtProduct;
                dGV_Product.Refresh();
                            }
                     }
        

        
        private void loadCompany()
        {
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM `tb_company`";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            if (idtCompany != null)
            {
                if (idtCompany.Rows.Count > 0)
                {
                    System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
                    System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                    lbYear.Text = DateTime.Now.ToString("yy");
                    Lb_CoBill.Text = idtCompany.Rows[0]["CoBill"].ToString();
                }
                else
                {
                    Lb_CoBill.Text = "55";
                }
            } 
        }

        private void loadEmployee()
        {
            DataTable idtEmployee;
            string isqlEmployee = "SELECT * FROM petshop.tb_employee where Em_Status = 1";
            idtEmployee = iConnect.SelectByCommand(isqlEmployee);
            if (idtEmployee.Rows.Count > 0)
            {
                cb_Em.DisplayMember = idtEmployee.Columns["Em_Name"].ColumnName;
                cb_Em.ValueMember = idtEmployee.Columns["Em_ID"].ColumnName;
                cb_Em.DataSource = idtEmployee;
            }
            
        }
        private void bt_Print_Click(object sender, EventArgs e)
        {
            BillAdd();
            AddProductBill();
            if ((Lb_BillID.Text != null) && (Lb_BillID.Text != ""))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmBillProd))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmBillProd iFrmBill = new FrmBillProd();
                iFrmBill.MdiParent = MainForm.ActiveForm;
                iFrmBill.Show();
                iFrmBill.lb_BillID.Text = Lb_BillID.Text.Trim();
            }
        }
        private void CheckBoxProduct_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV_Product.RowCount; i++)
            {
                dGV_Product[0, i].Value =CheckBoxProduct.Checked;//((CheckBox)dGV_Product.Controls.Find("checkboxHeaderMedi", true)[0]).Checked;
            }
            dGV_Product.EndEdit();
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            BillAdd();
            AddProductBill();
        }

        private void AddProductBill()
        {
            string ilbBillID = Lb_BillID.Text.Trim();
            string itxbReferID = txb_ReferID.Text.Trim();
            if ((itxbReferID != null) && (itxbReferID != ""))
            {
                if ((ilbBillID != null) && (ilbBillID != ""))
                {
                    for (int i = 0; dGV_Product.Rows.Count > i; i++)
                    {
                        if (dGV_Product.Rows[i].Cells[0].Value != null)
                        {
                            String iServiceID = dGV_Product.Rows[i].Cells[2].Value.ToString();
                            String iServicePrice = dGV_Product.Rows[i].Cells[3].Value.ToString();
                            DataTable idtServiceBilCheck;
                            string isqlServiceBillCheck = "SELECT * FROM tb_productsalebill where Bill_ID = '" + ilbBillID + "'AND Product_ID = '" + iServiceID + "' ";
                            idtServiceBilCheck = iConnect.SelectByCommand(isqlServiceBillCheck);//ลักษณะการทำงานคือ เมื่อเข้าไปเช็คในฐานข้อมูล หากมี ให้ทำการดอรป์ออก
                            if (idtServiceBilCheck.Rows.Count > 0)
                            {
                                string isqlServiceBill = "DELETE FROM `tb_productsalebill` WHERE `Bill_ID`='" + ilbBillID + "' and`Product_ID`='" + iServiceID + "'";
                                iConnect.Insert(isqlServiceBill);
                            }
                         }
                        if (Convert.ToBoolean(dGV_Product.Rows[i].Cells[0].Value) == false)
                            {                   
                            //ถ้าไม่เช็ค
                            String iProductID = dGV_Product.Rows[i].Cells[2].Value.ToString();
                            String iProductPrice = dGV_Product.Rows[i].Cells[3].Value.ToString();
                            String iProductUnit = dGV_Product.Rows[i].Cells[4].Value.ToString();
                            string iProductAmt = dGV_Product.Rows[i].Cells[5].Value.ToString();
                            decimal iPrice = Convert.ToDecimal(iProductPrice);
                            DataTable idtProductBilCheck;
                            string isqlProductBillCheck = "SELECT * FROM tb_productsalebill where Bill_ID = '" + ilbBillID + "'AND Product_ID = '" + iProductID + "' ";
                            idtProductBilCheck = iConnect.SelectByCommand(isqlProductBillCheck);//ลักษณะการทำงานคือ เมื่อเข้าไปเช็คในฐานข้อมูล หากไม่มี ให้ทำการเพิ่ม หากมีอยู่แล้ว ให้ทำการ แก้ไขให้ตรงกับปัจจุบัน
                            if (idtProductBilCheck.Rows.Count == 0)
                            {
                                string isqlProductBill = "INSERT INTO `tb_productsalebill` (`Bill_ID`, `Product_ID`, `Productsale_Bill_Unit`, `Productsale_Bill_Price`, `Productsale_Bill_Amt`) VALUES ('" + ilbBillID + "', '" + iProductID + "', '" + iProductUnit + "', '" + iProductPrice + "', '" + iProductAmt + "')";
                                iConnect.Insert(isqlProductBill);
                            }
                         }
                        //เรียกผลรวมมาแสดง
                    }
                }
            }
            loaddata();
          }
        private void BillAdd()
        {
            string ilbyear = lbYear.Text.Trim(); //Year 
            string ilbBill = Lb_CoBill.Text.Trim(); //Bill Conpany
            string itxbReferID = txb_ReferID.Text.Trim(); // HealRecord ID
            string icbEmplyee = cb_Em.SelectedValue.ToString();

            string iBillTotal = txb_BillTotal.Text.Trim();
            string iBillDC = txb_BillDC.Text.Trim();
            string iBillNet = txb_BillNet.Text.Trim();
            string ilbBillID = Lb_BillID.Text.Trim();
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            string idTPProductSaleDate = dTP_ProductSaleDate.Value.ToString("yyyy-MM-dd");
            if ((Lb_BillID.Text == null) || (Lb_BillID.Text == ""))
            {
                string isqlAddBill = "INSERT INTO `tb_bill` (`Bill_ID`, `Refer_ID`, `Em_ID`, `Bill_Date`, `BillSale_Total`, `BillSale_DC`, `BillSale_Net`) VALUES (CONCAT('" + ilbyear + ilbBill + "', LPAD(  IFNULL( (SELECT SUBSTR(`Bill_ID`, 5) FROM `tb_Bill` AS `alias` WHERE SUBSTR(`Bill_ID`, 1, 2) = ('" + ilbyear + "')  ORDER BY `Bill_ID` DESC LIMIT 1 ) + 1, 1 ),  5, '0' )), '" + itxbReferID + "', '" + icbEmplyee + "', '" + idTPProductSaleDate + "', '" + iBillTotal + "', '" + iBillDC + "', '" + iBillNet + "')";
                iConnect.Insert(isqlAddBill);
                DataTable idtBillID;
                string isqlBillID = "SELECT Bill_ID FROM tb_Bill WHERE SUBSTR(`Bill_ID`, 1, 2) = ('" + ilbyear + "')  ORDER BY `Bill_ID` DESC LIMIT 1";
                idtBillID = iConnect.SelectByCommand(isqlBillID);
                Lb_BillID.Text = idtBillID.Rows[0].Field<string>(0);
            }
            else
            {
                //UPdateBill
                string isqlBillUpdate = "UPDATE `tb_bill` SET `Em_ID`='" + icbEmplyee + "', `Bill_Date`='" + idTPProductSaleDate + "', `BillSale_Total`='" + iBillTotal + "', `BillSale_DC`='" + iBillDC + "', `BillSale_Net`='" + iBillNet + "' WHERE `Bill_ID`='" + ilbBillID + "'";
                iConnect.Insert(isqlBillUpdate);
            }
        }

        private void Lb_BillID_TextChanged(object sender, EventArgs e)
        {
            loadProductSale();
        }

        private void txb_ReferID_TextChanged(object sender, EventArgs e)
        {
            loadProductSale();
        }

        private void txb_BillTotal_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txb_BillDC_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

    }
}
