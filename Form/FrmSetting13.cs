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
    public partial class FrmSetting13 : Form
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public FrmSetting13()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }
        String iAddEditOutlay;
        private void bt_Addoutlay_Click(object sender, EventArgs e)
        {
            iAddEditOutlay = "AddOutlay";
            AddEditOutlay();
        }
        private void bt_Editoutlay_Click(object sender, EventArgs e)
        {
            iAddEditOutlay = "EditOutlay";
            AddEditOutlay();
        }

        private void AddEditOutlay()
        {
            epCheck.Clear();
            Regex RegMoney = new Regex(@"^((\d{1,8})|(\d{1,6}\.\d{1,2}))$");
            Regex RegInt = new Regex(@"^(\d{1,3})$");
            if (txb_outlayDetail.Text == string.Empty)
            {
                epCheck.SetError(txb_outlayDetail,"กรุณาระบุรายละเอียด");
                txb_outlayDetail.Focus();
            }
            else if (!RegMoney.IsMatch(txb_outlayPrice.Text))
            {
                epCheck.SetError(txb_outlayPrice,"คุณกรอกไม่ถูกต้อง");
                txb_outlayPrice.Focus();
                txb_outlayPrice.Text = "0.00";
            }
            else
            {
                string itxboutlayID = txb_outlayID.Text.Trim();
                string itxboutlayDetail = txb_outlayDetail.Text.Trim();
                string itxboutlayPrice = txb_outlayPrice.Text.Trim();

                if (iAddEditOutlay == "AddOutlay")
                {
                    DialogResult iConfirmResult = MessageBox.Show("เพิ่มรายการ รายจ่าย " + itxboutlayDetail + " มั๊ย?", "เพิ่มรายการ..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlUnit = "INSERT INTO `petshop`.`tb_outlay` (`outlay_Detail`, `outlay_Price`) VALUES ('" + itxboutlayDetail + "', '" + itxboutlayPrice + "');";
                        iConnect.Insert(isqlUnit);
                        loadData();
                        clearTxb();
                    }
                }
                else if (iAddEditOutlay == "EditOutlay")
                {
                    if (txb_outlayID.Text != string.Empty)
                    {
                        DialogResult iConfirmResult = MessageBox.Show("แก้ไขเป็น " + itxboutlayDetail + " มั๊ย?", "แก้ไขรายการ..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {
                            string isqloutlay = "UPDATE `petshop`.`tb_outlay` SET `outlay_Detail`='" + itxboutlayDetail + "', `outlay_Price`='" + itxboutlayPrice + "' WHERE `outlay_ID`='" + itxboutlayID + "'";
                            iConnect.Insert(isqloutlay);
                            loadData();
                            clearTxb();
                        }
                    }
                    else
                    {
                        epCheck.SetError(txb_outlayID,"กรุณาเลือกรายการที่จะแก้ไข");
                    }
                    
                }
            }  
        }
    

        private void clearTxb()
        {
            txb_outlayID.Clear();
            txb_outlayDetail.Clear();
            txb_outlayPrice.Clear();
        }
        private void loadData()
        {
            DataTable idtoutlay;
            string isqlcommand = "SELECT * FROM petshop.tb_outlay";
            idtoutlay = iConnect.SelectByCommand(isqlcommand);
            dGV_outlay.DataSource = idtoutlay;
            dGV_outlay.Refresh();
            lb_Searchoutlay.Text = idtoutlay.Rows.Count.ToString();
        }

        private void FrmSetting13_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bt_Resetoutlay_Click(object sender, EventArgs e)
        {
            clearTxb();
        }

        private void txb_outlayID_TextChanged(object sender, EventArgs e)
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

        private void bt_Deloutlay_Click(object sender, EventArgs e)
        {
            Deloulay();
        }

        private void Deloulay()
        {
            epCheck.Clear();
            string itxboutlayID = txb_outlayID.Text.Trim();
            string itxboutlayDetail = txb_outlayDetail.Text.Trim();
            string itxboutlayPrice = txb_outlayPrice.Text.Trim();
            if ((itxboutlayID != null) && (itxboutlayID != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxboutlayDetail + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtoutlayDetail;
                    string isqloutlayDetail = "SELECT * FROM petshop.tb_outlaydetail where outlay_ID = '"+itxboutlayID+"'";
                    idtoutlayDetail = iConnect.SelectByCommand(isqloutlayDetail);
                    if (idtoutlayDetail.Rows.Count == 0)
                    {
                        string isqlDeloutlay = "DELETE FROM `petshop`.`tb_outlay` WHERE `outlay_ID`='"+itxboutlayID+"'";
                        iConnect.Insert(isqlDeloutlay);
                        clearTxb();
                        MessageBox.Show("ทำการลบรายการรายจ่ายออกแล้ว");
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

        private void Bt_Loadoutlay_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dGV_outlay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_outlay.Rows[e.RowIndex];
                txb_outlayID.Text = row.Cells["ccoutlay_ID"].Value.ToString();
                txb_outlayDetail.Text = row.Cells["ccoutlay_detail"].Value.ToString();
                txb_outlayPrice.Text = row.Cells["ccoutlay_Price"].Value.ToString();
            }
        }

        private void bt_Searchoutlay_Click(object sender, EventArgs e)
        {
            Searchoutlay();
        }

        private void Searchoutlay()
        {
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            if (RegString.IsMatch(txb_Searchoutlay.Text))
            {
                string itxbSearchoutlay = txb_Searchoutlay.Text.Trim();
                DataTable idtSearchOutlay;
                string isqlSearch = "SELECT * FROM petshop.tb_outlay where outlay_ID like '%" + itxbSearchoutlay + "%' OR outlay_Detail like '%" + itxbSearchoutlay + "%' OR outlay_Price like '%" + itxbSearchoutlay + "%' ";
                idtSearchOutlay = iConnect.SelectByCommand(isqlSearch);
                lb_Searchoutlay.Text = idtSearchOutlay.Rows.Count.ToString();
                dGV_outlay.DataSource = idtSearchOutlay;
                dGV_outlay.Refresh();
            }
            else
            {
                loadData();
            }
        }

        private void txb_Searchoutlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searchoutlay();
            }
        }

        private void txb_outlayDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_outlayPrice.Focus();
            }
        }

        private void txb_outlayRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_outlayID.Text != null) && (txb_outlayID.Text != string.Empty))
                {
                    bt_Editoutlay.Select();
                }
                else
                {
                    bt_Addoutlay.Select();
                }
            }
        }

    }
}
