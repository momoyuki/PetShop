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
    public partial class FrmMM14 : Form
    {
        private MySQLDBConnect iConnect;
        public FrmMM14()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }
        private void FrmMM13_Load(object sender, EventArgs e)
        {
            LoadBreed();
            LoadType();
        }

        private void Bt_LoadBreed_Click(object sender, EventArgs e)
        {
            LoadBreed();
        }

        private void bt_LoadType_Click(object sender, EventArgs e)
        {
            LoadType();
            
        }

        private void LoadBreed()
        {
            DataTable idtBreed;
            string isqlCommand = "SELECT tb_petbreed.*,tb_pettype.PetType_Des FROM tb_petbreed,tb_pettype WHERE (tb_petbreed.PetType_ID = tb_pettype.PetType_ID)";
            idtBreed = iConnect.SelectByCommand(isqlCommand);
            dGV_Breed.DataSource = idtBreed;
            dGV_Breed.Refresh();
        }

         
        private void LoadType()
        {
            DataTable idtType;
            string isqlCommand = "SELECT * FROM `tb_pettype`";
             idtType = iConnect.SelectByCommand(isqlCommand);
            dGV_Type.DataSource = idtType;
            dGV_Type.Refresh();
            cb_Type.DisplayMember = idtType.Columns["PetType_Des"].ColumnName;
            cb_Type.ValueMember = idtType.Columns["PetType_ID"].ColumnName;
            cb_Type.DataSource = idtType;
        }

        private void bt_AddBreed_Click(object sender, EventArgs e)
        {
            AddBreed();
        }

        private void AddBreed()
        {
            epCheck.Clear();
            string itxbBreed = txb_BreedName.Text.Trim();
            string icbType = "";
            if(cb_Type.SelectedValue !=null)
            {
                icbType = cb_Type.SelectedValue.ToString();
            }
            else
            {
                LoadType();
                epCheck.GetError(cb_Type);
            }
            if ((itxbBreed != null) && (itxbBreed != string.Empty))
            {
                string isqlBreed = "INSERT INTO `tb_petbreed` (`PetBreed_ID`, `PetType_ID`, `PetBreed_Des`) VALUES (NULL, '" + icbType + "', '" + itxbBreed + "');";
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มพันธุ์ " + itxbBreed + " มั๊ย?", "เพิ่มพันธุ์สัตว์..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlBreed);
                    LoadBreed();
                    clearTxb();
                }
            }
            else
            {
                epCheck.SetError(txb_BreedName, "กรุณากรอกพันธุ์สัตว์");
                txb_BreedID.Focus();
            }
            
        }

        private void bt_AddType_Click(object sender, EventArgs e)
        {
            AddType();
        }

        private void AddType()
        {
            epCheck.Clear();
            string itxbType = txb_TypeName.Text.Trim();
            if ((itxbType != null) && (itxbType != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มประเภท " + itxbType + " มั๊ย?", "เพิ่มประเภทสัตว์..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlType = "INSERT INTO `petshop`.`tb_pettype` (`PetType_ID`, `PetType_Des`) VALUES (NULL, '" + itxbType + "')";
                    iConnect.Insert(isqlType);
                    LoadType();
                    clearTxb();
                }
            }
            else
            {
                epCheck.SetError(txb_TypeName, "กรุณาใส่ประเภทสัตว์");
                txb_TypeName.Focus();
            }
            
        }

        private void clearTxb()
        {
            txb_BreedID.Clear();
            txb_BreedName.Clear();
            txb_TypeID.Clear();
            txb_TypeName.Clear();
        }

        private void dGV_Breed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Breed.Rows[e.RowIndex]; //ขาด Combox DateTimePicker 3 ชิ้น 
                txb_BreedID.Text = row.Cells["ccPetBreed_ID"].Value.ToString();
                //cb_Type
                txb_BreedName.Text = row.Cells["ccPetBreed_Des"].Value.ToString();
                cb_Type.SelectedValue = row.Cells["ccPetType_ID"].Value.ToString(); ;
            }
        }

        private void dGV_Type_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Type.Rows[e.RowIndex];
                txb_TypeID.Text = row.Cells["ccPT_ID"].Value.ToString();
                //cb_Type
                txb_TypeName.Text = row.Cells["ccPetType_Des"].Value.ToString();
            }
        }


        private void bt_EditBreed_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            string itxbBreedID = txb_BreedID.Text.Trim();
            string itxbBreed = txb_BreedName.Text.Trim();
            string icbType = cb_Type.SelectedValue.ToString();
            if ((itxbBreed != null) && (itxbBreed != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("แก้ไขพันธุ์ " + itxbBreed + " มั๊ย?", "แก้ไขพันธุ์สัตว์..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlBreed = "UPDATE `tb_petbreed` SET `PetType_ID` = '" + icbType + "', `PetBreed_Des` = '" + itxbBreed + "' WHERE `tb_petbreed`.`PetBreed_ID` = " + itxbBreedID + "";
                    iConnect.Insert(isqlBreed);
                    LoadBreed();
                    clearTxb();
                }
            }
            else
            {
                epCheck.SetError(txb_BreedName, "กรุณาใส่พันธุ์สัตว์");
                txb_BreedName.Focus();
            }
        }

        private void bt_EditType_Click(object sender, EventArgs e)
        {
            EditType();
        }

        private void EditType()
        {
            epCheck.Clear();
            string itxbTypeID = txb_TypeID.Text.Trim();
            string itxbType = txb_TypeName.Text.Trim();
            if ((itxbType != null) && (itxbType != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("แก้ไขประเภท " + itxbType + " มั๊ย?", "แก้ไขประเภทสัตว์..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlType = "UPDATE `petshop`.`tb_pettype` SET `PetType_Des` = '" + itxbType + "' WHERE `tb_pettype`.`PetType_ID` = " + itxbTypeID + "";
                    iConnect.Insert(isqlType);
                    LoadType();
                    clearTxb();
                }
            }
            else
            {
                epCheck.SetError(txb_TypeName, "กรุณาใส่ประเภทสัตว์");
                txb_TypeName.Focus();
            }
        }

        private void cb_Type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txb_BreedName.Focus();
        }

        private void txb_BreedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_BreedID.Text == "") || (txb_BreedID.Text == null))
                {
                    bt_AddBreed.Select();
                }
                else
                {
                    bt_EditBreed.Select();
                }
            }

        }

        private void txb_TypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if((txb_TypeID.Text !=null) && (txb_TypeID.Text !=string.Empty))
                {
                    bt_EditType.Select();
                }
                else
                {
                    bt_AddType.Select();
                }
            } 
            
        }

        private void bt_DelType_Click(object sender, EventArgs e)
        {
            string itxbTypeID = txb_TypeID.Text.Trim();
            string itxbTypeName = txb_TypeName.Text.Trim();
            if ((itxbTypeID != null) && (itxbTypeID != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxbTypeName + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtType;
                    string isqlType = "SELECT tb_petbreed.PetType_ID FROM petshop.tb_petbreed where PetType_ID = '"+itxbTypeID+"'";
                    idtType = iConnect.SelectByCommand(isqlType);
                    if (idtType.Rows.Count == 0)
                    {
                        string isqlDelType = "DELETE FROM `petshop`.`tb_pettype` WHERE `PetType_ID`='" + itxbTypeID + "'";
                        iConnect.Insert(isqlDelType);
                        MessageBox.Show("ทำการลบยาออกแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบได้");
                    }
                }
                LoadType();
            }
        }

        private void bt_DelBreed_Click(object sender, EventArgs e)
        {
            string itxbBreedID = txb_BreedID.Text.Trim();
            string itxbBreedName = txb_BreedName.Text.Trim();
            if ((itxbBreedID != null) && (itxbBreedID != string.Empty))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + itxbBreedName + " มั๊ย?", "ลบข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtPetProfiles;
                    string isqlBreed = "SELECT tb_petprofile.PetBreed_ID FROM petshop.tb_petprofile where PetBreed_ID = '"+itxbBreedID+"'";
                    idtPetProfiles = iConnect.SelectByCommand(isqlBreed);
                    if (idtPetProfiles.Rows.Count == 0)
                    {
                        string isqlDelBreed = "DELETE FROM `petshop`.`tb_petbreed` WHERE `PetBreed_ID`='" + itxbBreedID + "'";
                        iConnect.Insert(isqlDelBreed);
                        MessageBox.Show("ทำการลบยาออกแล้ว");
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบได้");
                    }
                }
                LoadBreed();
            }
        }
    }
}
