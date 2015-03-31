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
    public partial class FrmMM11 : Form
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public FrmMM11()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }
        private void FrmMM11_Load(object sender, EventArgs e)
        {
            loadData(); ///โหลดข้อมูลต่างๆเมื่อเริ่มเปิดหน้าต่างนี้
        }
        private void loadData()
        {
            LoadService();
            LoadMedi();
            LoadUnit();
        }
        /// 
        /// ส่วนโหลดข้อมูลขึ้นตารางต่างๆของโปรแกรม
        /// 
        private void LoadService() //ส่วนของดึงข้อมูลจาก mysql ตาราง Service มาแสดง แท๊บ บริการ
         {
        DataTable idtService;
        string isqlCommand = "SELECT * FROM `tb_service`";
        idtService= iConnect.SelectByCommand(isqlCommand);
        dGV_Service.DataSource = idtService;
        dGV_Service.Refresh();
        
        }

        private void LoadMedi()//ส่วนของดึงข้อมูลจาก mysql ตาราง Medi มาแสดง แท๊บ ยา
        {
            DataTable idtMedi;
            string isqlCommand = "SELECT tb_Medicine.*,tb_Unit.Unit_Name FROM tb_Medicine,tb_Unit where tb_Unit.Unit_ID = tb_medicine.Unit_ID";
            idtMedi = iConnect.SelectByCommand(isqlCommand);
            dGV_Medi.DataSource = idtMedi;
            dGV_Medi.Refresh();
            lb_Result.Text = idtMedi.Rows.Count.ToString();
        }
        
        private void LoadUnit()
        {
            DataTable idtUnit;
            string isqlcommand = "SELECT * FROM `tb_unit`";
            idtUnit = iConnect.SelectByCommand(isqlcommand);
            cb_MediUnit.DisplayMember = idtUnit.Columns["Unit_Name"].ColumnName;
            cb_MediUnit.ValueMember = idtUnit.Columns["Unit_ID"].ColumnName;
            cb_MediUnit.DataSource = idtUnit;
        }
        
        private void Bt_LoadService_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void Bt_LoadMedi_Click(object sender, EventArgs e)
        {
            loadData();
        }
        /// 
        /// ส่วนโหลดข้อมูลขึ้นตารางต่างๆของโปรแกรม  //จบ
        ///
        
        /// 
        /// ส่วนของ Service เพิ่ม แก้ไข 
        /// 
        
        private void Bt_AddService_Click(object sender, EventArgs e)
        {
            AddService();
        }
        //ทดสอบ
        //Regex RegID = new Regex("^[0-9]{}");
        private void AddService()
        {

            string itxbserviceID = txb_ServiceID.Text.Trim();
            string itxbService = txb_ServiceDetail.Text.Trim();
            string itxbServicePrice = txb_ServicePrice.Text.Trim();
          
            string itxbServiceDate = txb_ServiceDate.Text.Trim();
            string isqlAddService = "Insert into tb_service (Service_ID,Service_Des,Service_Price,Service_DuringDate) "+
                                    "Values (CONCAT('S',LPAD(IFNULL((SELECT SUBSTR(`Service_Id`, 2) FROM `tb_Service` as `alias` "+
                                    "Order By Service_ID DESC Limit 1)+1,1),12,'0')),'" + itxbService + "','" + itxbServicePrice + "','" + itxbServiceDate + "')";
            if ((itxbService != null) && (itxbService != ""))
            {
                DialogResult iConfirmResult = MessageBox.Show("เพิ่มบริการ " + itxbService + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlAddService);
                    LoadService();
                    ClearTxtService();
                }
                
            }
            else
            {
                epCheck.SetError(txb_ServiceDetail, "กรุณาใส่ชื่อบริการ");
            }
        }
        private void dGV_Service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Service.Rows[e.RowIndex];
                txb_ServiceID.Text = row.Cells["coService_ID"].Value.ToString();
                txb_ServiceDetail.Text = row.Cells["coService_Des"].Value.ToString();
                txb_ServicePrice.Text = row.Cells["coService_Price"].Value.ToString();
               
                txb_ServiceDate.Text = row.Cells["coService_DuringDate"].Value.ToString();
            }
        }

        private void bt_EditService_Click(object sender, EventArgs e)
        {
            string itxbserviceID = txb_ServiceID.Text.Trim();
            string itxbService = txb_ServiceDetail.Text.Trim();
            string itxbServicePrice = txb_ServicePrice.Text.Trim();
            
            string itxbServiceDate = txb_ServiceDate.Text.Trim();

            string isqlAddService = "UPDATE `tb_service` SET `Service_Des` = '" + itxbService + "', `Service_Price` = '" + itxbServicePrice + "', `Service_DuringDate` = '" + itxbServiceDate + "' WHERE `tb_service`.`Service_ID` = '" + itxbserviceID + "'";
            if ((itxbService != null) && (itxbService != ""))
            {
                DialogResult iConfirmResult = MessageBox.Show("แก้ไขบริการ " + itxbService + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    iConnect.Insert(isqlAddService);
                    LoadService();
                    ClearTxtService();
                }
            }
        }
        private void ClearTxtService()
        {
            txb_ServiceID.Clear();
            txb_ServiceDetail.Clear();
            txb_ServicePrice.Clear();
            
            txb_ServiceDate.Clear();
        }
        /// 
        /// ส่วนของ Medi เพิ่ม แก้ไข 
        /// 
        private void Bt_AddMedi_Click(object sender, EventArgs e)
        {
            AddMedi();
        }
        private void AddMedi()
        {
            string itxbMediID = txb_MediID.Text.Trim();
            string itxbMediName = txb_MediName.Text.Trim();
            string itxbMediDetail = txb_MediDetail.Text.Trim();
            string icbMediUnit = "";
            if (cb_MediUnit.SelectedValue != null)
            {
                icbMediUnit = cb_MediUnit.SelectedValue.ToString();
            }
            else
            {
                LoadUnit();
                icbMediUnit = cb_MediUnit.SelectedValue.ToString();
            }
           

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            string idtpProduct = dTP_Product.Value.ToString("yyyy-MM-dd");
            string idtpExpired = dTP_Expired.Value.ToString("yyyy-MM-dd");

            if ((txb_MediAmt.Text == "") || (txb_MediAmt.Text == null))
            {
                txb_MediAmt.Text = "0";
            }
            string itxbMediAmt = txb_MediAmt.Text.Trim();

            if ((txb_MediOrder.Text == "") || (txb_MediOrder.Text == null))
            {
                txb_MediOrder.Text = "0";
            }
            string itxbMediOrder = txb_MediOrder.Text.Trim();

            if((txb_MediPrice.Text =="")||(txb_MediPrice.Text ==null))
            {
                txb_MediPrice.Text = "0.00";
            }
            string itxbMediPrice = txb_MediPrice.Text.Trim();
            if ((txb_MediSale.Text == "")||(txb_MediSale.Text ==null))
            {
                txb_MediSale.Text = "0.00";
            }
            int iStock = 0;
            if(CheckBox_Stock.Checked == true){
                iStock = 1;
            }
            string itxbMediSale = txb_MediSale.Text.Trim();
            if ((itxbMediID != null) && (itxbMediID != "") && (itxbMediName != null) && (itxbMediName != ""))
                {
                        DialogResult iConfirmResult = MessageBox.Show("เพิ่ม " + itxbMediName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {
                            DataTable iCheckMedi;
                            string isqlCheckMedi = "SELECT * FROM tb_medicine where Medi_ID ='" + itxbMediID + "'";
                            iCheckMedi = iConnect.SelectByCommand(isqlCheckMedi);
                            if (iCheckMedi.Rows.Count > 0)
                            {
                                string iMedi = iCheckMedi.Rows[0].Field<string>(1);
                                MessageBox.Show("มีรหัส " + itxbMediID + " - " + iMedi + " อยู่ในระบบแล้ว", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string isqlAddMedi = "Insert into tb_medicine (Medi_ID,Medi_Des,Medi_Detall,Medi_Price,Medi_Sale,Unit_ID,Medi_Product,Medi_Expired,Medi_Unit_Amt,Medi_Unit_Order,Medi_Stock) "+
                                                    "Values ('" + itxbMediID + "','" + itxbMediName + "', '" + itxbMediDetail + "', '" + itxbMediPrice + "', '" + itxbMediSale + "', '" + icbMediUnit + "', '" + idtpProduct + "', '" + idtpExpired + "', '" + itxbMediAmt + "', '" + itxbMediOrder + "',b'" + iStock + "')";
                                iConnect.Insert(isqlAddMedi);
                                MessageBox.Show("ทำการเพิ่ม '" + itxbMediID + "' - '" + itxbMediName + " แล้ว");
                                ClearTxtMedi();
                                LoadMedi();
                            }
                        }
                }
                else if (txb_MediID.Text.Length > 16)
                {
                    epCheck.SetError(txb_MediID, "กรุณาใส่รหัสยาไม่เกิน 16 ตัว!!");
                }
                else
                {
                    epCheck.SetError(txb_MediID, "กรุณาใส่รหัสยาไม่เกิน 16 ตัว!!");
                    epCheck.SetError(txb_MediName,"กรุณาใส่ชื่อยา");
                }
        }

        private void ClearTxtMedi()
        {
            lb_Medi.Text = "";
            txb_MediID.Clear();
            txb_MediName.Clear();
            txb_MediDetail.Clear();
            txb_MediPrice.Clear();
            txb_MediSale.Clear();
            txb_MediAmt.Clear();
            txb_MediOrder.Clear();
        }
        private void dGV_Medi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGV_Medi.Rows[e.RowIndex];
                txb_MediID.Text = row.Cells["ccMedi_ID"].Value.ToString();
                lb_Medi.Text = row.Cells["ccMedi_ID"].Value.ToString();
                txb_MediName.Text = row.Cells["ccMedi_Des"].Value.ToString();
                txb_MediDetail.Text = row.Cells["ccMedi_Detall"].Value.ToString();
                txb_MediPrice.Text = row.Cells["ccMedi_Price"].Value.ToString();
                txb_MediSale.Text = row.Cells["ccMedi_Sale"].Value.ToString();

                //string iUnit = Convert.ToString(row.Cells["coUnit_ID"].Value);
                cb_MediUnit.SelectedValue = row.Cells["coUnit_ID"].Value;
                //cb_MediUnit.ValueMember = row.Cells["coUnit_ID"].Value.ToString();
                //cb_MediUnit.SelectedIndex = row.Cells["coUnit_ID"]
                txb_MediAmt.Text = row.Cells["ccMedi_Unit_Amt"].Value.ToString();
                //string dtpProduct = row.Cells["ccMedi_Product"].Value.ToString();
                //string dtpExpired = row.Cells["ccMedi_Expired"].Value.ToString();
                txb_MediOrder.Text = row.Cells["ccMedi_Unit_Order"].Value.ToString();
                int iStock = Convert.ToInt32(row.Cells["ccMedi_Stock"].Value); 
                if (iStock == 1)
                {
                    CheckBox_Stock.Checked = true;
                }
                else
                {
                    CheckBox_Stock.Checked = false;
                }
            }
        }

        private void bt_EditMedi_Click(object sender, EventArgs e)
        {
            string itxbMediID = txb_MediID.Text.Trim();
            string itxbMediName = txb_MediName.Text.Trim();
            string itxbMediDetail = txb_MediDetail.Text.Trim();
            string itxbMediPrice = txb_MediPrice.Text.Trim();
            string itxbMediSale = txb_MediSale.Text.Trim();
            string ilbMedi = lb_Medi.Text.Trim();
            // string itbMediUnit = cb_MediUnit.Text.Trim();
            string icbMediUnit = cb_MediUnit.SelectedValue.ToString();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            string idtpProduct = dTP_Product.Value.ToString("yyyy-MM-dd");
            string idtpExpired = dTP_Expired.Value.ToString("yyyy-MM-dd");

            string itxbMediAmt = txb_MediAmt.Text.Trim();
            string itxbMediOrder = txb_MediOrder.Text.Trim();

            int iStock = 0;
            if(CheckBox_Stock.Checked == true){
                iStock = 1;
            }
            //string isqlAddMedi = "Insert into tb_medicine (Medi_ID,Medi_Des,Medi_Detall,Medi_Price,Medi_Sale,Medi_Unit,Medi_Product,Medi_Expired,Medi_Unit_Amt,Medi_Unit_Order) Values ('" + itbMediID + "','" + itbMediName + "', '" + itbMediDetail + "', '" + itbMediPrice + "', '" + itbMediSale + "', '" + itbMediUnit + "', '" + idtpProduct + "', '" + idtpExpired + "', '" + itbMediAmt + "', '" + itbMediOrder + "')";
            DataTable iMediCheck;
            string isqlMedi = "SELECT * FROM petshop.tb_medicine where Medi_ID = '"+ilbMedi+"'";
            iMediCheck = iConnect.SelectByCommand(isqlMedi);

            if (iMediCheck.Rows.Count > 0)
            {
                if ((itxbMediID != null) && (itxbMediID != ""))
                {
                    DialogResult iConfirmResult = MessageBox.Show("แก้ไข " + itxbMediName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlAddMedi = "UPDATE `tb_medicine` SET Medi_ID = '" + itxbMediID + "',`Medi_Des` = '" + itxbMediName + "', `Medi_Detall` = '" + itxbMediDetail + "', `Medi_Price` = '" + itxbMediPrice + "', `Medi_Sale` = '" + itxbMediSale + "', `Unit_ID` = '" + icbMediUnit + "', `Medi_Product` = '" + idtpProduct + "', `Medi_Expired` = '" + idtpExpired + "', `Medi_Unit_Amt` = '" + itxbMediAmt + "', `Medi_Unit_Order` = '" + itxbMediOrder + "', Medi_Stock = b'" + iStock + "' WHERE `tb_medicine`.`Medi_ID` = '" + ilbMedi + "'";
                        iConnect.Insert(isqlAddMedi);
                        LoadMedi();
                        ClearTxtMedi();
                    }
                }            
            }
            
        }

        private void Bt_Unit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM13))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM13 iFrmMM13 = new FrmMM13();
            iFrmMM13.MdiParent = MainForm.ActiveForm;
            iFrmMM13.Show();
        }

        private void tb_MediID_Enter(object sender, EventArgs e)
        {
            dynamic TypeOfLanguage = new System.Globalization.CultureInfo("En");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }

        private void txb_ServiceDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if((txb_ServiceDetail.Text !=null)||(txb_ServiceDetail.Text !="")){
                    txb_ServicePrice.Focus();
                }
                }
        }

        private void txb_ServicePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_ServicePrice.Text != null) || (txb_ServicePrice.Text != ""))
                {
                    txb_ServiceDate.Focus();
                }
            }
        }

        private void txb_ServiceDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_ServiceID.Text == null)||(txb_ServiceID.Text ==""))
                {
                    bt_AddService.Select();
                }
                else
                {
                    bt_EditService.Select();
                }
                }
        }

        private void txb_MediID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_MediName.Focus();
            }
        }

        private void txb_MediName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_MediDetail.Focus();
            }
        }

        private void txb_MediDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_MediPrice.Focus();
            }
        }

        private void txb_MediPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_MediSale.Focus();
            }
        }

        private void txb_MediSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_MediUnit.Focus();
            }
        }

       

        private void txb_MediAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_MediOrder.Focus();
            }
        }

        private void txb_MediOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_MediID.Text == null) && (txb_MediID.Text == ""))
                {
                    bt_AddMedi.Select();

                }
                else
                {
                    bt_EditMedi.Select();
                }
                }
        }

        private void bt_SearchMedi_Click(object sender, EventArgs e)
        {
            string iSearchMedi = txb_SearchMedi.Text.Trim();
            if((iSearchMedi !=null)||(iSearchMedi !="")){
                DataTable idtMedicine;
                string isqlCommand = "SELECT * FROM `tb_Medicine` where Medi_ID like '%"+iSearchMedi+"%' OR Medi_Des like '%"+iSearchMedi+"%' OR Medi_ID like '%"+iSearchMedi+"%' ";
                idtMedicine = iConnect.SelectByCommand(isqlCommand);
                dGV_Medi.DataSource = idtMedicine;
                dGV_Medi.Refresh();
               lb_Result.Text =  idtMedicine.Rows.Count.ToString();
            }
            else
            {
                LoadMedi();
            }
        }

        private void bt_DelService_Click(object sender, EventArgs e)
        {
            string iServiceID = txb_ServiceID.Text.Trim();
            string iServiceName = txb_ServiceDetail.Text.Trim();
            if ((iServiceID != null) && (iServiceID != ""))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + iServiceName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        DataTable idtServiceRecordCheck;
                        string isqlServiceCheck = "SELECT tb_servicerecord.Service_ID FROM tb_servicerecord where Service_ID = '"+iServiceID+"'";
                        idtServiceRecordCheck = iConnect.SelectByCommand(isqlServiceCheck);
                        DataTable idtHealDateCheck;
                        string isqlHealDateCheck = "SELECT * FROM tb_healdate where Service_ID='"+iServiceID+"'";
                        idtHealDateCheck = iConnect.SelectByCommand(isqlHealDateCheck);
                        if ((idtServiceRecordCheck.Rows.Count == 0)&&(idtHealDateCheck.Rows.Count ==0))
                        {
                            string isqlDelService = "DELETE FROM `tb_service` WHERE `Service_ID`='"+iServiceID+"'";
                            iConnect.Insert(isqlDelService);
                            MessageBox.Show("ทำการลบบริการแล้ว");
                            ClearTxtService();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถลบได้");
                        }
                    }
                    LoadService();
            }





        }

        private void bt_DelMedi_Click(object sender, EventArgs e)
        {
            string iMediID = txb_MediID.Text.Trim();
            string iMediName = txb_MediName.Text.Trim();
            if ((iMediID != null) && (iMediID != ""))
            {
                DialogResult iConfirmResult = MessageBox.Show("ลบข้อมูล " + iMediName + " มั๊ย?", "Insert..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    DataTable idtMediRecordCheck;
                    string isqlServiceCheck = "SELECT tb_MediRecord.Medi_ID FROM tb_MediRecord where Medi_ID = '" + iMediID + "'";
                    idtMediRecordCheck = iConnect.SelectByCommand(isqlServiceCheck);
                    if (idtMediRecordCheck.Rows.Count == 0)
                    {
                        string isqlDelMedi = "DELETE FROM `tb_medicine` WHERE `Medi_ID`='" + iMediID + "'";
                        iConnect.Insert(isqlDelMedi);
                        MessageBox.Show("ทำการลบยาออกแล้ว");
                        ClearTxtMedi();
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบได้");
                    }
                }
                
                LoadMedi();
            }
        }
    }
}
