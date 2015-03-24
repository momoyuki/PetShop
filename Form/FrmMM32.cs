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
            loadDataRefer();
            loadEmployee();
            loadCompany();
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
            string isqlEmployee = "SELECT * FROM petshop.tb_employee";
            idtEmployee = iConnect.SelectByCommand(isqlEmployee);
            cb_Em.DisplayMember = idtEmployee.Columns["Em_Name"].ColumnName;
            cb_Em.ValueMember = idtEmployee.Columns["Em_ID"].ColumnName;
            cb_Em.DataSource = idtEmployee;
        }

        private void loadDataRefer()
        {
            string iTxbreferID = txb_ReferID.Text.Trim();
            if((iTxbreferID !=null)&&(iTxbreferID !="")){
                DataTable idtProduct;
                string isqlProduct = "SELECT tb_productsaledetail.*,Product_Des FROM tb_productsaledetail,tb_Product where ProductSale_ID = " + iTxbreferID + " AND tb_productsaledetail.Product_ID = tb_Product.Product_ID";
                 idtProduct=iConnect.SelectByCommand(isqlProduct);
               
                 dGV_Product.DataSource = idtProduct;
                 dGV_Product.Refresh();
            }
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            AddProductBill();
        }

        private void AddProductBill()
        {
            string ilbBillID = Lb_BillID.Text.Trim();
            string itxbReferID = txb_ReferID.Text.Trim();
            if ((txb_ReferID.Text != null) || (txb_ReferID.Text != ""))
            {
                if ((Lb_BillID.Text != null) || (Lb_BillID.Text != ""))
                {
                    for (int i = dGV_Product.Rows.Count - 1; i >= 0; i--)
                    {
                        if (dGV_Product.Rows[i].Cells[0].Value != null)
                        {
                            string iBillID = dGV_Product.Rows[i].Cells[1].Value.ToString();
                            string iProductID = dGV_Product.Rows[i].Cells[2].Value.ToString();
                            //MessageBox.Show(iProductID); //ทดสอบ
                            string iProductUnit = dGV_Product.Rows[i].Cells[4].Value.ToString();
                            string iPrice = dGV_Product.Rows[i].Cells[5].Value.ToString();
                            string iProductTotal = dGV_Product.Rows[i].Cells[6].Value.ToString();
                            DataTable idtCheckProductBill;
                            string isqlCheckProductBill = "SELECT * FROM  tb_productsalebill where Bill_ID = '" + iBillID + "' AND Product_ID'" + iProductID + "'";
                           idtCheckProductBill = iConnect.SelectByCommand(isqlCheckProductBill);
                            if (idtCheckProductBill.Rows.Count > 0) {
                            } else 
                            {
                            string isqlBillDetail = "INSERT INTO `tb_productsalebill` (`Bill_ID`, `Refer_ID`, `Product_ID`, `ProductSale_Bill_Unit`, `ProductSale_Bill_Price`, `ProductSale_Bill_Amt`) VALUES ('" + iBillID + "', '" + itxbReferID + "','" + iProductID + "', '" + iProductUnit + "', '" + iPrice + "', '" + iProductTotal + "')";
                            iConnect.Insert(isqlBillDetail); 
                                }
                            if (dGV_Product.Rows[i].Cells[0].Value == null)
                            { //ถ้าไม่ติ๊ก
                            
                            
                            }
                        }
                    }
                    foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                    {
                        if (form.GetType() == typeof(FrmBillreview))
                        {
                            form.Activate();
                            return;
                        }
                    }
                    FrmBillreview iFrmBill = new FrmBillreview();
                    iFrmBill.MdiParent = MainForm.ActiveForm;
                    iFrmBill.Show();
                    iFrmBill.lb_BillID.Text = Lb_BillID.Text.Trim();
                }
                else {
                    BillAdd();
                    AddProductBill();
                }
            }
        }

        private void BillAdd()
        {
            string ilbyear = lbYear.Text.Trim();
            string ilbBill = Lb_CoBill.Text.Trim();
            string itxbReferID = txb_ReferID.Text.Trim();
            string icbEmplyee = cb_Em.SelectedValue.ToString();

            string iBillTotal = txb_BillTotal.Text.Trim();
            string iBillDC = txb_BillDC.Text.Trim();
            string iBillNet = txb_BillNet.Text.Trim();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            string idTPProductSaleDate = dTP_ProductSaleDate.Value.ToString("yyyy-MM-dd");
            if ((Lb_BillID.Text == null)||(Lb_BillID.Text ==""))
            {
                string isqlAddBill = "INSERT INTO `tb_bill` (`Bill_ID`, `Refer_ID`, `Em_ID`, `Bill_Date`, `BillSale_Total`, `BillSale_DC`, `BillSale_Net`) VALUES (CONCAT('" + ilbyear + ilbBill + "', LPAD(  IFNULL( (SELECT SUBSTR(`Bill_ID`, 5) FROM `tb_Bill` AS `alias` WHERE SUBSTR(`Bill_ID`, 1, 2) = ('" + ilbyear + "')  ORDER BY `Bill_ID` DESC LIMIT 1 ) + 1, 1 ),  5, '0' )), '" + itxbReferID + "', '" + icbEmplyee + "', '" + idTPProductSaleDate + "', '" + iBillTotal + "', '" + iBillDC + "', '" + iBillNet + "')";
                iConnect.Insert(isqlAddBill);
                DataTable idtBillID;
                string isqlBillID = "SELECT Bill_ID FROM tb_Bill WHERE SUBSTR(`Bill_ID`, 1, 2) = ('" + ilbyear + "')  ORDER BY `Bill_ID` DESC LIMIT 1";
                idtBillID = iConnect.SelectByCommand(isqlBillID);
                Lb_BillID.Text = idtBillID.Rows[0].Field<string>(0);

            }
            else { 
            ////////////UPDateBill
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
        
    }
}
