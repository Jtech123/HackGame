using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;

namespace HackGame
{
    class DatabaseHandler
    {
        private string GetConfig()
        {
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString("http://jtechgame.alwaysdata.net/download/item1/upload/upload/hidden/configuration.html");
            string conn = htmlCode.Substring(105, 111);
            return conn;
        }

        private DatabaseHandler()
        {

        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DatabaseHandler _instance = null;
        public static DatabaseHandler Instance()
        {
            if (_instance == null)
                _instance = new DatabaseHandler();
            return _instance;
        }

        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    result = false;
                string connstring = string.Format("Server=mysql-jtechgame.alwaysdata.net; database={0}; UID=jtechgame_helper; password=wvw8buLnmmEVEq7y", databaseName);
                connection = new MySqlConnection(GetConfig());
                connection.Open();
                result = true;
            }

            return result;
        }

        public void ResetConn()
        {
            try
            {
                if (Connection != null)
                {
                    string connstring = string.Format("Server=mysql-jtechgame.alwaysdata.net; database={0}; UID=jtechgame_helper; password=wvw8buLnmmEVEq7y", databaseName);
                    connection = new MySqlConnection(connstring);
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    this.DatabaseName = "jtechgame_hack";
                    this.ResetConn();
                }
                else if (result == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }
        }

        public void Close()
        {
            connection.Close();
        }
        public DataTable Select(string query, string name)
        {
            

            if (this.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable(name);
                returnVal.Fill(dt);
                return dt;
            }
            else
            {
                this.Close();
                DataTable dt = new DataTable(name);
                return dt;
            }
        }
    }
    
}
