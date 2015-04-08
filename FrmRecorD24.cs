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
    public partial class FrmRecorD24 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmRecorD24()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            loadEmployee();
            loadoutlay();
            loadoutlayDetail();
        }

        private void loadoutlayDetail()
        {
            DataTable idtoutlay;
            string isqloutlay = "SELECT tb_outlaydetail.*,tb_outlay.outlay_Detail,tb_employee.em_Name FROM petshop.tb_outlaydetail,tb_outlay,tb_employee where tb_outlaydetail.outlay_ID = tb_outlay.outlay_ID AND tb_outlaydetail.Em_ID = tb_employee.Em_ID";
            idtoutlay = iConnect.SelectByCommand(isqloutlay); 
            if(idtoutlay.Rows.Count >0){
                dGV_outlay.DataSource = idtoutlay;
                dGV_outlay.Refresh();
            }
        }
        private void FrmRecorD24_Load(object sender, EventArgs e)
        {
            loadEmployee();
            loadoutlay();
            loadoutlayDetail();
        }

        private void loadoutlay()
        {
            DataTable idtoutlay;
            string isqloutlay = "SELECT * FROM petshop.tb_outlay";
            idtoutlay = iConnect.SelectByCommand(isqloutlay);
            if (idtoutlay.Rows.Count > 0)
            {
                cb_outlay.DisplayMember = idtoutlay.Columns["outlay_Detail"].ColumnName;
                cb_outlay.ValueMember = idtoutlay.Columns["outlay_ID"].ColumnName;
                cb_outlay.DataSource = idtoutlay;
            }
        }

        private void loadEmployee()
        {
            DataTable idtEmployee;
            string isqlEmployee = "SELECT * FROM tb_employee where Em_Status = 1";
            idtEmployee = iConnect.SelectByCommand(isqlEmployee);
            if (idtEmployee.Rows.Count > 0)
            {
                cb_Em.DisplayMember = idtEmployee.Columns["Em_Name"].ColumnName;
                cb_Em.ValueMember = idtEmployee.Columns["Em_ID"].ColumnName;
                cb_Em.DataSource = idtEmployee;
            }
        }

        private void bt_AddoutlayDetail_Click(object sender, EventArgs e)
        {
            AddoutlayDetail();
        }

        private void AddoutlayDetail()
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            string ioutlayDate = dTP_outlayDate.Value.ToString("yyyy-MM-dd");
            string icboutlay = cb_outlay.SelectedValue.ToString();
            string icbEm = cb_Em.SelectedValue.ToString();
            string itxboutlayAmt = txb_outlayAmt.Text.Trim();
            string itxboutlayRemark = txb_outlayRemark.Text.Trim();
             DialogResult iConfirmResult = MessageBox.Show("เพิ่มรายการ รายจ่าย " + cb_outlay.SelectedText.ToString() + " มั๊ย?", "เพิ่มรายการ..", MessageBoxButtons.YesNo);
             if (iConfirmResult == DialogResult.Yes)
             {
                 string isqlAddOutlay = "INSERT INTO `petshop`.`tb_outlaydetail` (`Em_ID`, `outlayDetail_Date`, `outlay_ID`, `outlayDetail_Remark`, `outlayDetail_Amt`) VALUES ('" + icbEm + "', '" + ioutlayDate + "', '" + icboutlay + "', '" + itxboutlayRemark + "', '" + itxboutlayAmt + "')";
                 iConnect.Insert(isqlAddOutlay);
                 MessageBox.Show("เพิ่มรายจ่ายแล้ว");
                 loadoutlayDetail();
                 clearTxb();
             }
        }

        private void clearTxb()
        {
            txb_outlayAmt.Clear();
            txb_outlayRemark.Clear();
        }

        private void bt_DeloutlayDetail_Click(object sender, EventArgs e)
        {
            string ilboutlayID = lb_outlayID.Text.Trim();
            //string icboutlay = cb_outlay.SelectedText.ToString();
            if((lb_outlayID.Text != string.Empty)&&(lb_outlayID.Text !=null)){
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + ilboutlayID + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlDel = "DELETE FROM `petshop`.`tb_outlaydetail` WHERE `outlayDetail_ID`='" + ilboutlayID + "'";
                    iConnect.Insert(isqlDel);
                    MessageBox.Show("ทำการลบข้อมูลแล้ว");
                }
             }
        }

        private void dGV_outlay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_outlay.Rows[e.RowIndex]; //ขาด Combox DateTimePicker 3 ชิ้น 
                lb_outlayID.Text = row.Cells["ccoutlayDetail_ID"].Value.ToString();
                cb_Em.SelectedValue = row.Cells["ccEm_ID"].Value.ToString();
                cb_outlay.SelectedValue = row.Cells["ccOutlay_ID"].Value.ToString();
                txb_outlayRemark.Text = row.Cells["ccoutlayDetail_Remark"].Value.ToString();
                txb_outlayAmt.Text = row.Cells["ccoutlayDetail_Amt"].Value.ToString();
            }
        }
    }
}
