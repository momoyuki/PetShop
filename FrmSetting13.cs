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
    public partial class FrmSetting13 : Form
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public FrmSetting13()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }

        private void bt_Addincome_Click(object sender, EventArgs e)
        {
            Addincome();
        }

        private void Addincome()
        {
            epCheck.Clear();
            string itxboutlayID = txb_outlayID.Text.Trim();
            string itxboutlayDetail = txb_outlayDetail.Text.Trim();
            string itxboutlayRemark = txb_outlayRemark.Text.Trim();
            if ((itxboutlayDetail != null) && (itxboutlayDetail != string.Empty))
            {
                string isqlUnit = "INSERT INTO `petshop`.`tb_outlay` (`outlay_Detail`, `outlay_Remark`) VALUES ('" + itxboutlayDetail + "', '" + itxboutlayRemark + "');";
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มรายการ รายจ่าย " + itxboutlayDetail + " มั๊ย?", "เพิ่มรายการ..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlUnit);
                    loadData();
                    clearTxb();
                }
            }
            else
            {
                epCheck.SetError(txb_outlayDetail, "กรุณากรอกรายละเอียด");
                txb_outlayDetail.Focus();
            }
        }

        private void clearTxb()
        {
            txb_outlayID.Clear();
            txb_outlayDetail.Clear();
            txb_outlayRemark.Clear();
        }

        private void Bt_Loadincome_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable idtoutlay;
            string isqlcommand = "SELECT * FROM petshop.tb_outlay";
            idtoutlay = iConnect.SelectByCommand(isqlcommand);
            dGV_outlay.DataSource = idtoutlay;
            dGV_outlay.Refresh();
        }

        private void FrmSetting13_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txb_incomeID_TextChanged(object sender, EventArgs e)
        {
            if ((txb_outlayID.Text != null) && (txb_outlayID.Text != string.Empty)) 
            {
                bt_Editoutlay.Enabled = true;
                bt_Deloutlay.Enabled = true;
            }
            else
            {
                bt_Editoutlay.Enabled = false;
                bt_Deloutlay.Enabled = false;
            }
        }

        private void bt_Resetincome_Click(object sender, EventArgs e)
        {
            clearTxb();
        }

        private void bt_Editincome_Click(object sender, EventArgs e)
        {
            Editincome();
        }

        private void Editincome()
        {
            epCheck.Clear();
            string itxboutlayID = txb_outlayID.Text.Trim();
            string itxboutlayDetail = txb_outlayDetail.Text.Trim();
            string itxboutlayRemark = txb_outlayRemark.Text.Trim();
            if ((itxboutlayDetail == null) || (itxboutlayDetail == string.Empty))
            {
                epCheck.SetError(txb_outlayDetail, "กรุณากรอกรายละเอียด");
                txb_outlayDetail.Focus();
            }
            else if ((itxboutlayID == null) || (itxboutlayID == string.Empty))
            {
                epCheck.SetError(txb_outlayID, "คุณยังไม่ได้เลือกรายการที่จะแก้ไข");
            }
            else
            {
                DialogResult iConfirmResult = MessageBox.Show("แก้ไขเป็น " + itxboutlayDetail + " มั๊ย?", "แก้ไขรายการ..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqloutlay = "UPDATE `petshop`.`tb_outlay` SET `outlay_Detail`='" + itxboutlayDetail + "', `outlay_Remark`='" + itxboutlayRemark + "' WHERE `outlay_ID`='" + itxboutlayID + "'";
                    iConnect.Insert(isqloutlay);
                    loadData();
                    clearTxb();
                }
            }
        }

        private void bt_Delincome_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            string itxboutlayID = txb_outlayID.Text.Trim();
            string itxboutlayDetail = txb_outlayDetail.Text.Trim();
            string itxboutlayRemark = txb_outlayRemark.Text.Trim();
            if ((itxboutlayID != null) && (itxboutlayID != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxboutlayDetail + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtoutlay;
                    string isqloutlay = "SELECT * FROM petshop.tb_outlaydetail where outlay_ID = '" + itxboutlayID + "'";
                    idtoutlay = iConnect.SelectByCommand(isqloutlay);
                      if (idtoutlay.Rows.Count == 0)
                    {
                        string isqlDelUnit = "DELETE FROM `petshop`.`tb_outlay` WHERE `outlay_ID`='" + itxboutlayID + "'";
                        iConnect.Insert(isqlDelUnit);
                        clearTxb();
                        MessageBox.Show("ทำการลบรายการออกแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบได้");
                    }
                }
                loadData();
            }
            else
            {
                epCheck.SetError(txb_outlayID, "กรุณาเลือกหน่วยที่ต้องการลบ");
            }
        }

        private void dGV_income_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_outlay.Rows[e.RowIndex];
                txb_outlayID.Text = row.Cells["ccoutlay_ID"].Value.ToString();
                txb_outlayDetail.Text = row.Cells["ccoutlay_detail"].Value.ToString();
                txb_outlayRemark.Text = row.Cells["ccoutlay_Remark"].Value.ToString();
            }
        }
    }
}
