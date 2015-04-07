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
            loadincome();
        }

        private void loadincome()
        {
            DataTable idtincome;
            string isqlEmployee = "SELECT * FROM petshop.tb_income;";
            idtincome = iConnect.SelectByCommand(isqlEmployee);
            if (idtincome.Rows.Count > 0)
            {
                cb_outlay.DisplayMember = idtincome.Columns["Em_Name"].ColumnName;
                cb_Em.ValueMember = idtincome.Columns["Em_ID"].ColumnName;
                cb_Em.DataSource = idtincome;
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
    }
}
