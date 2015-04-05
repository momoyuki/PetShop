using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Petshop
{
    public partial class FrmMM15 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmMM15()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
            
        }

        private void Bt_LoadEP_Click(object sender, EventArgs e)
        {
            LoadEmPloyee();
        }

        private void LoadEmPloyee()
        {
            DataTable idtEmployee;
            string isqlCommand = "SELECT tb_employee.*,tb_emposition.Em_Position,tb_emlogin.Em_user,tb_emlogin.Em_Pwd FROM `tb_employee`,tb_emposition,tb_emlogin where tb_employee.EmPosition_ID = tb_emposition.EmPosition_ID AND tb_employee.Em_ID = tb_emlogin.Em_ID";
            idtEmployee = iConnect.SelectByCommand(isqlCommand);
            dGV_Ep.DataSource = idtEmployee;
            dGV_Ep.Refresh();
        }

        private void bt_LoadPS_Click(object sender, EventArgs e)
        {
            LoadEmpoition();
        }

        private void LoadEmpoition()
        {
            DataTable idtEmPosition;
            string isqlCommand = "SELECT * FROM `tb_Emposition`";
            idtEmPosition = iConnect.SelectByCommand(isqlCommand);
            cb_EmPosition.DisplayMember = idtEmPosition.Columns["Em_Position"].ColumnName;
            cb_EmPosition.ValueMember = idtEmPosition.Columns["EmPosition_ID"].ColumnName;
            cb_EmPosition.DataSource = idtEmPosition;
            dGV_PS.DataSource = idtEmPosition;
            dGV_PS.Refresh();
        }
        private void bt_AddEmPosition_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            if ((txb_Emposition.Text != null)&&(txb_Emposition.Text != string.Empty))
            {
                string itxbEmposition = txb_Emposition.Text.Trim();
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มตำแหน่ง " + itxbEmposition + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlEmposition = "INSERT INTO `tb_emposition` (`EmPosition_ID`, `Em_Position`) VALUES (NULL, '" + itxbEmposition + "')";
                    iConnect.Insert(isqlEmposition);
                    ClearTxbPosition();
                    LoadEmPloyee();
                    LoadEmpoition();
                }
            }
            else
            {
                epCheck.SetError(txb_Emposition, "กรุณาระบุตำแหน่ง");
            }
            
        }

        private void ClearTxbPosition()
        {
            txb_EmpositionID.Clear();
            txb_Emposition.Clear();
        }
        string iAddEditEmployee;
        private void bt_AddEm_Click(object sender, EventArgs e)
        {
            iAddEditEmployee = "AddEmployee";
            AddEditEmployee();
        }

        private void AddEditEmployee()
        {
            Regex RegID = new Regex(@"^(\d{13})$");
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            if (!RegID.IsMatch(txb_EmID.Text))
            {
                epCheck.SetError(txb_EmID, "กรุณาระบุรหัสสมาชิก 13 หลัก");
                txb_EmID.Focus();
            }
            else if(!RegString.IsMatch(txb_EmName.Text)){
                epCheck.SetError(txb_EmName, "กรุณาระบุชื่อสมาชิก");
                txb_EmName.Focus();
            }
            else
            {
                string itxbEmID = txb_EmID.Text.Trim();
                string itxbEmName = txb_EmName.Text.Trim();
                string icbEmPosition = cb_EmPosition.SelectedValue.ToString();
                string itxbUser = txb_UserName.Text.Trim();
                string itxbPwd = txb_Pwd.Text.Trim();
                byte[] hash;
                using (MD5 md5 = MD5.Create())
                {
                    hash = md5.ComputeHash(Encoding.UTF8.GetBytes(itxbPwd));
                }
                string ipwd = Convert.ToBase64String(hash);

                int iStatus;
                if (CheckBox_Status.Checked == true)
                {
                    iStatus = 1;
                }
                else
                {
                    iStatus = 0;
                }
                if (iAddEditEmployee == "AddEmployee")
                {
                    DialogResult iConfirmResult = MessageBox.Show("เพิ่มพนักงาน " + itxbEmName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlEmployee = "INSERT INTO `tb_employee` (`Em_ID`, `Em_Name`, `EmPosition_ID`,Em_Status) VALUES ('" + itxbEmID + "', '" + itxbEmName + "', '" + icbEmPosition + "',b'" + iStatus + "');";
                        iConnect.Insert(isqlEmployee);
                        //string isqlEmLogin = "INSERT INTO `tb_emlogin` (`Em_ID`, `Em_User`, `Em_Pwd`) VALUES ('" + itxbEmID + "', '" + itxbUser + "', '" + ipwd + "')";
                        //iConnect.Insert(isqlEmLogin);
                        ClearTxbEmployee();
                    }
                }
                else if (iAddEditEmployee == "EditEmployee")
                {
                    DialogResult iConfirmResult = MessageBox.Show("แก้ไขตำแหน่ง " + itxbEmName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlEmployee = "UPDATE `tb_employee` SET `Em_ID` = '" + itxbEmID + "', `Em_Name` = '" + itxbEmName + "', `EmPosition_ID` = '" + icbEmPosition + "' ,Em_Status = b'" + iStatus + "' WHERE `tb_employee`.`Em_ID` = '" + itxbEmID + "'";
                        iConnect.Insert(isqlEmployee);
                        //string isqlEmLogin = "UPDATE `tb_emlogin` SET `Em_User`='" + itxbUser + "', `Em_Pwd`='" + ipwd + "' WHERE `Em_ID`='" + itxbEmID + "'";
                        //iConnect.Insert(isqlEmLogin);
                        ClearTxbEmployee();
                    }
                }
            }
            iAddEditEmployee = string.Empty;
            LoadEmPloyee();
            LoadEmpoition();
        }

        private void ClearTxbEmployee()
        {
            txb_EmID.Clear();
            txb_EmName.Clear();
            txb_UserName.Clear();
            txb_Pwd.Clear();
            txb_EmID.Focus();
        }

        private void FrmMM14_Load(object sender, EventArgs e)
        {
            LoadEmPloyee();
            LoadEmpoition();
        }

        private void dGV_Ep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Ep.Rows[e.RowIndex];
                txb_EmID.Text = row.Cells["ccEm_ID"].Value.ToString();
                txb_EmName.Text = row.Cells["ccEm_Name"].Value.ToString();
                //cb_Type
                txb_UserName.Text = row.Cells["ccEm_User"].Value.ToString();
                //txb_Pwd.Text = row.Cells["ccEm_Pwd"].Value.ToString();
                int iStatus = Convert.ToInt32(row.Cells["ccEm_Status"].Value);
                if (iStatus == 0)
                {
                    CheckBox_Status.Checked = false;
                }
                else
                {
                    CheckBox_Status.Checked = true;
                }
                
            }
        }

        private void dGV_PS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_PS.Rows[e.RowIndex];
                txb_EmpositionID.Text = row.Cells["ccEP_ID"].Value.ToString();
                txb_Emposition.Text = row.Cells["ccEm_Position"].Value.ToString();
            }
        }

        private void bt_EditEm_Click(object sender, EventArgs e)
        {
            iAddEditEmployee = "EditEmployee";
            AddEditEmployee();
        }

        private void bt_EditEmposition_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            if ((txb_Emposition.Text != null) && (txb_Emposition.Text != string.Empty))
            {
                string itbEmpostionID = txb_EmpositionID.Text.Trim();
                string itbEmposition = txb_Emposition.Text.Trim();
                string isqlEmposition = "UPDATE `petshop`.`tb_emposition` SET `Em_Position` = '" + itbEmposition + "' WHERE `tb_emposition`.`EmPosition_ID` = " + itbEmpostionID + "";
                DialogResult iConfirmResult = MessageBox.Show("แก้ไขตำแหน่ง " + itbEmposition + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlEmposition);
                    LoadEmPloyee();
                }
            }
            else
            {
                epCheck.SetError(txb_Emposition, "กรุณาระบุตำแหน่ง");
                txb_Emposition.Focus();
            }
        }

        private void txb_Emposition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_EmpositionID.Text == "") || (txb_EmpositionID.Text == null))
                {
                    bt_AddEmPosition.Select();
                }
                else
                {
                    bt_EditEmposition.Select();
                }
            }
        }

        private void txb_EmID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_EmName.Focus();
            }
        }

        private void txb_EmName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_EmPosition.Focus();
            }
        }



        private void txb_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_Pwd.Focus();
            }
        }

        private void txb_Pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_AddEm.Select();
            }
        }

        private void bt_DelPosition_Click(object sender, EventArgs e)
        {
            string itxbPositionID = txb_EmpositionID.Text.Trim();
            string itxbEmposition = txb_Emposition.Text.Trim();
            if ((itxbPositionID != null) && (itxbPositionID != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxbEmposition + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtEmposition;
                    string isqlEmposition = "SELECT EmPosition_ID FROM petshop.tb_employee where Emposition_ID = '"+itxbPositionID+"'";
                    idtEmposition = iConnect.SelectByCommand(isqlEmposition);
                    if (idtEmposition.Rows.Count == 0)
                    {
                        string isqlDelEmposition = "DELETE FROM `petshop`.`tb_emposition` WHERE `EmPosition_ID`='"+itxbPositionID+"'";
                        iConnect.Insert(isqlDelEmposition);
                        MessageBox.Show("ทำการลบยาออกแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบได้");
                    }
                }
                LoadEmpoition();
                LoadEmPloyee();
            }
        }

        private void cb_EmPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_AddEm.Select();
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
