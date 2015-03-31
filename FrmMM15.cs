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
            LoadEP();
        }

        private void LoadEP()
        {
            DataTable idtEmployee;
            string isqlCommand = "SELECT tb_employee.*,tb_emposition.Em_Position,tb_emlogin.Em_user,tb_emlogin.Em_Pwd FROM `tb_employee`,tb_emposition,tb_emlogin where tb_employee.EmPosition_ID = tb_emposition.EmPosition_ID AND tb_employee.Em_ID = tb_emlogin.Em_ID";
            idtEmployee = iConnect.SelectByCommand(isqlCommand);
            dGV_Ep.DataSource = idtEmployee;
            dGV_Ep.Refresh();
        }

        private void bt_LoadPS_Click(object sender, EventArgs e)
        {
            LoadPS();
        }

        private void LoadPS()
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
            string itxbEmposition = txb_Emposition.Text.Trim();
            string isqlEmposition = "INSERT INTO `tb_emposition` (`EmPosition_ID`, `Em_Position`) VALUES (NULL, '"+itxbEmposition+"');";
            DialogResult iConfirmResult = MessageBox.Show("เพิ่มตำแหน่ง " + itxbEmposition + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlEmposition);
                LoadEP();
                LoadPS();
            }
        }

        private void bt_AddEm_Click(object sender, EventArgs e)
        {
            string itxbEmID = txb_EmID.Text.Trim();
            string itxbEm = txb_EmName.Text.Trim();
            string icbEmPosition = cb_EmPosition.SelectedValue.ToString();
            string itxbUser = txb_UserName.Text.Trim();
            string itxbPwd = txb_Pwd.Text.Trim();
           
            // ยังไม่เสร็จ
            string isqlEmployee = "INSERT INTO `tb_employee` (`Em_ID`, `Em_Name`, `EmPosition_ID`) VALUES ('"+itxbEmID+"', '"+itxbEm+"', '"+icbEmPosition+"');";
            string isqlEmLogin = "INSERT INTO `tb_emlogin` (`Em_ID`, `Em_User`, `Em_Pwd`) VALUES ('"+itxbEmID+"', '"+itxbUser+"', '"+itxbPwd+"')";

            if ((itxbEmID != null)||(itxbEmID !=""))
            {
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มพนักงาน " + itxbEm + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlEmployee);
                    iConnect.Insert(isqlEmLogin);
                    LoadEP();
                }
            }
            
        }

        private void FrmMM14_Load(object sender, EventArgs e)
        {
            LoadEP();
            LoadPS();
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
                txb_Pwd.Text = row.Cells["ccEm_Pwd"].Value.ToString();

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
            string itxbEmID = txb_EmID.Text.Trim();
            string itxbEm = txb_EmName.Text.Trim();
            string icbEmPosition = cb_EmPosition.SelectedValue.ToString();
            string itxbUser = txb_UserName.Text.Trim();
            string itxbPwd = txb_Pwd.Text.Trim();

            // ยังไม่เสร็จ
            string isqlEmployee = "UPDATE `tb_employee` SET `Em_ID` = '"+itxbEmID+"', `Em_Name` = '"+itxbEm+"', `EmPosition_ID` = '"+icbEmPosition+"' WHERE `tb_employee`.`Em_ID` = '"+itxbEmID+"'";
            string isqlEmLogin = "UPDATE `tb_emlogin` SET `Em_User`='"+itxbUser+"', `Em_Pwd`='"+itxbPwd+"' WHERE `Em_ID`='"+itxbEmID+"'";
            DialogResult iConfirmResult = MessageBox.Show("แก้ไขตำแหน่ง " + itxbEm + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlEmployee);
                iConnect.Insert(isqlEmLogin);
                LoadEP();
            }
        }

        private void bt_EditEmposition_Click(object sender, EventArgs e)
        {
            string itbEmpostionID = txb_EmpositionID.Text.Trim();
            string itbEmposition = txb_Emposition.Text.Trim();
            string isqlEmposition = "UPDATE `petshop`.`tb_emposition` SET `Em_Position` = '"+itbEmposition+"' WHERE `tb_emposition`.`EmPosition_ID` = "+itbEmpostionID+"";
            DialogResult iConfirmResult = MessageBox.Show("แก้ไขตำแหน่ง " + itbEmposition + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlEmposition);
                LoadEP();
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
                
            }
        }


    }
}
