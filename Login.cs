using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using CryptSharp.Utility;

namespace HackGame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region main

            private DatabaseHandler dbCon;

            private void Login_Load(object sender, EventArgs e)
            {
                try
                {
                    dbCon = DatabaseHandler.Instance();
                    dbCon.DatabaseName = "jtechgame_hack";
                    if (dbCon.IsConnect())
                    {
                        status.Text = "Connected";
                    }
                    else
                    {
                        status.Text = "Failed to connect";
                    }
                }
                catch (Exception ex)
                {
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
            }

        
        private bool validate(string pass)
        {
            bool checkPass = CryptSharp.BlowfishCrypter.CheckPassword(passwordBox.Text, pass);
            return checkPass;
        }

        #endregion
        #region btn

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    //suppose col0 and col1 are defined as VARCHAR in the DB
                    string query = "SELECT username, password FROM tbl_users WHERE username=@username";
                    MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection);
                    cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                    cmd.Prepare();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("The username and/or password is invalid.");
                        usernameBox.Text = "";
                        passwordBox.Text = "";
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            if (validate(reader.GetString(1)))
                            {
                                statusWindow stats = new statusWindow();
                                MainMenu mm = new MainMenu();
                                mm.Show();
                                stats.Show();
                            }
                            else
                            {
                                MessageBox.Show("The username and/or password is invalid.");
                                usernameBox.Text = "";
                                passwordBox.Text = "";
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

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
        }
        #endregion

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char enter = Convert.ToChar(Keys.Enter);
            if (e.KeyChar.Equals(enter))
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char enter = Convert.ToChar(Keys.Enter);
            if (e.KeyChar.Equals(enter))
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}
