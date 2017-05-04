using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.IO;
using MySql.Data.MySqlClient;
using System.Net;

namespace HackGame
{
    public partial class CodingTool2017 : Form
    {
        public CodingTool2017()
        {
            InitializeComponent();
        }
        #region main
            DatabaseHandler dbCon = DatabaseHandler.Instance();

            private DateTime calculateTime()
            {
                int minutes = 0;
                DateTime time = DateTime.Now;
                for (int i = 0; i < featureList.Items.Count; i++)
                {
                    if (featureList.GetItemChecked(i))
                    {
                        int devider = featureList.Items[i].ToString().IndexOf('|');
                        string impact = featureList.Items[i].ToString().Substring(devider + 1);
                        int placeholder = Convert.ToInt32(impact);
                        minutes += placeholder;
                    }
                }
                time = time.AddMinutes(minutes);

                return time;
            }

            private int calculatePrice()
            {
                int price = 0;
                for (int i = 0; i < featureList.Items.Count; i++)
                {
                    if (featureList.GetItemChecked(i))
                    {
                        int devider = featureList.Items[i].ToString().IndexOf('|');
                        string price_str = featureList.Items[i].ToString().Substring(devider + 1);
                        int placeholder = Convert.ToInt32(price_str);
                        price += (placeholder * 2);
                    }
                }
                return price;
            }

            private void CodingTool2017_Load(object sender, EventArgs e)
            {
                try
                {
                    if (dbCon.IsConnect())
                    {
                        DataTable aliases = dbCon.Select("SELECT name FROM tbl_companies WHERE (ceo='" + username1.Text + "')", "aliases");
                        madeByBox.Items.Add(username1.Text);
                        for (int i = 0; i < aliases.Rows.Count; i++)
                        {
                            DataRow alias = aliases.Rows[i];
                            madeByBox.Items.Add(alias["name"].ToString());
                        }
                        DataTable categories = dbCon.Select("SELECT name FROM tbl_categories", "categories");
                        for (int i = 0; i < categories.Rows.Count; i++)
                        {
                            DataRow categorie = categories.Rows[i];
                            categorieComboBox.Items.Add(categorie["name"].ToString());
                        }
                        categorieComboBox.Text = categorieComboBox.Items[0].ToString();
                    madeByBox.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    statusWindow stats = new statusWindow();
                    stats.Show();
                    DialogResult result = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                    {
                        dbCon.DatabaseName = "jtechgame_hack";
                        dbCon.ResetConn();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
                showFeatures();
            }

            private void showFeatures()
            {
                try
                {
                    if (dbCon.IsConnect())
                    {
                        featureList.Items.Clear();
                        DataTable features = dbCon.Select("SELECT * FROM tbl_features WHERE (categorie='" + categorieComboBox.SelectedItem.ToString() + "')", "features");
                        for (int i = 0; i < features.Rows.Count; i++)
                        {
                            DataRow feature = features.Rows[i];
                            if (feature["default"].ToString() == "True")
                            {
                                featureList.Items.Add(feature["name"] + " |" + feature["impact"], true);
                            }
                            else
                            {
                                featureList.Items.Add(feature["name"] + " |" + feature["impact"], false);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    statusWindow stats = new statusWindow();
                    stats.Show();
                    DialogResult result = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                    {
                        dbCon.DatabaseName = "jtechgame_hack";
                        dbCon.ResetConn();
                        showFeatures();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
            }

            private void priceUpdater_Tick(object sender, EventArgs e)
            {
                priceBox.Text = calculatePrice().ToString();
            }

        #endregion
        private void Publish_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    double money;
                    DataTable userMoney = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + madeByBox.SelectedItem.ToString() + "')", "userMoney");
                    if (userMoney.Rows.Count == 0)
                    {
                        DataTable compMoney = dbCon.Select("SELECT * FROM tbl_companies WHERE (name='" + madeByBox.SelectedItem.ToString() + "')", "compMoney");
                        money = Convert.ToDouble(compMoney.Rows[0]["money"].ToString());
                        
                    }
                    else
                    {
                        money = Convert.ToDouble(userMoney.Rows[0]["money"].ToString());
                        money = money / 100;
                    }

                    double price = Convert.ToDouble(priceBox.Text);
                    if (money < (price / 2))
                    {
                        MessageBox.Show("You dont have enough money");
                    }
                    else
                    {
                        
                        if (!codeBox.Text.ToLower().Contains("socket"))
                        {
                            string sql = "SELECT * FROM tbl_programs WHERE name=@name";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@name", nameBox.Text);
                            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                            {

                            }
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                MessageBox.Show("This name is already taken");
                                while (reader.Read())
                                {

                                }
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                sql = "INSERT INTO tbl_programs (name, price, made_by, categorie, created_at, available_since) VALUES (@name, @price, @madeBy, @categorie, NOW(), @availableSince)";
                                MySqlCommand cmd2 = new MySqlCommand(sql, dbCon.Connection);
                                cmd2.Parameters.AddWithValue("@name", nameBox.Text);
                                cmd2.Parameters.AddWithValue("@price", priceBox.Text);
                                cmd2.Parameters.AddWithValue("@madeBy", madeByBox.Text);
                                cmd2.Parameters.AddWithValue("@categorie", categorieComboBox.Text);
                                DateTime calculation = calculateTime();
                                cmd2.Parameters.AddWithValue("@availableSince", calculation);
                                cmd2.Prepare();
                                MySqlDataReader reader2 = cmd2.ExecuteReader();
                                while (reader2.Read())
                                {

                                }
                                money = money - (price / 2);
                                reader2.Close();
                                if (userMoney.Rows.Count == 0)
                                {
                                    string sql3 = "UPDATE tbl_companies SET (money=@money) WHERE (name=@name)";
                                    MySqlCommand cmd3 = new MySqlCommand(sql3, dbCon.Connection);
                                    cmd3.Parameters.AddWithValue("@name", madeByBox.Text);
                                    cmd3.Parameters.AddWithValue("@money", money);
                                    cmd3.Prepare();
                                    MySqlDataReader reader3 = cmd2.ExecuteReader();
                                    while (reader2.Read())
                                    {

                                    }
                                    reader2.Close();
                                }
                                else
                                {
                                    string sql3 = "UPDATE tbl_users SET (money=@money) WHERE (username=@name)";
                                    MySqlCommand cmd3 = new MySqlCommand(sql3, dbCon.Connection);
                                    cmd3.Parameters.AddWithValue("@name", madeByBox.Text);
                                    cmd3.Parameters.AddWithValue("@money", money);
                                    cmd3.Prepare();
                                    MySqlDataReader reader3 = cmd2.ExecuteReader();
                                    while (reader2.Read())
                                    {

                                    }
                                    reader2.Close();
                                }
                            }
                            reader.Close();
                            string dir = Directory.GetCurrentDirectory();
                            if (!Directory.Exists(@"Codes"))
                            {
                                Directory.CreateDirectory(@"Codes");
                            }
                            using (StreamWriter writer = new StreamWriter(@"Codes\" + nameBox.Text + ".cs"))
                            {

                                writer.WriteLine(codeBox.Text);
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                                startInfo.FileName = "cmd.exe";
                                if (Directory.Exists(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319"))
                                    startInfo.Arguments = @"/k cd Codes\ && C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe " + nameBox.Text + ".cs && EXIT";
                                else if (Directory.Exists(@"C:\Windows\Microsoft.NET\Framework\v3.5"))
                                    startInfo.Arguments = @"/k cd Codes\ && C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe " + nameBox.Text + ".cs && EXIT";
                                else if (Directory.Exists(@"C:\Windows\Microsoft.NET\Framework\v2.0.50727"))
                                    startInfo.Arguments = @"/k cd Codes\ && C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe " + nameBox.Text + ".cs && EXIT";
                                process.StartInfo = startInfo;
                                process.Start();
                            }
                            WebClient client = new WebClient();
                            client.UploadFile("http://jtechgame.alwaysdata.net/download/item1/upload/upload/hidden/unifiedloading.php", "POST", dir + @"\Codes\" + nameBox.Text + ".exe");
                        }
                        else
                        {
                            MessageBox.Show("ERROR: You are using a server in your code this is FORBIDDEN!", "ERROR 405");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                statusWindow stats = new statusWindow();
                stats.Show();
                DialogResult result = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {

                    dbCon.DatabaseName = "jtechgame_hack";
                    dbCon.ResetConn();
                    Publish_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }
        }

        

        private void categorieComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showFeatures();
        }

        private void featureList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            priceBox.Text = calculatePrice().ToString();
        }

        
    }
}
