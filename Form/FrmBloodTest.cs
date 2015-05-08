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
    public partial class FrmBloodTest : Form
    {
        private MySQLDBConnect iConnect;
        public FrmBloodTest()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }
        
        private void bt_BloodTest_Click(object sender, EventArgs e)
        {
            AddEditBloodTest();
        }

        private void AddEditBloodTest()
        {
            string ilbBloodTestID = lb_BloodTestID.Text.Trim();

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            string idtpBlootTestDate = dTP_BloodTestDate.Value.ToString("yyyy-MM-dd");

            string icbEmID = cb_Em.SelectedValue.ToString();
            string ilbPetID = lb_PetID.Text.Trim();
            /////////////////////////////////////////////
            Regex Regdecimal = new Regex(@"^((\d{1,8})|(\d{1,6}\.\d{1,2}))$");

            if (!Regdecimal.IsMatch(txb_HGB.Text))
            {
                txb_HGB.Text = "0.00";
            }
            string itxbHGB = txb_HGB.Text.Trim();
            ///////////////////
            if (!Regdecimal.IsMatch(txb_PCV.Text))
            {
                txb_PCV.Text = "0.00";
            }
            string itxbPCV = txb_PCV.Text.Trim();
            ///////////////////
            if (!Regdecimal.IsMatch(txb_RBC.Text))
            {
                txb_RBC.Text = "0.00";
            }
            string itxbRBC = txb_RBC.Text.Trim();
            /////////////////////
            if (!Regdecimal.IsMatch(txb_MCV.Text))
            {
                txb_MCV.Text = "0.00";
            }
            string itxbMCV = txb_MCV.Text.Trim();
            ///////////////////
            if (!Regdecimal.IsMatch(txb_MCHC.Text))
            {
                txb_MCHC.Text = "0.00";
            }
            string itxbMCHC = txb_MCHC.Text.Trim();

            //////////////////
            if (!Regdecimal.IsMatch(txb_WBC.Text))
            {
                txb_WBC.Text = "0.00";
            }
            string itxbWBC = txb_WBC.Text.Trim();
            /////////////////////
            if (!Regdecimal.IsMatch(txb_MYCYTE.Text))
            {
                txb_MYCYTE.Text = "0.00";
            }
            string itxbMYCYTE = txb_MYCYTE.Text.Trim();
            /////////////////////////
            if (!Regdecimal.IsMatch(txb_META.Text))
            {
                txb_META.Text = "0.00";
            }
            string itxbMETA = txb_META.Text.Trim();
            /////////////////
            if (!Regdecimal.IsMatch(txb_BAND.Text))
            {
                txb_BAND.Text = "0.00";
            }
            string itxbBand = txb_BAND.Text.Trim();
            ////////////////
            if (!Regdecimal.IsMatch(txb_SEGS.Text))
            {
                txb_SEGS.Text = "0.00";
            }
            string itxbSEGS = txb_SEGS.Text.Trim();

            ///////////////////////////////////////////
            if (!Regdecimal.IsMatch(txb_LYMPH.Text))
            {
                txb_LYMPH.Text = "0.00";
            }
            string itxbLYMPH = txb_LYMPH.Text.Trim();

            if (!Regdecimal.IsMatch(txb_Mono.Text))
            {
                txb_Mono.Text = "0.00";
            }
            string itxbMONO = txb_Mono.Text.Trim();

            if (!Regdecimal.IsMatch(txb_EOS.Text))
            {
                txb_EOS.Text = "0.00";
            }
            string itxbEOS = txb_EOS.Text.Trim();

            if (!Regdecimal.IsMatch(txb_BASO.Text))
            {
                txb_BASO.Text = "0.00";
            }
            string itxbBASO = txb_BASO.Text.Trim();

            if (!Regdecimal.IsMatch(txb_UNCLASS.Text))
            {
                txb_UNCLASS.Text = "0.00";
            }
            string itxbUNCLASS = txb_UNCLASS.Text.Trim();

            ///////////////////////////////////////////
            if (!Regdecimal.IsMatch(txb_NUCLRBC.Text))
            {
                txb_NUCLRBC.Text = "0.00";
            }
            string itxbNUCLRBC = txb_NUCLRBC.Text.Trim();

            if (!Regdecimal.IsMatch(txb_RETICS.Text))
            {
                txb_RETICS.Text = "0.00";
            }
            string itxbRETICS = txb_RETICS.Text.Trim();

            if (!Regdecimal.IsMatch(txb_PLATELETS.Text))
            {
                txb_PLATELETS.Text = "0.00";
            }
            string itxbPLATELETS = txb_PLATELETS.Text.Trim();

            if (!Regdecimal.IsMatch(txb_REFRACT.Text))
            {
                txb_REFRACT.Text = "0.00";
            }
            string itxbREFRACT = txb_REFRACT.Text.Trim();

            if (!Regdecimal.IsMatch(txb_Blmor.Text))
            {
                txb_Blmor.Text = "0.00";
            }
            string itxbBlmor = txb_Blmor.Text.Trim();
            ////////////////////////////////////////
            if (!Regdecimal.IsMatch(txb_BUN.Text))
            {
                txb_BUN.Text = "0.00";
            }
            string itxbBUN = txb_BUN.Text.Trim();

            if (!Regdecimal.IsMatch(txb_CREATINNIE.Text))
            {
                txb_CREATINNIE.Text = "0.00";
            }
            string itxbCREATINNIE = txb_CREATINNIE.Text.Trim();

            if (!Regdecimal.IsMatch(txb_GLUCOSE.Text))
            {
                txb_GLUCOSE.Text = "0.00";
            }
            string itxbGLUCOSE = txb_GLUCOSE.Text.Trim();

            if (!Regdecimal.IsMatch(txb_AMYLASE.Text))
            {
                txb_AMYLASE.Text = "0.00";
            }
            string itxbAMYLASE = txb_AMYLASE.Text.Trim();

            if (!Regdecimal.IsMatch(txb_ALT.Text))
            {
                txb_ALT.Text = "0.00";
            }
            string itxbALT = txb_ALT.Text.Trim();

            if (!Regdecimal.IsMatch(txb_AST.Text))
            {
                txb_AST.Text = "0.00";
            }
            string itxbAST = txb_AST.Text.Trim();

            if (!Regdecimal.IsMatch(txb_ALK.Text))
            {
                txb_ALK.Text = "0.00";
            }
            string itxbALK = txb_ALK.Text.Trim();

            if (!Regdecimal.IsMatch(txb_CPK.Text))
            {
                txb_CPK.Text = "0.00";
            }
            string itxbCPK = txb_CPK.Text.Trim();

            if (!Regdecimal.IsMatch(txb_BILIRUBIN.Text))
            {
                txb_BILIRUBIN.Text = "0.00";
            }
            string itxbBILIRUBIN = txb_BILIRUBIN.Text.Trim();

            if (!Regdecimal.IsMatch(txb_DIRECT.Text))
            {
                txb_DIRECT.Text = "0.00";
            }
            string itxbDIRECT = txb_DIRECT.Text.Trim();

            if (!Regdecimal.IsMatch(txb_INDIRECT.Text))
            {
                txb_INDIRECT.Text = "0.00";
            }
            string itxbINDIRECT = txb_INDIRECT.Text.Trim();

            if (!Regdecimal.IsMatch(txb_CHOLESTEROL.Text))
            {
                txb_CHOLESTEROL.Text = "0.00";
            }
            string itxbCHOLESTEROL = txb_CHOLESTEROL.Text.Trim();

            if (!Regdecimal.IsMatch(txb_TRIGLYCERIDE.Text))
            {
                txb_TRIGLYCERIDE.Text = "0.00";
            }
            string itxbTRIGLYCERIDE = txb_TRIGLYCERIDE.Text.Trim();

            if (!Regdecimal.IsMatch(txb_BIURET.Text))
            {
                txb_BIURET.Text = "0.00";
            }
            string itxbBIURET = txb_BIURET.Text.Trim();

            if (!Regdecimal.IsMatch(txb_ALBUMIN.Text))
            {
                txb_ALBUMIN.Text = "0.00";
            }
            string itxbALBUMIN = txb_ALBUMIN.Text.Trim();

            if (!Regdecimal.IsMatch(txb_GLOBULIN.Text))
            {
                txb_GLOBULIN.Text = "0.00";
            }
            string itxbGLOBULIN = txb_GLOBULIN.Text.Trim();
            ////////////////////////////////////////////

            if (!Regdecimal.IsMatch(txb_CALCIUM.Text))
            {
                txb_CALCIUM.Text = "0.00";
            }
            string itxbCALCIUM = txb_CALCIUM.Text.Trim();

            if (!Regdecimal.IsMatch(txb_PHOSPHORUS.Text))
            {
                txb_PHOSPHORUS.Text = "0.00";
            }
            string itxbPHOSPHORUS = txb_PHOSPHORUS.Text.Trim();

            if (!Regdecimal.IsMatch(txb_SODIUM.Text))
            {
                txb_SODIUM.Text = "0.00";
            }
            string itxbSODIUM = txb_SODIUM.Text.Trim();

            if (!Regdecimal.IsMatch(txb_POTASSIUM.Text))
            {
                txb_POTASSIUM.Text = "0.00";
            }
            string itxbPOTASSIUM = txb_POTASSIUM.Text.Trim();

            if (!Regdecimal.IsMatch(txb_CHLORIDE.Text))
            {
                txb_CHLORIDE.Text = "0.00";
            }
            string itxbCHLORIDE = txb_CHLORIDE.Text.Trim();

            if (!Regdecimal.IsMatch(txb_AMMONIA.Text))
            {
                txb_AMMONIA.Text = "0.00";
            }
            string itxbAMMONIA = txb_AMMONIA.Text.Trim();

            if (!Regdecimal.IsMatch(txb_OTHERS.Text))
            {
                txb_OTHERS.Text = "0.00";
            }
            string itxbOTHERS = txb_OTHERS.Text.Trim();
            ///////////////////////////////////////////
            string itxbRemark = txb_bloodtestRemark.Text.Trim();
            if ((ilbBloodTestID != string.Empty) && (ilbBloodTestID != null))
            {
                DialogResult iConfirmResult = MessageBox.Show("ต้องการแก้ไขข้อมูลผลเลือดหรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlBloodTestEdit = "UPDATE `petshop`.`tb_bloodtest` SET `Bloodtest_Date`='" + idtpBlootTestDate + "', `Em_ID`='" + icbEmID + "', `HGB`='" + itxbHGB + "', `PCV`='" + itxbPCV + "', `RBC`='" + itxbRBC + "', `MCV`='" + itxbMCV + "', `MCHC`='" + itxbMCHC + "', `WBC`='" + itxbWBC + "', `MYCYTE`='" + itxbMYCYTE + "', `META`='" + itxbMETA + "', `BAND`='" + itxbBand + "', `SEGS`='" + itxbSEGS + "', `LYMPH`='" + itxbLYMPH + "', `MONO`='" + itxbMONO + "', `EOS`='" + itxbEOS + "', `BASO`='" + itxbBASO + "', `UNCLASS`='" + itxbUNCLASS + "', `NUCLRBC`='" + itxbNUCLRBC + "', `RETICS`='" + itxbRETICS + "', `PLATELETS`='" + itxbPLATELETS + "', `REFRACT`='" + itxbREFRACT + "', `blmor`='" + itxbBlmor + "', `BUN`='" + itxbBUN + "',"
                    +" `CREATINNIE`='"+itxbCREATINNIE+"', `GLUCOSE`='"+itxbGLUCOSE+"', `AMYLASE`='"+itxbAMYLASE+"', `ALT`='"+itxbALT+"', `AST`='"+itxbAST+"', `ALK`='"+itxbALK+"', `CPK`='"+itxbCPK+"', `BILIRUBIN`='"+itxbBILIRUBIN+"', `DIRECT`='"+itxbDIRECT+"', `INDIRECT`='"+itxbINDIRECT+"', `CHOLESTEROL`='"+itxbCHOLESTEROL+"', `TRIGLYCERIDE`='"+itxbTRIGLYCERIDE+"', `BIURET`='"+itxbBIURET+"', `ALBUMIN`='"+itxbALBUMIN+"', `GLOBULIN`='"+itxbGLOBULIN+"', `CALCIUM`='"+itxbCALCIUM+"', `PHOSPHORUS`='"+itxbPHOSPHORUS+"', `SODIUM`='"+itxbSODIUM+"', `POTASSIUM`='"+itxbPOTASSIUM+"', `CHLORIDE`='"+itxbCHLORIDE+"', `AMMONIA`='"+itxbAMMONIA+"', `bloodtest_OTHERS`='"+itxbOTHERS+"', `bloodtest_remark`='"+itxbRemark+"' WHERE `Bloodtest_ID`='"+ilbBloodTestID+"'";
                    iConnect.Insert(isqlBloodTestEdit);
                    MessageBox.Show("ทำการข้อมูลแก้ไขแล้ว");
                }
            }
            else
            {
                DialogResult iConfirmResult = MessageBox.Show("ต้องการเพิ่มข้อมูลผลเลือดหรือไม่?", "บันทึกข้อมูล..", MessageBoxButtons.YesNo);
                if (iConfirmResult == DialogResult.Yes)
                {
                    string isqlBloodTestAdd = "INSERT INTO `petshop`.`tb_bloodtest` (`Bloodtest_Date`, `Em_ID`, `Pet_ID`, `HGB`, `PCV`, `RBC`, `MCV`, `MCHC`, `WBC`, `MYCYTE`, `META`, `BAND`, `SEGS`, `LYMPH`, `MONO`, `EOS`, `BASO`, `UNCLASS`, `NUCLRBC`, `RETICS`, `PLATELETS`, `REFRACT`, `blmor`, `BUN`, `CREATINNIE`, `GLUCOSE`, `AMYLASE`, `ALT`, `AST`, `ALK`, `CPK`, `BILIRUBIN`, `DIRECT`, `INDIRECT`, `CHOLESTEROL`, `TRIGLYCERIDE`, `BIURET`, `ALBUMIN`, `GLOBULIN`, `CALCIUM`, `PHOSPHORUS`, `SODIUM`, `POTASSIUM`, `CHLORIDE`, `AMMONIA`, `bloodtest_OTHERS`, `bloodtest_remark`) " +
                    "VALUES ('" + idtpBlootTestDate + "', '" + icbEmID + "', '" + ilbPetID + "', '" + itxbHGB + "', '" + itxbPCV + "', '" + itxbRBC + "', '" + itxbMCV + "', '" + itxbMCHC + "', '" + itxbWBC + "', '" + itxbMYCYTE + "', '" + itxbMETA + "', '" + itxbBand + "', '" + itxbSEGS + "', '" + itxbLYMPH + "', '" + itxbMONO + "', '" + itxbEOS + "', '" + itxbBASO + "', '" + itxbUNCLASS + "', '" + itxbNUCLRBC + "', '" + itxbRETICS + "', '" + itxbPLATELETS + "', '" + itxbREFRACT + "', '" + itxbBlmor + "', '" + itxbBUN + "', '" + itxbCREATINNIE + "', '" + itxbGLUCOSE + "', '" + itxbAMYLASE + "', '" + itxbAST + "', '" + itxbAST + "', '" + itxbALK + "', '" + itxbCPK + "', '" + itxbBILIRUBIN + "', '" + itxbDIRECT + "', '" + itxbINDIRECT + "', '" + itxbCHOLESTEROL + "', '" + itxbTRIGLYCERIDE + "', '" + itxbBIURET + "', '" + itxbALBUMIN + "', '" + itxbGLOBULIN + "', '" + itxbCALCIUM + "', '" + itxbPHOSPHORUS + "', '" + itxbSODIUM + "', '" + itxbPOTASSIUM + "', '" + itxbCHLORIDE + "', '" + itxbAMMONIA + "', '" + itxbOTHERS + "', '" + itxbRemark + "')";
                    iConnect.Insert(isqlBloodTestAdd);
                    MessageBox.Show("บันทึกข้อมูลแล้ว");
                    DataTable idtBloodTest;
                    string isqlBloodTest = "SELECT * FROM petshop.tb_bloodtest ORDER BY Bloodtest_ID DESC LIMIT 1";
                    idtBloodTest = iConnect.SelectByCommand(isqlBloodTest);
                    lb_BloodTestID.Text = idtBloodTest.Rows[0].Field<Int32>(0).ToString();
                }
                
            }
            
        }

        private void FrmNN22_Load(object sender, EventArgs e)
        {
            loadEm();
        }

        private void loadEm()
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


        private void loadPetProfile()
        {
            string ilbPetID = lb_PetID.Text.Trim();
            DataTable idtPetProfile;
            string isqlPetProfile = "SELECT * FROM petshop.tb_petprofile where Pet_ID = '" + ilbPetID + "'";
            idtPetProfile = iConnect.SelectByCommand(isqlPetProfile);
            lb_PetName.Text = idtPetProfile.Rows[0].Field<string>(1);
        }

        private void loadBloodTest()
        {
            string ilbBloodTestID = lb_BloodTestID.Text.Trim();
            DataTable idtBloodTest;
            string isqlBloodTest = "SELECT * FROM petshop.tb_bloodtest where Bloodtest_ID ='"+ilbBloodTestID+"'";
            idtBloodTest = iConnect.SelectByCommand(isqlBloodTest);
            if (idtBloodTest.Rows.Count > 0)
            {
                dTP_BloodTestDate.Value = Convert.ToDateTime(idtBloodTest.Rows[0].Field<DateTime>(1));
                cb_Em.SelectedValue = idtBloodTest.Rows[0].Field<string>(2);
                lb_PetID.Text = idtBloodTest.Rows[0].Field<string>(3);

                //////////////////////////////////////////////////////
                txb_HGB.Text = idtBloodTest.Rows[0].Field<decimal>(4).ToString();
                txb_PCV.Text = idtBloodTest.Rows[0].Field<decimal>(5).ToString();
                txb_RBC.Text = idtBloodTest.Rows[0].Field<decimal>(6).ToString();
                txb_MCV.Text = idtBloodTest.Rows[0].Field<decimal>(7).ToString();
                txb_MCHC.Text = idtBloodTest.Rows[0].Field<decimal>(8).ToString();

                txb_WBC.Text = idtBloodTest.Rows[0].Field<decimal>(9).ToString();
                txb_MYCYTE.Text = idtBloodTest.Rows[0].Field<decimal>(10).ToString();
                txb_META.Text = idtBloodTest.Rows[0].Field<decimal>(11).ToString();
                txb_BAND.Text = idtBloodTest.Rows[0].Field<decimal>(12).ToString();
                txb_SEGS.Text = idtBloodTest.Rows[0].Field<decimal>(13).ToString();

                txb_LYMPH.Text = idtBloodTest.Rows[0].Field<decimal>(14).ToString();
                txb_Mono.Text = idtBloodTest.Rows[0].Field<decimal>(15).ToString();
                txb_EOS.Text = idtBloodTest.Rows[0].Field<decimal>(16).ToString();
                txb_BASO.Text = idtBloodTest.Rows[0].Field<decimal>(17).ToString();
                txb_UNCLASS.Text = idtBloodTest.Rows[0].Field<decimal>(18).ToString();

                txb_NUCLRBC.Text = idtBloodTest.Rows[0].Field<decimal>(19).ToString();
                txb_RETICS.Text = idtBloodTest.Rows[0].Field<decimal>(20).ToString();
                txb_PLATELETS.Text = idtBloodTest.Rows[0].Field<decimal>(21).ToString();
                txb_REFRACT.Text = idtBloodTest.Rows[0].Field<decimal>(22).ToString();
                txb_Blmor.Text = idtBloodTest.Rows[0].Field<decimal>(23).ToString();
                ////////////////////////////////////////
                txb_BUN.Text = idtBloodTest.Rows[0].Field<decimal>(24).ToString();
                txb_CREATINNIE.Text = idtBloodTest.Rows[0].Field<decimal>(25).ToString();
                txb_GLUCOSE.Text = idtBloodTest.Rows[0].Field<decimal>(26).ToString();
                txb_AMYLASE.Text = idtBloodTest.Rows[0].Field<decimal>(27).ToString();
                txb_ALT.Text = idtBloodTest.Rows[0].Field<decimal>(28).ToString();

                txb_AST.Text = idtBloodTest.Rows[0].Field<decimal>(29).ToString();
                txb_ALK.Text = idtBloodTest.Rows[0].Field<decimal>(30).ToString();
                txb_CPK.Text = idtBloodTest.Rows[0].Field<decimal>(31).ToString();
                txb_BILIRUBIN.Text = idtBloodTest.Rows[0].Field<decimal>(32).ToString();
                txb_DIRECT.Text = idtBloodTest.Rows[0].Field<decimal>(33).ToString();

                txb_INDIRECT.Text = idtBloodTest.Rows[0].Field<decimal>(34).ToString();
                txb_CHOLESTEROL.Text = idtBloodTest.Rows[0].Field<decimal>(35).ToString();
                txb_TRIGLYCERIDE.Text = idtBloodTest.Rows[0].Field<decimal>(36).ToString();
                txb_BIURET.Text = idtBloodTest.Rows[0].Field<decimal>(37).ToString();
                txb_ALBUMIN.Text = idtBloodTest.Rows[0].Field<decimal>(38).ToString();

                txb_GLOBULIN.Text = idtBloodTest.Rows[0].Field<decimal>(39).ToString();
                ////////////////////////////////////////////
                txb_CALCIUM.Text = idtBloodTest.Rows[0].Field<decimal>(40).ToString();
                txb_PHOSPHORUS.Text = idtBloodTest.Rows[0].Field<decimal>(41).ToString();
                txb_SODIUM.Text = idtBloodTest.Rows[0].Field<decimal>(42).ToString();
                txb_POTASSIUM.Text = idtBloodTest.Rows[0].Field<decimal>(43).ToString();
                txb_CHLORIDE.Text = idtBloodTest.Rows[0].Field<decimal>(44).ToString();

                txb_AMMONIA.Text = idtBloodTest.Rows[0].Field<decimal>(45).ToString();
                txb_OTHERS.Text = idtBloodTest.Rows[0].Field<decimal>(46).ToString();
                ///////////////////////////////////////////
                txb_bloodtestRemark.Text = idtBloodTest.Rows[0].Field<string>(47).ToString();
            }
            
        }

        private void lb_BloodTestID_TextChanged(object sender, EventArgs e)
        {
            loadBloodTest();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txbClear();
        }
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void txbClear()
        {
            ClearAllText(this);
            lb_BloodTestID.Text = "";
           /* txb_HGB.Clear();
            txb_PCV.Clear();
            txb_RBC.Clear();
            txb_MCV.Clear();
            txb_MCHC.Clear();

            txb_WBC.Clear();
            txb_MYCYTE.Clear();
            txb_META.Clear();
            txb_BAND.Clear();
            txb_SEGS.Clear();

            txb_LYMPH.Clear();
            txb_Mono.Clear();
            txb_EOS.Clear();
            txb_BASO.Clear();
            txb_UNCLASS.Clear();

            txb_NUCLRBC.Clear();
            txb_RETICS.Clear();
            txb_PLATELETS.Clear();
            txb_REFRACT.Clear();
            txb_Blmor.Clear();
            ////////////////////////////////////////
            txb_BUN.Clear();
            txb_CREATINNIE.Clear();
            txb_GLUCOSE.Clear();
            txb_AMYLASE.Clear();
            txb_ALT.Clear();

            txb_AST.Clear();
            txb_ALK.Clear();
            txb_CPK.Clear();
            txb_BILIRUBIN.Clear();
            txb_DIRECT.Clear();

            txb_INDIRECT.Clear();
            txb_CHOLESTEROL.Clear();
            txb_TRIGLYCERIDE.Clear();
            txb_BIURET.Clear();
            txb_ALBUMIN.Clear();

            txb_GLOBULIN.Clear();
            ////////////////////////////////////////////
            txb_CALCIUM.Clear();
            txb_PHOSPHORUS.Clear();
            txb_SODIUM.Clear();
            txb_POTASSIUM.Clear();
            txb_CHLORIDE.Clear();

            txb_AMMONIA.Clear();
            txb_OTHERS.Clear();
            ///////////////////////////////////////////
            txb_bloodtestRemark.Clear(); */
        }

        private void lb_PetID_TextChanged(object sender, EventArgs e)
        {
            if ((lb_PetID.Text != null) && (lb_PetID.Text != string.Empty))
            {
                loadPetProfile();
            }
        }

        private void bt_PrintBloodtest_Click(object sender, EventArgs e)
        {
            if ((lb_BloodTestID.Text != null)&&(lb_BloodTestID.Text != string.Empty))
            {
                foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
                {
                    if (form.GetType() == typeof(FrmPreBloodTest))
                    {
                        form.Activate();
                        return;
                    }
                }
                FrmPreBloodTest iFrmPreBloodTest = new FrmPreBloodTest();
                iFrmPreBloodTest.MdiParent = MainForm.ActiveForm;
                iFrmPreBloodTest.lb_BloodTestID.Text = lb_BloodTestID.Text;
                iFrmPreBloodTest.Show();
            }
        }
    }
}
