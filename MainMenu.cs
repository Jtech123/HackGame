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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region main

            DatabaseHandler dbCon;
            Timer t = new Timer();
            Timer newsCheck = new Timer();

            private void MainMenu_Load(object sender, EventArgs e)
            {
                t.Interval = 100;
                t.Tick += new EventHandler(this.t_Tick);
                t.Start();
                newsCheck.Interval = 10000;
                newsCheck.Tick += new EventHandler(this.newsCheck_Tick);
                newsCheck.Start();
            }

            private void newsCheck_Tick(object sender, EventArgs e)
            {
                try
                {
                    if (dbCon.IsConnect())
                    {
                        DataTable dt = dbCon.Select("SELECT * FROM tbl_programs WHERE available_since>NOW() ORDER BY available_since ASC", "news");
                        if (dt.Rows.Count == 0)
                        {
                            newsPopup.Hide();
                        }
                        else
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                newsPopup.Show();
                                DataRow dr = dt.Rows[i];
                                namePh.Text = dr["name"].ToString();
                                devPh.Text = dr["made_by"].ToString();
                                pricePh.Text = dr["price"].ToString();
                                catPh.Text = dr["categorie"].ToString();
                                releasePh.Text = dr["available_since"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    statusWindow stats = new statusWindow();
                    stats.Show();
                    newsCheck.Stop();
                    DialogResult result = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                    {

                        dbCon.DatabaseName = "jtechgame_hack";
                        dbCon.ResetConn();
                        newsCheck.Start();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
            }

            private void t_Tick(object sender, EventArgs e)
            {
                int hh = DateTime.Now.Hour;
                int mm = DateTime.Now.Minute;
                int ss = DateTime.Now.Second;
                string time = "";
                if (hh < 10)
                {
                    time += "0" + hh;
                }
                else
                {
                    time += hh;
                }
                time += ":";
                if (mm < 10)
                {
                    time += "0" + mm;
                }
                else
                {
                    time += mm;
                }
                time += ":";
                if (ss < 10)
                {
                    time += "0" + ss;
                }
                else
                {
                    time += ss;
                }

                timeLbl.Text = time;
            }

            private void cashTmr_Tick(object sender, EventArgs e)
            {

                try
                {
                    dbCon = DatabaseHandler.Instance();
                    if (dbCon.IsConnect())
                    {
                        string sql = "SELECT money FROM tbl_users WHERE username=@username";
                        MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Prepare();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string valuta = reader.GetString(0);
                            double cash = Convert.ToDouble(valuta);
                            cashLbl.Text = (cash / 100).ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    statusWindow stats = new statusWindow();
                    stats.Show();
                    cashTmr.Stop();
                    DialogResult result = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                    {

                        dbCon.DatabaseName = "jtechgame_hack";
                        dbCon.ResetConn();
                        cashTmr.Start();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }

                }
            }

        #endregion
        #region taskbar

            private void powerBtn_Click(object sender, EventArgs e)
            {
                    Environment.Exit(0);
            }

            private void statBtn_Click(object sender, EventArgs e)
            {
                statusWindow stats = new statusWindow();
                stats.Show();
            }

        #endregion
        #region hotkeys

            private void storeBtn_Click(object sender, EventArgs e)
            {
                store store = new store();
                store.Show();
            }

            private void CT2017Launcher_Click(object sender, EventArgs e)
            {
                CodingTool2017 ct2017 = new CodingTool2017();
                ct2017.Show();
            }

            private void underdevLauncher_Click(object sender, EventArgs e)
            {
                UnderDevelopment ud = new UnderDevelopment();
                ud.Show();
            }

            private void researchLauncher_Click(object sender, EventArgs e)
            {
                Research reserch = new Research();
                reserch.Show();
            }

            private void companyLauncher_Click(object sender, EventArgs e)
            {
                CompanyManagement cm = new CompanyManagement();
                cm.Show();
            }

            private void browserLauncher_Click(object sender, EventArgs e)
            {
                Webbrowser wb = new Webbrowser();
                wb.Show();
            }

        #endregion

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            Library lb = new Library();
            lb.Show();
        }
    }
}
