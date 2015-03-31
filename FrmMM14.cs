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
            string isqlCommand = "SELECT tb_petbreed.PetBreed_ID,tb_pettype.PetType_Des,tb_petbreed.PetBreed_Des FROM tb_petbreed,tb_pettype WHERE (tb_petbreed.PetType_ID = tb_pettype.PetType_ID)";
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
            string itxbBreed = txb_BreedName.Text.Trim();

            string icbType = "";
            if(cb_Type.SelectedValue !=null)
            {
                icbType = cb_Type.SelectedValue.ToString();
            }
            else
            {
                LoadType();
                icbType = cb_Type.SelectedValue.ToString();
            }
            if ((itxbBreed != null) && (itxbBreed != ""))
            {
                string isqlBreed = "INSERT INTO `tb_petbreed` (`PetBreed_ID`, `PetType_ID`, `PetBreed_Des`) VALUES (NULL, '" + icbType + "', '" + itxbBreed + "');";
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มพันธุ์ " + itxbBreed + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlBreed);
                    LoadBreed();
                    clearTxb();
                }
            }
            
        }

        private void bt_AddType_Click(object sender, EventArgs e)
        {
            AddType();
        }

        private void AddType()
        {
            string itxbType = txb_TypeName.Text.Trim();
            string isqlType = "INSERT INTO `petshop`.`tb_pettype` (`PetType_ID`, `PetType_Des`) VALUES (NULL, '" + itxbType + "')";
            DialogResult iConfirmResult = MessageBox.Show("เพิ่มประเภท " + itxbType + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlType);
                LoadType();
                clearTxb();
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
            string itxbBreedID = txb_BreedID.Text.Trim();
            string itxbBreed = txb_BreedName.Text.Trim();
            string icbType = cb_Type.SelectedValue.ToString();

            string isqlBreed = "UPDATE `tb_petbreed` SET `PetType_ID` = '" + icbType + "', `PetBreed_Des` = '" + itxbBreed + "' WHERE `tb_petbreed`.`PetBreed_ID` = " + itxbBreedID + "";
            DialogResult iConfirmResult = MessageBox.Show("แก้ไขพันธุ์ " + itxbBreed + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlBreed);
                LoadBreed();
                clearTxb();
            }
        }

        private void bt_EditType_Click(object sender, EventArgs e)
        {
            EditType();
        }

        private void EditType()
        {
            string itxbTypeID = txb_TypeID.Text.Trim();
            string itxbType = txb_TypeName.Text.Trim();
            string isqlType = "UPDATE `petshop`.`tb_pettype` SET `PetType_Des` = '" + itxbType + "' WHERE `tb_pettype`.`PetType_ID` = " + itxbTypeID + "";
            DialogResult iConfirmResult = MessageBox.Show("แก้ไขประเภท " + itxbType + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
            if (iConfirmResult == DialogResult.Yes)
            {
                iConnect.Insert(isqlType);
                LoadType();
                clearTxb();
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
                if ((txb_BreedID.Text == "") && (txb_BreedID.Text == null))
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
                if((txb_TypeID.Text !=null)&&(txb_TypeID.Text !=""))
                {
                    bt_EditType.Select();
                }
                else
                {
                    bt_AddType.Select();
                  
                }
            } 
            
        }
    }
}
