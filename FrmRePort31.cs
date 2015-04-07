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
        }
        

        private void FrmRePort31_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadBill() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
        {
            DataTable idtBillAll;
            string isqlCommand = "SELECT * FROM petshop.tb_bill;";
            idtBillAll = iConnect.SelectByCommand(isqlCommand);
            dGV_Bill.DataSource = idtBillAll;
            dGV_Bill.Refresh();
        }

        private void loadBillDetail() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
        {
           
            DataTable idtBillDetail;
            //idtBillDetail = iConnect.SelectByCommand(isqlCommand);
            //dGV_Detail.DataSource = idtBillDetail;
            //dGV_Detail.Refresh(); 
        }
    }
}
