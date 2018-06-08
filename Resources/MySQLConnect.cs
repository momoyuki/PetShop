using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient; //Add MySql Library for MySql

namespace Petshop
{
    class MySQLDBConnect
    {
        private MySqlConnection connection;

        static string server = "localhost";
        static string database = "petshop";
        static string uid = "root";
        static string password = "";

        public static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";charset=utf8;Convert Zero Datetime=True;";
        
        //Constructor
        public MySQLDBConnect()
        {
            Initialize();
        }
        //Initialize values
        private void Initialize()
        {
          //  server = "127.0.0.1";
          //  database = "database_01";
          //  uid = "root";
          //  password = "1234";
          //  string connectionString ;
          //  connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }     
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        MessageBox.Show("ไม่สามารถเชื่อมต่อได้ กรุณาติดต่อผู้ดูแลระบบ");
                        break;
                    case 1044:
                        //MessageBox.Show("Invalid username/password, please try again");
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านสำหรับติดต่อฐานข้อมูลไม่ถูกต้อง");
                        break;
                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านสำหรับติดต่อฐานข้อมูลไม่ถูกต้อง");
                        break;
                    case 1049:
                        MessageBox.Show("กำลังทำการติดตั้งฐานข้อมูล");
                        //createDB();
                        break;
                }
                return false;
            }
        }

        internal void createDB()
        {
            string query = "";
            if (File.Exists("PetShopDB.sql"))
            {
                string conndb =  "SERVER=" + server + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";charset=utf8;Convert Zero Datetime=True";
                connection = new MySqlConnection(conndb);
                connection.Open();
                StreamReader streamReader = new StreamReader("PetShopDB.sql");
                query = streamReader.ReadToEnd();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("สร้างฐานข้อมูลแล้ว");
                //close connection
                this.CloseConnection();
                streamReader.Close();
            }
            
            
        }
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        internal DataTable SelectByCommand(string iSqlcommand)
        {
            // Set Select command
            string query = iSqlcommand;
            DataSet DS = new DataSet();  // using system.data
            try
            {
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                //get query results in dataset
                adapter.Fill(DS);
                //close Connection
                this.CloseConnection();
            }
            //return datatable with all records
            return DS.Tables[0];
            }
            catch (Exception ex)
            {
                return null;
            }
            //Open connection
            
        }
        //Delete statement
        internal void DeleteBySQL(string iSqlCommand)
        {
            string query = iSqlCommand;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        internal void Insert(string iSQLCommand) 
        {
            string query = iSQLCommand; 
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }

        internal void BackupDatabase(string path)
        {
            string Filepath = path;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(path);
                        conn.Close();
                    }

                }
            }
        }
    }

}
