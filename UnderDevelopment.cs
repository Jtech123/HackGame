using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackGame
{
    public partial class UnderDevelopment : Form
    {
        public UnderDevelopment()
        {
            InitializeComponent();
        }

        #region main

            DatabaseHandler dbCon = DatabaseHandler.Instance();

            private void ShowItems()
            {
                releasingDisplay.Items.Clear();
                DataTable table = dbCon.Select("SELECT * FROM tbl_programs WHERE available_since > NOW()", "programs");
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
                    releasingDisplay.Items.Add(lstItem);
                }
            }

            private void UnderDevelopment_Load(object sender, EventArgs e)
            {
                ShowItems();
            }

        #endregion
        #region btn

            private void refreshBtn_Click(object sender, EventArgs e)
            {
                ShowItems();
            }

        #endregion
    }
}
