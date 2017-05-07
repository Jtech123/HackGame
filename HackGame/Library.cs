using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HackGame
{
    public partial class Library : Form
    {
        DatabaseHandler dbCon;

        public Library()
        {
            InitializeComponent();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            dbCon = DatabaseHandler.Instance();
            ShowDevelopedItems();
            ShowOwnedItems();
        }

        private void ShowOwnedItems()
        {
            ownedListView.Items.Clear();
            string dir = Directory.GetCurrentDirectory();
            if (!Directory.Exists("Codes"))
            {
                ListViewItem item = new ListViewItem();
                item.Text = "There are no items...";
                ownedListView.Items.Add(item);
            }
            else
            {
                string[] files = Directory.GetFiles(dir + @"\Codes");
                foreach (string file in files)
                {
                    if (file.EndsWith(".exe"))
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file);
                        ListViewItem item = new ListViewItem();
                        item.Text = fileName;
                        ownedListView.Items.Add(item);
                    }
                }
            }
        }

        private void ShowDevelopedItems()
        {
            devView.Items.Clear();
            try
            {
                if (dbCon.IsConnect())
                {
                    DataTable devProgramsU = dbCon.Select("SELECT * FROM tbl_programs WHERE (made_by='" + usernameLbl.Text + "')", "devPrograms");
                    for (int i = 0; i < devProgramsU.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = devProgramsU.Rows[i]["name"].ToString();
                        item.SubItems.Add(devProgramsU.Rows[i]["price"].ToString());
                        item.SubItems.Add(devProgramsU.Rows[i]["sold"].ToString());
                        devView.Items.Add(item);
                    }
                    DataTable companiesByP = dbCon.Select("SELECT * FROM tbl_companies WHERE (ceo='" + usernameLbl.Text + "')", "companysByplayer");
                    for (int j = 0; j < companiesByP.Rows.Count; j++)
                    {
                        DataRow company = companiesByP.Rows[j];
                        DataTable devProgramsComp = dbCon.Select("SELECT * FROM tbl_programs WHERE (made_by='" + company["name"].ToString() + "')", "devCompPrograms");
                        for (int k = 0; k < devProgramsComp.Rows.Count; k++)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = devProgramsComp.Rows[k]["name"].ToString();
                            item.SubItems.Add(devProgramsComp.Rows[k]["price"].ToString());
                            item.SubItems.Add(devProgramsComp.Rows[k]["sold"].ToString());
                            devView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDevelopedItems();
            ShowOwnedItems();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ownedListView_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < ownedListView.Items.Count; i++)
            {
                if (ownedListView.Items[i].Selected)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = @"/k cd Codes\ && " + ownedListView.Items[i].Text + ".exe && EXIT";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
        }

        private void ownedListView_Click(object sender, EventArgs e)
        {
            
        }
    }
}
