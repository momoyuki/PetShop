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
        static string password = "1234";

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
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
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

            //Open connection
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
        //ทำการ Insert ข้อมูลลงในฐานข้อมูล Applicant ตาราง By SqlCommand
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
        
    }

}
