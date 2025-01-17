﻿using System;
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
    public partial class FrmHealRecord : Form
    {
        DataTable idtmedicine, idtService;
        private MySQLDBConnect iConnect;

        public FrmHealRecord()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_LoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FrmMM21_Load(object sender, EventArgs e)
        {
            loadCompany(); //รหัสสาขา ปี
            loadEmployee(); //ข้อมูลรายชื่อพนักงาน
            LoadData();
        }

        private void CheckBill()
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            if ((ilbHealRecordID != null) && (ilbHealRecordID != ""))
            {
                tabControlServiceMedi.Enabled = true;
                bt_PrintBill.Enabled = true;
                bt_PrintDate.Enabled = true;
                txb_HealRecordDC.Enabled = true;
            }
            else
            {
                tabControlServiceMedi.Enabled = false;
                bt_PrintBill.Enabled = false;
                bt_PrintDate.Enabled = false;
                txb_HealRecordDC.Enabled = false;
            }
            DataTable idtBillCheck; //CheckBill
            string isqlBillCheck = "SELECT * FROM petshop.tb_bill where Refer_ID = '" + ilbHealRecordID + "'";
            idtBillCheck = iConnect.SelectByCommand(isqlBillCheck);
            if (idtBillCheck.Rows.Count == 0)
            {
                bt_RecordHeal.Enabled = true;
                bt_BuyService.Enabled = true;
                bt_BuyMedi.Enabled = true;
                bt_refService.Enabled = true;
                bt_refMedi.Enabled = true;
            }
            else
            {
                bt_RecordHeal.Enabled = false;
                bt_BuyService.Enabled = false;
                bt_BuyMedi.Enabled = false;
                bt_refService.Enabled = false;
                bt_refMedi.Enabled = false;
            }
        }
        private void LoadData()
        {
            loadMedi(); // รายการยาต่างๆ
            loadService(); //รายการให้บริการต่างๆ
            loadHealRecord();// บันทึกการรักษา --Master--
            loadServiceRecord(); //Service บันทึกบริการ --Detail--
            loadMediRecord(); //Medi บันทึกยา --Detail--
            loadPetProfiles(); // ชื่อเจ้าของและสัตว์
            Calcuator();
            CheckBill();
        }
        private void loadCompany()// โหลดข้อมูลองค์กร
        {
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM `tb_company`";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            lbYear.Text = DateTime.Now.ToString("yy");
            lbCompanyID.Text = "99";
            if (idtCompany.Rows.Count > 0)
            {
                lbCompanyID.Text = idtCompany.Rows[0]["CoService"].ToString();
            }
        }

        private void loadMedi()
        {
            string isqlMedi = "Select tb_medicine.*,tb_unit.Unit_Name,concat(Medi_Sale,'-./',Unit_Name) as Price from tb_medicine,tb_Unit where tb_Unit.Unit_ID = tb_medicine.Unit_ID And tb_medicine.Medi_Unit_Amt > 0";
            idtmedicine = iConnect.SelectByCommand(isqlMedi);
            if ((idtmedicine != null) && (idtmedicine.Rows.Count > 0))
            {
                cb_Medi.DisplayMember = idtmedicine.Columns["Medi_Des"].ColumnName;
                cb_Medi.ValueMember = idtmedicine.Columns["Medi_ID"].ColumnName;
                cb_Medi.DataSource = idtmedicine;
            }
        }
        private void loadService() // โหลดข้อมูลบริการขึ้น Combo
        {
            string isqlService = "SELECT * FROM `tb_service`"; //โหลดข้อมูลบริการ ให้เลือกแบบ Combobox
            idtService = iConnect.SelectByCommand(isqlService);
            if (idtService != null)
            {
                if (idtService.Rows.Count > 0)
                {
                    cb_Service.DisplayMember = idtService.Columns["Service_Des"].ColumnName;
                    cb_Service.ValueMember = idtService.Columns["Service_ID"].ColumnName;
                    cb_Service.DataSource = idtService;
                }
             }
        }

        private void loadEmployee() //โหลดข้อมูลเจ้าหน้าที่
        {
            DataTable idtEmployee;
            string isqlEmployee = "SELECT * FROM `tb_employee` where Em_Status = 1"; //โหลดรายชื่อ เจ้าหน้าที่
            idtEmployee = iConnect.SelectByCommand(isqlEmployee);
            if ((idtEmployee != null) && (idtEmployee.Rows.Count > 0))
            {
                cb_Em.DisplayMember = idtEmployee.Columns["Em_Name"].ColumnName;
                cb_Em.ValueMember = idtEmployee.Columns["Em_ID"].ColumnName;
                cb_Em.DataSource = idtEmployee;
            }
        }
        private void loadHealRecord()
        {
            string ilbHealRecordid = lb_HealRecordID.Text.Trim();
            if ((ilbHealRecordid != "") && (ilbHealRecordid != null))
            {
                DataTable idtHealRecord;
                string isqlHealRecord = "SELECT * FROM tb_healrecord where HealRecord_ID = " + ilbHealRecordid + " ";
                idtHealRecord = iConnect.SelectByCommand(isqlHealRecord);
                if (idtHealRecord.Rows.Count > 0)
                {
                    txb_PetID.Text = idtHealRecord.Rows[0].Field<string>(1).ToString();
                    cb_Em.SelectedValue = idtHealRecord.Rows[0].Field<string>(2).ToString();
                    //////
                    txb_HealRecordSymptom.Text = idtHealRecord.Rows[0].Field<string>(3);
                    txb_HealRecordRemark.Text = idtHealRecord.Rows[0].Field<string>(4);

                    txb_Weight.Text = idtHealRecord.Rows[0].Field<decimal>(5).ToString();
                    txb_Temp.Text = idtHealRecord.Rows[0].Field<decimal>(6).ToString();
                    txb_HR.Text = idtHealRecord.Rows[0].Field<decimal>(7).ToString();
                    txb_RR.Text = idtHealRecord.Rows[0].Field<decimal>(8).ToString();
                    dTP_HealRecordDate.Value = Convert.ToDateTime(idtHealRecord.Rows[0].Field<DateTime>(9));

                    txb_HealRecordTotal.Text = idtHealRecord.Rows[0].Field<decimal>(10).ToString();
                    txb_HealRecordDC.Text = idtHealRecord.Rows[0].Field<decimal>(11).ToString();
                    txb_HealRecordNet.Text = idtHealRecord.Rows[0].Field<decimal>(12).ToString();
                }
            }
        }
        private void loadServiceRecord() //โหลดข้อมูลบริการ Detail 
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            DataTable idtSerivceRecord;
            string isqlServiceRecord = "SELECT tb_ServiceRecord.*,tb_Service.Service_Des FROM tb_service,tb_ServiceRecord WHERE (tb_ServiceRecord.HealRecord_ID = '" + ilbHealRecordID + "' AND tb_service.Service_ID = tb_ServiceRecord.Service_ID)";
            idtSerivceRecord = iConnect.SelectByCommand(isqlServiceRecord);
            //if ((idtSerivceRecord != null) && (idtSerivceRecord.Rows.Count > 0))
            // {
            dGV_Service.DataSource = idtSerivceRecord;
            dGV_Service.Refresh();

            DataTable idtSumService;
            string isqlSumService = "SELECT sum(Service_Amt) as ServiceAmt FROM tb_ServiceRecord WHERE tb_ServiceRecord.HealRecord_ID = '" + ilbHealRecordID + "' ";
            idtSumService = iConnect.SelectByCommand(isqlSumService);
            lb_ServiceAmt.DataBindings.Clear();
            Binding b = new Binding("Text", idtSumService, "ServiceAmt");
            lb_ServiceAmt.DataBindings.Add(b);
            // }
        }
        private void loadMediRecord() //โหลดข้อมูลยา Detail 
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            DataTable idtMediRecord;
            string isqlMediRecord = "SELECT tb_MediRecord.*,tb_medicine.Medi_Des  FROM tb_Medicine,tb_MediRecord WHERE (tb_MediRecord.HealRecord_ID = '" + ilbHealRecordID + "' AND tb_Medicine.Medi_ID = tb_MediRecord.Medi_ID)";
            idtMediRecord = iConnect.SelectByCommand(isqlMediRecord);
            // if ((idtMediRecord != null) && (idtMediRecord.Rows.Count > 0))
            //  {
            dGV_Medi.DataSource = idtMediRecord;
            dGV_Medi.Refresh();

            DataTable idtSumMedi;
            string isqlSumMedi = "SELECT sum(MediRecord_total) as MediAmt  FROM tb_MediRecord WHERE HealRecord_ID = '" + ilbHealRecordID + "' ";
            idtSumMedi = iConnect.SelectByCommand(isqlSumMedi);
            lb_MediAmt.DataBindings.Clear();
            Binding b = new Binding("Text", idtSumMedi, "MediAmt");
            lb_MediAmt.DataBindings.Add(b);
            // }
        }
        private void loadPetProfiles()// โหลดข้อมูลสมาชิก จากเลขรหัสสัตว์  Master
        {
            DataTable idtPetProfile;
            string itb_PetID = txb_PetID.Text.Trim();
            string isqlPetProfile = "SELECT * FROM petshop.`tb_petprofile` where Pet_ID ='" + itb_PetID + "'";  //โหลดข้อมูลสัตว์เจ้าของสัตว์ จากการค้นหารายชื่อ
            idtPetProfile = iConnect.SelectByCommand(isqlPetProfile);
            if ((idtPetProfile != null) && (idtPetProfile.Rows.Count > 0))
            {
                txb_PetName.Text = idtPetProfile.Rows[0].Field<string>(1);
                txb_OwnerName.Text = idtPetProfile.Rows[0].Field<string>(8);
            }
        }
        private void cb_Medi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindMedi();
        }
        private void cb_Medi_TextChanged(object sender, EventArgs e)
        {
            BindMedi();
        }
        private void BindMedi()
        {
            lb_Unit.DataBindings.Clear();
            Binding b = new Binding("Text", idtmedicine, "Price");
            lb_Unit.DataBindings.Add(b);
        }

        private void cb_Service_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindService();
        }
        private void cb_Service_TextChanged(object sender, EventArgs e)
        {
            BindService();
        }
        private void BindService() //โหลดราคาขึ้นบนป้าย
        {
            lb_Price.DataBindings.Clear();
            Binding b = new Binding("Text", idtService, "Service_Price");
            lb_Price.DataBindings.Add(b);
        }
        private void bt_NewProfile_Click(object sender, EventArgs e) // เปิดหน้าต่าง ค้นข้อมูลรหัสสัตว์
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD21))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD21 iFrmMM21 = new FrmRecorD21(ref txb_PetID);
            iFrmMM21.MdiParent = MainForm.ActiveForm;
            iFrmMM21.Show();
        }


        private void Bt_RecordHeal_Click(object sender, EventArgs e)
        {
            AddHealRecord();
        }

        private void AddHealRecord()
        {
            epCheck.Clear();
            Regex RegString = new Regex(@"^[\d+]|[\w+]|[ ]$");
            //Regex Regint = new Regex(@"^\d{1,3}$");
            Regex Regdecimal = new Regex(@"^((\d{1,8})|(\d{1,6}\.\d{1,2}))$");

            if ((txb_PetID.Text == null) || (txb_PetID.Text ==""))
            {
                epCheck.SetError(txb_PetID, "ไม่พบรหัสสัตว์");
            }
            else if(cb_Em.SelectedValue == null)
            {
                epCheck.SetError(cb_Em, "กรุณาเลือกเจ้าหน้าที่");
            }
            /*else if ((txb_HealRecordSymptom.Text == null) && (txb_HealRecordSymptom.Text == string.Empty)) 
            {
                epCheck.SetError(txb_HealRecordSymptom, "กรุณาระบุอาการ");
            }*/
            else if (!Regdecimal.IsMatch(txb_Temp.Text))
            {
                epCheck.SetError(txb_Temp, "กรุณาระบุอณุหภูมิสัตว์");
            }
            else if (!Regdecimal.IsMatch(txb_Weight.Text)) 
            {
                epCheck.SetError(txb_Weight, "กรุณาระบุน้ำหนักสัตว์");
            }

            else if (!Regdecimal.IsMatch(txb_HR.Text))
            {
                epCheck.SetError(txb_HR, "กรุณาระบุอัตราการเต้นหัวใจ");
            }
            else if (!Regdecimal.IsMatch(txb_RR.Text)) 
            {
                epCheck.SetError(txb_RR, "กรุณาระบุอัตราการหายใจ");
            }
            else
            {
                string ilbHealRecordID = lb_HealRecordID.Text.Trim();
                string itxbPetID = txb_PetID.Text.Trim();
                string icbEmID = cb_Em.SelectedValue.ToString();
                string itxbHealRecordSymptom = txb_HealRecordSymptom.Text.Trim();
                string itxbHealRecordRemark = txb_HealRecordRemark.Text.Trim();
                string itxbWeight = txb_Weight.Text.Trim();
                string itxbTemp = txb_Temp.Text.Trim();
                string itxbHR = txb_HR.Text.Trim();
                string itxbRR = txb_RR.Text.Trim();

                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                string idtpHealRecordDate = dTP_HealRecordDate.Value.ToString("yyyy-MM-dd");

                string ilbcompany = lbCompanyID.Text.ToString();
                string ilbyear = lbYear.Text.ToString();
                string itbHealTotal = txb_HealRecordTotal.Text.Trim();
                string itbHealDC = txb_HealRecordDC.Text.Trim();
                string itbHealNet = txb_HealRecordNet.Text.Trim();
                if ((lb_HealRecordID.Text == null) || (lb_HealRecordID.Text == ""))
                {
                    DialogResult iConfirmResult = MessageBox.Show("ต้องการบันทึกข้อมูลการรักษาใช่หรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlHealthRecord = "INSERT INTO `tb_healrecord` (`HealRecord_ID`, `Pet_ID`, `Em_ID`, `HealRecord_Symptom`, `HealRecord_Remark`, `HealRecord_Weight`, `HealRecord_Temp`,HealRecord_HR,HealRecord_RR, `HealRecord_Date`, `HealRecord_Total`, `HealRecord_DC`, `HealRecord_Net`) " +
                                                    "VALUES (CONCAT('" + ilbyear + ilbcompany + "', LPAD(  IFNULL( (SELECT SUBSTR(`healrecord_Id`, 5) FROM `tb_healrecord` AS `alias` WHERE SUBSTR(`healrecord_Id`, 1, 2) = ('" + ilbyear + "')  ORDER BY `healrecord_Id` DESC LIMIT 1 ) + 1, 1 ),  5, '0' )) " +
                                                    " ,'" + itxbPetID + "', '" + icbEmID + "', '" + itxbHealRecordSymptom + "', '" + itxbHealRecordRemark + "', '" + itxbWeight + "', '" + itxbTemp + "','" + itxbHR + "','" + itxbRR + "', '" + idtpHealRecordDate + "', '" + itbHealTotal + "', '" + itbHealDC + "','" + itbHealNet + "')";
                        iConnect.Insert(isqlHealthRecord);

                        DataTable idtHealRecordID;
                        string isqlHealRecordID = "SELECT healrecord_Id FROM `tb_healrecord` WHERE SUBSTR(`healrecord_Id`, 1, 2) = ('" + ilbyear + "')  ORDER BY `healrecord_Id` DESC LIMIT 1";
                        idtHealRecordID = iConnect.SelectByCommand(isqlHealRecordID);
                        lb_HealRecordID.Text = idtHealRecordID.Rows[0].Field<string>(0);
                        MessageBox.Show("สร้างเลขที่ทำการรักษาแล้ว");
                    }
                }
                else
                {
                    DataTable idtBillCheck; //BillCheck
                    string isqlBillCheck = "SELECT * FROM petshop.tb_bill where Refer_ID = '" + ilbHealRecordID + "'";
                    idtBillCheck = iConnect.SelectByCommand(isqlBillCheck);
                    if (idtBillCheck.Rows.Count == 0)
                    {
                        string isqlHealRecordUpdate = "UPDATE `tb_healrecord` SET `Em_ID`='" + icbEmID + "', `HealRecord_Symptom`='" + itxbHealRecordSymptom + "', `HealRecord_Remark`='" + itxbHealRecordRemark + "', `HealRecord_Weight`='" + itxbWeight + "', `HealRecord_Temp`='" + itxbTemp + "',HealRecord_HR='" + itxbHR + "',HealRecord_RR='" + itxbRR + "',HealRecord_Date = '" + idtpHealRecordDate + "', `HealRecord_Total`='" + itbHealTotal + "', `HealRecord_DC`='" + itbHealDC + "', `HealRecord_Net`='" + itbHealNet + "' WHERE `HealRecord_ID`='" + ilbHealRecordID + "'";
                        iConnect.Insert(isqlHealRecordUpdate);
                        MessageBox.Show("ทำการบันทึกข้อมูลแล้ว");
                    }
                }
            }
            loadHealRecord();
            loadServiceRecord();
            loadMediRecord();
        }
        private void bt_BuyService_Click(object sender, EventArgs e)
        {
            AddServiceRecord();
        }
        private void AddServiceRecord()
        {
            if ((cb_Service.SelectedValue != null) && (cb_Service.SelectedValue != ""))
            {
                string ilbHealRecordID = lb_HealRecordID.Text.Trim();
                string icbServiceID = cb_Service.SelectedValue.ToString();
                string icbService = cb_Service.Text.Trim();
                string ilbPrice = lb_Price.Text.Trim();

                if ((ilbHealRecordID != null) && (ilbHealRecordID != ""))
                {
                     DataTable idtBillCheck; //BillCheck
            string isqlBillCheck = "SELECT * FROM petshop.tb_bill where Refer_ID = '" + ilbHealRecordID + "'";
            idtBillCheck = iConnect.SelectByCommand(isqlBillCheck);
            if (idtBillCheck.Rows.Count == 0)
            {
                DataTable idtCheckServiceRecord;
                string isqlCheckServiceRecord = "SELECT * FROM tb_servicerecord where HealRecord_ID = '" + ilbHealRecordID + "' AND Service_ID ='" + icbServiceID + "'";
                idtCheckServiceRecord = iConnect.SelectByCommand(isqlCheckServiceRecord);


                if ((idtCheckServiceRecord != null) && (idtCheckServiceRecord.Rows.Count > 0))
                {
                    MessageBox.Show("ได้เพิ่ม " + icbService + " แล้ว");
                }
                else
                {
                    DialogResult iConfirmResult = MessageBox.Show("เพิ่ม " + icbService + " มั๊ย?", "กำลังเพิ่มข้อมูล..", MessageBoxButtons.YesNo);
                    if (iConfirmResult == DialogResult.Yes)
                    {
                        string isqlServiceRecord = "INSERT INTO `tb_servicerecord` (`HealRecord_ID`, `Service_ID`, `Service_Amt`) VALUES ('" + ilbHealRecordID + "', '" + icbServiceID + "', '" + ilbPrice + "')";
                        iConnect.Insert(isqlServiceRecord);
                    }
                }
            }
                  }
                else
                {
                    AddHealRecord();
                }
                loadHealRecord();
                loadServiceRecord();
                loadMediRecord();
            }
        }


        private void bt_BuyMedi_Click(object sender, EventArgs e)
        {
            Buy_Medi();
        }

        private void Buy_Medi()
        {

            string itxbMedi = cb_Medi.SelectedValue.ToString();
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();

            string inUDMediUnit = nUDMediUnit.Text.Trim();

            if ((ilbHealRecordID != null) && (ilbHealRecordID != ""))
            {
                DataTable idtBillCheck;
                string isqlBillCheck = "SELECT * FROM petshop.tb_bill where Refer_ID = '" + ilbHealRecordID + "'";
                idtBillCheck = iConnect.SelectByCommand(isqlBillCheck);
                if (idtBillCheck.Rows.Count == 0)
                {
                DataTable idtMediCheck;
                string isqlMediCheck = "SELECT * FROM tb_medicine where Medi_ID = '" + itxbMedi + "'";
                idtMediCheck = iConnect.SelectByCommand(isqlMediCheck);

                if ((idtMediCheck != null) && (idtMediCheck.Rows.Count > 0))
                {
                    decimal iUnit = Convert.ToDecimal(nUDMediUnit.Value);
                    decimal iPrice = idtMediCheck.Rows[0].Field<decimal>(4);
                    decimal iMediRecord_total = iPrice * iUnit;
                    string iMediName = idtMediCheck.Rows[0].Field<string>(1);
                    UInt32 iMediUnitAmt = idtMediCheck.Rows[0].Field<UInt32>(8);
                    UInt32 iMediUnitOrder = idtMediCheck.Rows[0].Field<UInt32>(9);
                    UInt64 iStock = idtMediCheck.Rows[0].Field<UInt64>(10);

                    int iResult = 0;
                    if (iStock == 0)
                    {
                        iResult = 1;
                    }
                    else
                    {
                        if ((iMediUnitAmt > iUnit) || (iMediUnitAmt == iUnit))
                        {
                            iResult = 1;
                            if ((iMediUnitAmt < iMediUnitOrder) || (iMediUnitAmt == iMediUnitOrder))
                            {
                                MessageBox.Show("สินค้า " + iMediName + " ใกล้หมด เหลือเพียง " + iMediUnitAmt + "");
                            }
                            string isqlreStock = "UPDATE `tb_medicine` SET `Medi_Unit_Amt`= Medi_Unit_Amt -" + iUnit + " WHERE `Medi_ID`='" + itxbMedi + "'";
                            iConnect.Insert(isqlreStock);
                        }
                        else
                        {
                            MessageBox.Show("สินค้า " + iMediName + " มีไม่เพียงพอ เหลือเพียง " + iMediUnitAmt + "");
                        }
                    }


                    if (iResult == 1)
                    {
                        DataTable idtMediRecordCheck;
                        string isqlMediRecordCheck = "SELECT * FROM tb_medirecord where HealRecord_ID = '" + ilbHealRecordID + "' AND Medi_ID = '" + itxbMedi + "'";
                        idtMediRecordCheck = iConnect.SelectByCommand(isqlMediRecordCheck);
                        if ((idtMediRecordCheck != null) && (idtMediRecordCheck.Rows.Count > 0))
                        {
                            string isqlMediRecordUpdate = "UPDATE `tb_medirecord` SET `MediSale_Unit`= MediSale_Unit+" + iUnit + " ,MediRecord_Total=MediRecord_Total+" + iMediRecord_total + " " +
                            "WHERE `HealRecord_ID`='" + ilbHealRecordID + "' and`Medi_ID`='" + itxbMedi + "'";
                            iConnect.Insert(isqlMediRecordUpdate);
                        }
                        else
                        {
                            string isqlMediRecord = "INSERT INTO `tb_medirecord` (`HealRecord_ID`, `Medi_ID`, `MediSale_Unit`, `Medi_sale`, `MediRecord_Total`) " +
                                "VALUES ('" + ilbHealRecordID + "', '" + itxbMedi + "', '" + inUDMediUnit + "', '" + iPrice + "', '" + iMediRecord_total + "')";
                            iConnect.Insert(isqlMediRecord);
                        }
                        nUDMediUnit.Text = "1";
                    }

                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูล รหัสยา");
                }
            }
            }
            else
            {
                AddHealRecord();
                Buy_Medi();
            }
            LoadData();
        }
        private void lb_HealRecordID_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void txb_PetID_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
     
        private void bt_Print_Click(object sender, EventArgs e)
        {
            AddHealRecord();
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmBillSerMe))
                {
                    form.Activate();
                    return;
                }
            }
            FrmBillSerMe iFrmBillSerMe = new FrmBillSerMe();
            iFrmBillSerMe.MdiParent = MainForm.ActiveForm;
            iFrmBillSerMe.txb_ReferID.Text = lb_HealRecordID.Text;
            iFrmBillSerMe.Show();  
            //iCloseHealRecord = "Print";
            //this.Close();
        }

        private void bt_PrintDate_Click(object sender, EventArgs e)
        {
            AddHealRecord();
            //iCloseHealRecord = "HealDate";
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD22))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD22 iFrmRecorD22 = new FrmRecorD22();
            iFrmRecorD22.MdiParent = MainForm.ActiveForm;
            iFrmRecorD22.lb_HealRecordID.Text = lb_HealRecordID.Text;
            iFrmRecorD22.lb_PetID.Text = txb_PetID.Text;
            iFrmRecorD22.Show(); 
            //this.Close();
                    //AddHealRecord();      
        }
        private void bt_refService_Click(object sender, EventArgs e)
        {
            string ilbHealRecordID = lb_HealRecordID.Text.Trim();
            string iServiceID = lb_ServiceID.Text.Trim();
             DataTable idtBillCheck;
            string isqlBillCheck = "SELECT * FROM petshop.tb_bill where Refer_ID = '" + ilbHealRecordID + "'";
            idtBillCheck = iConnect.SelectByCommand(isqlBillCheck);
            if (idtBillCheck.Rows.Count == 0)
            {
                
                DialogResult iConfirmResult = MessageBox.Show("ต้องการยกเลิกบริการ ?", "ยกเลิกบริการ..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlDelService = "DELETE FROM `tb_servicerecord` WHERE `HealRecord_ID`='" + ilbHealRecordID + "' and`Service_ID`='" + iServiceID + "'";
                    iConnect.Insert(isqlDelService);
                    lb_ServiceID.Text = "";
                }
                loadServiceRecord();
            }
        }
        private void bt_refMedi_Click(object sender, EventArgs e)
        {
                string ilbHealRecordID = lb_HealRecordID.Text.Trim();
                string iMediID = lb_MediID.Text.Trim();
                string iMediU = lb_MediU.Text.Trim();
                    DataTable idtCheckMedi;
                    string isqlCheckMedi = "SELECT * FROM tb_medicine where Medi_ID = '" + iMediID + "'";
                    idtCheckMedi = iConnect.SelectByCommand(isqlCheckMedi);
                    if (idtCheckMedi.Rows.Count > 0)
                    {
                         DataTable idtBillCheck; //CheckBill
                         string isqlBillCheck = "SELECT * FROM petshop.tb_bill where Refer_ID = '" + ilbHealRecordID + "'";
                         idtBillCheck = iConnect.SelectByCommand(isqlBillCheck);
                         if (idtBillCheck.Rows.Count == 0)
                          {
                        DialogResult iConfirmResult = MessageBox.Show("ต้องการยกเลิกรายการยา ?", "ยกเลิกรายการยา..", MessageBoxButtons.YesNo);
                        if (iConfirmResult == DialogResult.Yes)
                        {

                            UInt64 iStock = idtCheckMedi.Rows[0].Field<UInt64>(10);

                            int iResult = 0;
                            if (iStock == 0)
                            {
                                iResult = 1;
                            }
                            else
                            {
                                iResult = 1;
                                string isqlreStock = "UPDATE `tb_medicine` SET `Medi_Unit_Amt`= Medi_Unit_Amt +" + iMediU + " WHERE `Medi_ID`='" + iMediID + "'";
                                iConnect.Insert(isqlreStock);
                            }
                            if (iResult == 1)
                            {
                                string isqlDelServiceRecord = "DELETE FROM `tb_medirecord` WHERE `HealRecord_ID`='" + ilbHealRecordID + "' and`Medi_ID`='" + iMediID + "'";
                                iConnect.Insert(isqlDelServiceRecord);
                                lb_MediID.Text = null;
                                lb_MediU.Text = null;
                            }
                        }
                        }
                    }
                    loadMediRecord();
        }
        private void dGV_Service_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_Service.SelectedRows)
            {
                lb_ServiceID.Text = row.Cells["ccService_ID"].Value.ToString();
            }
        }
        private void dGV_Medi_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_Medi.SelectedRows)
            {
                lb_MediID.Text = row.Cells["ccMedi_ID"].Value.ToString();
                lb_MediU.Text = row.Cells["ccMediSale_Unit"].Value.ToString();
            }
        }

        private void lb_MediAmt_TextChanged(object sender, EventArgs e)
        {
            Calcuator();
        }

        private void lb_ServiceAmt_TextChanged(object sender, EventArgs e)
        {
            Calcuator();
        }

        private void Calcuator()
        {
            Regex Regint = new Regex(@"^\d{1,3}$");
            Regex Regdecimal = new Regex(@"^((\d{1,8})|(\d{1,6}\.\d{1,2}))$");
            decimal iMediAmt = 0;
            decimal iServiceAmt = 0;
            if (Regdecimal.IsMatch(lb_ServiceAmt.Text))
            {
                iServiceAmt = Convert.ToDecimal(lb_ServiceAmt.Text);
            }
            if (Regdecimal.IsMatch(lb_MediAmt.Text))
            {
                iMediAmt = Convert.ToDecimal(lb_MediAmt.Text);
            }
            decimal iTotal = iMediAmt + iServiceAmt;
            txb_HealRecordTotal.Text = iTotal.ToString();


            decimal iDC = 0;
            decimal iNet = 0;
            if (Regdecimal.IsMatch(txb_HealRecordTotal.Text))
            {
                iTotal = Convert.ToDecimal(txb_HealRecordTotal.Text);
            }
            if (Regdecimal.IsMatch(txb_HealRecordDC.Text))
            {
                iDC = Convert.ToDecimal(txb_HealRecordDC.Text);
            }
            if (Regdecimal.IsMatch(txb_HealRecordNet.Text))
            {
                iNet = Convert.ToDecimal(txb_HealRecordNet.Text);
            }
            iNet = iTotal - iDC;
            txb_HealRecordNet.Text = iNet.ToString();

        }

        private void txb_DC_TextChanged(object sender, EventArgs e)
        {
            Calcuator();
        }

        private void txb_Temp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_Weight.Focus();
            }
        }

        private void txb_Weight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_HR.Focus();
            }
        }

        private void txb_RR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_RecordHeal.Select();
            }
        }

        private void txb_HR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_RR.Focus();
            }
        }

        private void FrmNN21_FormClosing(object sender, FormClosingEventArgs e)
        {
             if((lb_HealRecordID.Text !=null)&&(lb_HealRecordID.Text != string.Empty)){
              AddHealRecord();
              }

             /*
              //   DialogResult iConfirmResult = MessageBox.Show("**หากปิดหน้าต่างคุณจะไม่สามารถกลับมาแก้ไขบันทึกการรักษาได้", "กำลังปิดหน้าต่างนี้", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (iConfirmResult == DialogResult.No)
                 {
                     e.Cancel = true;
                 }
                 else if (iConfirmResult == DialogResult.Yes)
                 {
                     AddHealRecord();
                     if (iCloseHealRecord == "HealDate")
                     {
                         foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                         {
                             if (form.GetType() == typeof(FrmRecorD22))
                             {
                                 form.Activate();
                                 return;
                             }
                         }
                         FrmRecorD22 iFrmRecorD22 = new FrmRecorD22();
                         iFrmRecorD22.MdiParent = MainForm.ActiveForm;
                         iFrmRecorD22.lb_HealRecordID.Text = lb_HealRecordID.Text;
                         iFrmRecorD22.lb_PetID.Text = txb_PetID.Text;
                         iFrmRecorD22.Show(); 
                     }
                     else if (iCloseHealRecord == "Print") 
                     {
                         foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                         {
                             if (form.GetType() == typeof(FrmNRePort31))
                             {
                                 form.Activate();
                                 return;
                             }
                         }
                         FrmNRePort31 iFrmMM341 = new FrmNRePort31();
                         iFrmMM341.MdiParent = MainForm.ActiveForm;
                         iFrmMM341.txb_ReferID.Text = lb_HealRecordID.Text;
                         iFrmMM341.Show();  
                     }
                    
                }
            }
            iCloseHealRecord = null;*/
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }  
    }
}