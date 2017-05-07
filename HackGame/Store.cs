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
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace HackGame
{
    public partial class store : Form
    {
        public store()
        {
            InitializeComponent();
            ShowItems();
        }

        #region main

            DatabaseHandler dbCon = DatabaseHandler.Instance();

            private void Store_Load(object sender, EventArgs e)
            {
                dbCon.DatabaseName = "jtechgame_hack";
                if (dbCon.IsConnect())
                {
                    DateTime time = DateTime.Now;

                    string sql = "SELECT * FROM tbl_programs WHERE available_since<=@time";
                    MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Prepare();
                    int i = 0;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    reader.Close();


                }
                else
                {
                    MessageBox.Show("Connection failed");
                }
            }

            private void ShowItems()
            {
                StoreDisplay.Items.Clear();
                DataTable table = dbCon.Select("SELECT * FROM tbl_programs WHERE available_since < NOW()", "programs");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow dataRow = table.Rows[i];
                    ListViewItem lstItem = new ListViewItem((i + 1).ToString());
                    lstItem.Text = dataRow["name"].ToString();
                    lstItem.SubItems.Add(dataRow["price"].ToString());
                    lstItem.SubItems.Add(dataRow["categorie"].ToString());
                    lstItem.SubItems.Add(dataRow["made_by"].ToString());
                    lstItem.SubItems.Add(dataRow["sold"].ToString());
                    lstItem.SubItems.Add(dataRow["available_since"].ToString());
                    StoreDisplay.Items.Add(lstItem);
                    itemlist.Items.Add(dataRow["name"]);
                }
            }

        #endregion
        #region btn

            private void refreshBtn_Click(object sender, EventArgs e)
            {
                ShowItems();
            }

        #endregion

        private void StoreDisplay_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StoreDisplay.Items.Count; i++)
            {
                if (StoreDisplay.Items[i].Selected)
                {
                    DialogResult result = MessageBox.Show("Do you want to download " + StoreDisplay.Items[i].Text, "Confirm", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        string path = "http://jtechgame.alwaysdata.net/download/programs/";
                        path = path + StoreDisplay.Items[i].Text + ".exe";
                        WebClient client = new WebClient();
                        if (!Directory.Exists(@"Codes"))
                        {
                            Directory.CreateDirectory(@"Codes");
                        }
                        try
                        {
                            client.DownloadFile(path, @"Codes\" + StoreDisplay.Items[i].Text + ".exe");

                            MessageBox.Show("Downloaded " + StoreDisplay.Items[i].Text);
                        }
                        catch
                        {
                            MessageBox.Show("This program isn't on the server or there was a network error...");
                        }
                    }
                }
            }
        }
    }
}
