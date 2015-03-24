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
    public partial class FrmMM13 : Form
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public FrmMM13()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }

        private void bt_LoadUnit_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable idtUnit;
            string isqlcommand = "SELECT * FROM `tb_unit`";
            idtUnit = iConnect.SelectByCommand(isqlcommand);
            dGV_Uni.DataSource = idtUnit;
            dGV_Uni.Refresh();
        }

        private void bt_AddUnit_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void AddData()
        {
            string itxbUnitName = txb_UnitName.Text.Trim();

            string isqlUnit = "INSERT INTO `petshop`.`tb_unit` (`Unit_ID`, `Unit_Name`) VALUES (NULL, '" + itxbUnitName + "')";
            DialogResult iConfirmResult = MessageBox.Show("เพิ่มบริการ " + itxbUnitName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlUnit);
                loadData();

            }
        }

        private void bt_EditUnit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void EditData()
        {
            string itxbUnitID = txb_UnitID.Text.Trim();
            string itxbUnitName = txb_UnitName.Text.Trim();

            string isqlUnit = "UPDATE `tb_unit` SET `Unit_Name` = '" + itxbUnitName + "' WHERE `tb_unit`.`Unit_ID` = " + itxbUnitID + ";";
            DialogResult iConfirmResult = MessageBox.Show("แก้ไขหน่วย " + itxbUnitName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlUnit);
                loadData();
            }
        }

        private void FrmMM13_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txb_UnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_UnitID.Text == "") || (txb_UnitID.Text == null)) {
                    bt_AddUnit.Select();
                }
                else
                {
                    bt_EditUnit.Select();
                }
            }
        }

        private void dGV_Uni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Uni.Rows[e.RowIndex];
                txb_UnitID.Text = row.Cells["ccUnit_ID"].Value.ToString();
                txb_UnitName.Text = row.Cells["ccUnit_Name"].Value.ToString();
            }
        }
    }
}
