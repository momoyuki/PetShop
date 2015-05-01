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
    public partial class FrmRePort31 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmRePort31()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            loadBill();
            loadBillDetail();
        }
        
        private void FrmRePort31_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadBill() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
        {
            DataTable idtBillAll;
            string isqlCommand = "SELECT tb_bill.*,tb_employee.Em_Name FROM tb_bill,tb_employee where tb_bill.Em_ID = tb_employee.Em_ID";
            idtBillAll = iConnect.SelectByCommand(isqlCommand);
            dGV_Bill.DataSource = idtBillAll;
            dGV_Bill.Refresh();
        }

        private void loadBillDetail() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
        {
            string ilbBillID = Lb_BillID.Text.Trim();
            DataTable idtBillDetail;
            string isqlBillDetail = "SELECT tb_servicebill.Bill_ID,tb_servicebill.Service_ID as Item_ID,tb_service.Service_Des as Item_Detail,tb_servicebill.Service_Bill_Unit as Bill_Unit,tb_servicebill.Service_Bill_Price as Bill_Price,tb_servicebill.Service_Bill_Amt as Bill_Amt FROM  tb_servicebill,tb_service where tb_servicebill.Service_ID = tb_service.Service_ID AND Bill_ID ='"+ilbBillID+"'"
                                    +" union " 
                                    +" SELECT tb_productsalebill.Bill_ID as Bill_ID,tb_productsalebill.Product_ID as Item_ID,tb_product.Product_Des as Item_Detail,tb_productsalebill.ProductSale_Bill_Unit as Bill_Unit,tb_productsalebill.ProductSale_Bill_Price as Bill_Price,tb_productsalebill.ProductSale_Bill_Amt as Bill_Amt FROM tb_productsalebill,tb_product where tb_productsalebill.Product_ID = tb_product.Product_ID AND Bill_ID ='"+ilbBillID+"'"
                                    +" Union "
                                    + " SELECT tb_medibill.Bill_ID as Bill_ID,tb_medibill.Medi_ID as Item_ID,tb_medicine.Medi_Des as Item_Detail,tb_medibill.Medi_Bill_Unit as Bill_Unit,tb_medibill.Medi_Bill_Price as Bill_Price,tb_medibill.Medi_Bill_Amt as Bill_Amt FROM tb_medibill,tb_medicine where tb_medibill.Medi_ID = tb_medicine.Medi_ID AND Bill_ID ='" + ilbBillID + "'";
            idtBillDetail = iConnect.SelectByCommand(isqlBillDetail);
            dGV_Detail.DataSource = idtBillDetail;
            dGV_Detail.Refresh(); 
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            Lb_BillID.Text = "";
            txb_ReferID.Clear();
            lb_EmID.Text = "เจ้าหน้าที่";
            dTP_BillDate.Value = DateTime.Now;
            txb_BillTotal.Text = "0.00";
            txb_BillDC.Text = "0.00";
            txb_BillNet.Text = "0.00";
        }

        private void dGV_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Bill.Rows[e.RowIndex];
                Lb_BillID.Text = row.Cells["ccBill_ID"].Value.ToString();
                txb_ReferID.Text = row.Cells["ccRefer_ID"].Value.ToString();
                lb_EmID.Text = row.Cells["ccEm_Name"].Value.ToString();
                dTP_BillDate.Value = Convert.ToDateTime(row.Cells["ccBill_Date"].Value);
                txb_BillTotal.Text = row.Cells["ccBillSale_Total"].Value.ToString();
                txb_BillDC.Text = row.Cells["ccBillSale_DC"].Value.ToString();
                txb_BillNet.Text = row.Cells["ccBillSale_Net"].Value.ToString();
            }
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            if ((Lb_BillID.Text != null) && (Lb_BillID.Text != ""))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmBillSerMe))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmBillSerMe iFrmBill = new FrmBillSerMe();
                iFrmBill.MdiParent = MainForm.ActiveForm;
                iFrmBill.Show();
                iFrmBill.lb_BillID.Text = Lb_BillID.Text.Trim();
            }
        }

        private void Lb_BillID_TextChanged(object sender, EventArgs e)
        {
            loadBillDetail();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
