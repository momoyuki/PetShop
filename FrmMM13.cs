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
            epCheck.Clear();
            string itxbUnitID = txb_UnitID.Text.Trim();
            string itxbUnitName = txb_UnitName.Text.Trim();
            if ((txb_UnitName.Text != null) || (txb_UnitName.Text != string.Empty))
            {
                string isqlUnit = "INSERT INTO `petshop`.`tb_unit` (`Unit_ID`, `Unit_Name`) VALUES (NULL, '" + itxbUnitName + "')";
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มบริการ " + itxbUnitName + " มั๊ย?", "เพิ่มหน่วย..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlUnit);
                    loadData();
                    clearTxb();
                }
            }
            else
            {
                epCheck.SetError(txb_UnitName, "กรุณากรอกหน่วย");
            }
           
        }

        private void clearTxb()
        {
            txb_UnitID.Clear();
            txb_UnitName.Clear();
            epCheck.Clear();
        }

        private void bt_EditUnit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void EditData()
        {
            epCheck.Clear();
            string itxbUnitID = txb_UnitID.Text.Trim();
            string itxbUnitName = txb_UnitName.Text.Trim();
            if ((txb_UnitName.Text == null) || (txb_UnitName.Text == string.Empty))
            {
                 epCheck.SetError(txb_UnitName, "กรุณากรอกหน่วย");
            } else if((txb_UnitID.Text == null)||(txb_UnitID.Text == string.Empty)){
                epCheck.SetError(txb_UnitID,"คุณยังไม่ได้เลือกหน่วยที่จะแก้ไข");
            }
            else
            {
                string isqlUnit = "UPDATE `tb_unit` SET `Unit_Name` = '" + itxbUnitName + "' WHERE `tb_unit`.`Unit_ID` = " + itxbUnitID + ";";
                DialogResult iConfirmResult = MessageBox.Show("แก้ไขหน่วย " + itxbUnitName + " มั๊ย?", "แก้ไขหน่วย..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlUnit);
                    loadData();
                    clearTxb();
                }
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


        private void bt_DelUnit_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            string itxbUnitID = txb_UnitID.Text.Trim();
            string itxbUnitName = txb_UnitName.Text.Trim();
            if ((itxbUnitID != null) && (itxbUnitID != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxbUnitName + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtUnitMedi;
                    string isqlUnitMedi = " SELECT tb_medicine.Unit_ID FROM petshop.tb_medicine where Unit_ID = '" + itxbUnitID + "'";
                    idtUnitMedi = iConnect.SelectByCommand(isqlUnitMedi);
                    DataTable idtUnitProduct;
                    string isqlUnitProduct = "SELECT tb_product.Unit_ID FROM petshop.tb_product where Unit_ID = '" + itxbUnitID + "'";
                    idtUnitProduct = iConnect.SelectByCommand(isqlUnitProduct);
                    if ((idtUnitMedi.Rows.Count == 0) && (idtUnitProduct.Rows.Count == 0))
                    {
                        string isqlDelUnit = "DELETE FROM `petshop`.`tb_unit` WHERE `Unit_ID`='" + itxbUnitID + "'";
                        iConnect.Insert(isqlDelUnit);
                        MessageBox.Show("ทำการลบยาออกแล้ว");
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
                epCheck.SetError(txb_UnitID, "กรุณาเลือกหน่วยที่ต้องการลบ");
            }
        }
    }
}
