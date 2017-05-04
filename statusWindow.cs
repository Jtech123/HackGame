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
    public partial class statusWindow : Form
    {
        public statusWindow()
        {
            InitializeComponent();
        }

        #region main

            int i = 0;

            private void checkCon_Tick(object sender, EventArgs e)
            {
                if (i < 20)
                {
                    try
                    {
                        DatabaseHandler dbCon = DatabaseHandler.Instance();
                        dbCon.DatabaseName = "jtechgame_hack";
                        if (dbCon.IsConnect())
                        {
                            status.Text = "Connected";
                        }
                        else
                        {
                            status.Text = "Failed to connect";
                        }
                        if (status.Text == "Connected")
                        {
                            status.ForeColor = Color.LimeGreen;
                            button1.Show();
                        }
                        else if (status.Text == "Failed to connect")
                        {
                            status.ForeColor = Color.Red;
                            button1.Hide();
                        }
                        i++;
                    }
                    catch (Exception ex)
                    {
                        status.Text = "Failed to connect";
                        status.ForeColor = Color.Red;
                        button1.Hide();
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    this.Hide();
                }
            }

        #endregion
        
    }
}
