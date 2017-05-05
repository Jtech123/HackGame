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
                    lstItem.Text = dataRow["id"].ToString();
                    lstItem.SubItems.Add(dataRow["name"].ToString());
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
            for (int i = 0; i < StoreDisplay.Items.Count; i++)
            {
                if (this.StoreDisplay.Items[i].Selected)
                {
                    MessageBox.Show(StoreDisplay.Items[i].Text);
                }
            }
        }
    }
}
