using MySql.Data.MySqlClient;
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
    public partial class Research : Form
    {
        public Research()
        {
            InitializeComponent();
        }

        #region main
        double money;
        int cpuA;
        int cpuC;
        int gpuA;
        int gpuT;
        int ramA;
        int ramT;

        DatabaseHandler dbCon = DatabaseHandler.Instance();

        private void centerAll()
        {
            cpuImage.Location = new Point(cpuPanel.Width / 2 - cpuImage.Width / 2, cpuImage.Location.Y);
            cpuLbl.Location = new Point(cpuPanel.Width / 2 - cpuLbl.Width / 2, cpuLbl.Location.Y);
            cpuStatsLbl.Location = new Point(cpuPanel.Width / 2 - cpuStatsLbl.Width / 2, cpuStatsLbl.Location.Y);
            gpuImage.Location = new Point(gpuPanel.Width / 2 - gpuImage.Width / 2, gpuImage.Location.Y);
            gpuLbl.Location = new Point(gpuPanel.Width / 2 - gpuLbl.Width / 2, gpuLbl.Location.Y);
            gpuStatsLbl.Location = new Point(gpuPanel.Width / 2 - gpuStatsLbl.Width / 2, gpuStatsLbl.Location.Y);
            ramImage.Location = new Point(ramPanel.Width / 2 - ramImage.Width / 2, ramImage.Location.Y);
            ramLbl.Location = new Point(ramPanel.Width / 2 - ramLbl.Width / 2, ramLbl.Location.Y);
            ramStatsLbl.Location = new Point(ramPanel.Width / 2 - ramStatsLbl.Width / 2, ramStatsLbl.Location.Y);
        }

        private void viewStats()
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    DataTable userdata = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "userdata");
                    for (int i = 0; i < userdata.Rows.Count; i++)
                    {
                        DataRow user = userdata.Rows[i];
                        cpuStatsLbl.Text = "CPU: " + user["cpu_amount"] + " " + user["cpu_cores"] + " cores";
                        gpuStatsLbl.Text = "GPU: " + user["gpu_amount"] + " VRAM " + user["gpu_type"];
                        ramStatsLbl.Text = "RAM: " + user["ram_amount"] + " " + user["ram_type"];
                        #region upgrades
                        #region cpu
                        #region cpu amount

                        if (user["cpu_amount"].ToString() == "1 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Upgrade Speed 200 $";
                            cpuA = 200;
                        }
                        else if (user["cpu_amount"].ToString() == "1.5 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Upgrade Speed 250 $";
                            cpuA = 250;
                        }
                        else if (user["cpu_amount"].ToString() == "2 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Upgrade Speed 300 $";
                            cpuA = 300;
                        }
                        else if (user["cpu_amount"].ToString() == "2.5 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Upgrade Speed 350 $";
                            cpuA = 350;
                        }
                        else if (user["cpu_amount"].ToString() == "3 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Upgrade Speed 400 $";
                            cpuA = 400;
                        }
                        else if (user["cpu_amount"].ToString() == "3.5 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Upgrade Speed 450 $";
                            cpuA = 450;
                        }
                        else if (user["cpu_amount"].ToString() == "4 GHz")
                        {
                            cpuSpeedUpgrade.Text = "Maxed out";
                            cpuSpeedUpgrade.Enabled = false;
                        }
                        #endregion
                        #region cpu cores
                        if (user["cpu_cores"].ToString() == "2")
                        {
                            cpuCoreUpgrade.Text = "Upgrade Cores 500$";
                            cpuC = 500;
                        }
                        else if (user["cpu_cores"].ToString() == "4")
                        {
                            cpuCoreUpgrade.Text = "Upgrade Cores 1000$";
                            cpuC = 1000;
                        }
                        else if (user["cpu_cores"].ToString() == "8")
                        {
                            cpuCoreUpgrade.Text = "Upgrade Cores 2000$";
                            cpuC = 2000;
                        }
                        else if (user["cpu_cores"].ToString() == "16")
                        {
                            cpuCoreUpgrade.Text = "Maxed out";
                            cpuCoreUpgrade.Enabled = false;
                        }
                        #endregion
                        #endregion
                        #region gpu
                        #region gpu amount
                        if (user["gpu_amount"].ToString() == "512 MB")
                        {
                            gpuAmountUpgrade.Text = "Upgrade Amount 200 $";
                            gpuA = 200;
                        }
                        else if (user["gpu_amount"].ToString() == "1 GB")
                        {
                            gpuAmountUpgrade.Text = "Upgrade Amount 250 $";
                            gpuA = 250;
                        }
                        else if (user["gpu_amount"].ToString() == "2 GB")
                        {
                            gpuAmountUpgrade.Text = "Upgrade Amount 300 $";
                            gpuA = 300;
                        }
                        else if (user["gpu_amount"].ToString() == "3 GB")
                        {
                            gpuAmountUpgrade.Text = "Upgrade Amount 350 $";
                            gpuA = 350;
                        }
                        else if (user["gpu_amount"].ToString() == "4 GB")
                        {
                            gpuAmountUpgrade.Text = "Upgrade Amount 400 $";
                            gpuA = 400;
                        }
                        else if (user["gpu_amount"].ToString() == "6 GB")
                        {
                            gpuAmountUpgrade.Text = "Upgrade Amount 450 $";
                            gpuA = 450;
                        }
                        else if (user["gpu_amount"].ToString() == "8 GB")
                        {
                            gpuAmountUpgrade.Text = "Maxed out";
                            gpuAmountUpgrade.Enabled = false;
                        }
                        #endregion
                        #region gpu type
                        if (user["gpu_type"].ToString() == "GDDR3")
                        {
                            gpuTypeUpgrade.Text = "Upgrade Type 750$";
                            gpuT = 750;
                        }
                        else if (user["gpu_type"].ToString() == "GDDR4")
                        {
                            gpuTypeUpgrade.Text = "Upgrade Cores 1500$";
                            gpuT = 1500;
                        }
                        else if (user["gpu_type"].ToString() == "GDDR5")
                        {
                            gpuTypeUpgrade.Text = "Upgrade Cores 3000$";
                            gpuT = 3000;
                        }
                        else if (user["gpu_type"].ToString() == "GDDR6")
                        {
                            gpuTypeUpgrade.Text = "Maxed out";
                            gpuTypeUpgrade.Enabled = false;
                        }
                        #endregion
                        #endregion
                        #region ram
                        #region ram amount
                        if (user["ram_amount"].ToString() == "4 GB")
                        {
                            ramAmountUpgrade.Text = "Upgrade Amount 25 $";
                            ramA = 25;
                        }
                        else if (user["ram_amount"].ToString() == "6 GB")
                        {
                            ramAmountUpgrade.Text = "Upgrade Amount 50 $";
                            ramA = 50;
                        }
                        else if (user["ram_amount"].ToString() == "8 GB")
                        {
                            ramAmountUpgrade.Text = "Upgrade Amount 75 $";
                            ramA = 75;
                        }
                        else if (user["ram_amount"].ToString() == "12 GB")
                        {
                            ramAmountUpgrade.Text = "Upgrade Amount 125 $";
                            ramA = 125;
                        }
                        else if (user["ram_amount"].ToString() == "16 GB")
                        {
                            ramAmountUpgrade.Text = "Upgrade Amount 150 $";
                            ramA = 150;
                        }
                        else if (user["ram_amount"].ToString() == "24 GB")
                        {
                            ramAmountUpgrade.Text = "Upgrade Amount 225 $";
                            ramA = 225;
                        }
                        else if (user["ram_amount"].ToString() == "32 GB")
                        {
                            ramAmountUpgrade.Text = "Maxed out";
                            ramAmountUpgrade.Enabled = false;
                        }
                        #endregion
                        #region ram type
                        if (user["ram_type"].ToString() == "DDR2")
                        {
                            ramTypeUpgrade.Text = "Upgrade Type 100$";
                            ramT = 100;
                        }
                        else if (user["ram_type"].ToString() == "DDR3")
                        {
                            ramTypeUpgrade.Text = "Upgrade Type 200$";
                            ramT = 200;
                        }
                        else if (user["ram_type"].ToString() == "DDR4")
                        {
                            ramTypeUpgrade.Text = "Upgrade Type 400$";
                            ramT = 400;
                        }
                        else if (user["ram_type"].ToString() == "DDR5")
                        {
                            ramTypeUpgrade.Text = "Maxed out";
                            ramTypeUpgrade.Enabled = false;
                        }
                        #endregion
                        #endregion
                        #endregion
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
                }
                else if (result == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void Research_Resize(object sender, EventArgs e)
        {
            centerAll();
        }

        private void Research_Load(object sender, EventArgs e)
        {
            viewStats();
            centerAll();
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
                    cmd.Parameters.AddWithValue("@username", label1.Text);
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        money = Convert.ToDouble(reader.GetString(0));
                        moneyLbl.Text = (money / 100).ToString();
                    }
                    reader.Close();
                }
                moneyLbl.Location = new Point(this.Width / 2 - moneyLbl.Width / 2, moneyLbl.Location.Y);
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

    #region upgradeBtns

        #region cpu
        private void cpuSpeedUpgrade_Click(object sender, EventArgs e)
        {
            if (cpuA == 0)
            {
                MessageBox.Show("CPU speed is at maximum level");
            }
            else
            {
                if (money < cpuA)
                {
                    MessageBox.Show("You don't have enaugh money");
                }
                else
                {
                    try
                    {
                        if (dbCon.IsConnect())
                        {
                            money -= (cpuA * 100);
                            DataTable usrt = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "usrt");
                            string oldCPU = usrt.Rows[0]["cpu_amount"].ToString();
                            string sql = "UPDATE tbl_users SET money=@money, cpu_amount=@cpuA WHERE (username=@username)";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", label1.Text);
                            #region oldCPU
                            if (oldCPU == "1 GHz")
                            {
                                cmd.Parameters.AddWithValue("@cpuA", "1.5 GHz");
                            }
                            else if (oldCPU == "1.5 GHz")
                            {
                                cmd.Parameters.AddWithValue("@cpuA", "2 GHz");
                            }
                            else if (oldCPU == "2 GHz")
                            {
                                cmd.Parameters.AddWithValue("@cpuA", "2.5 GHz");
                            }
                            else if (oldCPU == "2.5 GHz")
                            {
                                cmd.Parameters.AddWithValue("@cpuA", "3 GHz");
                            }
                            else if (oldCPU == "3 GHz")
                            {
                                cmd.Parameters.AddWithValue("@cpuA", "3.5 GHz");
                            }
                            else if (oldCPU == "3.5 GHz")
                            {
                                cmd.Parameters.AddWithValue("@cpuA", "4 GHz");
                            }
                            #endregion
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            reader.Close();
                            viewStats();
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
                }
            }
        }

        private void cpuCoreUpgrade_Click(object sender, EventArgs e)
        {
            if (cpuC == 0)
            {
                MessageBox.Show("CPU speed is at maximum level");
            }
            else
            {
                if (money < cpuC)
                {
                    MessageBox.Show("You don't have enaugh money");
                }
                else
                {
                    try
                    {
                        if (dbCon.IsConnect())
                        {
                            money -= (cpuC * 100);
                            DataTable usrt = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "usrt");
                            string oldCPU = usrt.Rows[0]["cpu_cores"].ToString();
                            string sql = "UPDATE tbl_users SET money=@money, cpu_cores=@cpuC WHERE (username=@username)";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", label1.Text);
                            #region oldCPU
                            if (oldCPU == "2")
                            {
                                cmd.Parameters.AddWithValue("@cpuC", "4");
                            }
                            else if (oldCPU == "4")
                            {
                                cmd.Parameters.AddWithValue("@cpuC", "8");
                            }
                            else if (oldCPU == "8")
                            {
                                cmd.Parameters.AddWithValue("@cpuC", "16");
                            }
                            #endregion
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            reader.Close();
                            viewStats();
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
                }
            }
        }

        #endregion

        #region gpu

        private void gpuAmountUpgrade_Click(object sender, EventArgs e)
        {
            if (gpuA == 0)
            {
                MessageBox.Show("GPU amount is at maximum level");
            }
            else
            {
                if (money < gpuA)
                {
                    MessageBox.Show("You don't have enough money");
                }
                else
                {
                    try
                    {
                        if (dbCon.IsConnect())
                        {
                            money -= (gpuA * 100);
                            DataTable usrt = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "usrt");
                            string oldGPU = usrt.Rows[0]["gpu_amount"].ToString();
                            string sql = "UPDATE tbl_users SET money=@money, gpu_amount=@gpuA WHERE (username=@username)";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", label1.Text);
                            #region oldGPU
                            if (oldGPU == "512 MB")
                            {
                                cmd.Parameters.AddWithValue("@gpuA", "1 GB");
                            }
                            else if (oldGPU == "1 GB")
                            {
                                cmd.Parameters.AddWithValue("@gpuA", "2 GB");
                            }
                            else if (oldGPU == "2 GB")
                            {
                                cmd.Parameters.AddWithValue("@gpuA", "3 GB");
                            }
                            else if (oldGPU == "3 GB")
                            {
                                cmd.Parameters.AddWithValue("@gpuA", "4 GB");
                            }
                            else if (oldGPU == "4 GB")
                            {
                                cmd.Parameters.AddWithValue("@gpuA", "6 GB");
                            }
                            else if (oldGPU == "6 GB")
                            {
                                cmd.Parameters.AddWithValue("@gpuA", "8 GB");
                            }
                            #endregion
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            reader.Close();
                            viewStats();
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
                }
            }
        }

        private void gpuTypeUpgrade_Click(object sender, EventArgs e)
        {
            if (gpuT == 0)
            {
                MessageBox.Show("CPU speed is at maximum level");
            }
            else
            {
                if (money < gpuT)
                {
                    MessageBox.Show("You don't have enaugh money");
                }
                else
                {
                    try
                    {
                        if (dbCon.IsConnect())
                        {
                            money -= (gpuT * 100);
                            DataTable usrt = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "usrt");
                            string oldGPU = usrt.Rows[0]["gpu_type"].ToString();
                            string sql = "UPDATE tbl_users SET money=@money, gpu_type=@gpuT WHERE (username=@username)";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", label1.Text);
                            #region oldCPU
                            if (oldGPU == "GDDR3")
                            {
                                cmd.Parameters.AddWithValue("@gpuT", "GDDR4");
                            }
                            else if (oldGPU == "GDDR4")
                            {
                                cmd.Parameters.AddWithValue("@gpuT", "GDDR5");
                            }
                            else if (oldGPU == "GDDR5")
                            {
                                cmd.Parameters.AddWithValue("@gpuT", "GDDR6");
                            }
                            #endregion
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            reader.Close();
                            viewStats();
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
                }
            }
        }


        #endregion

        #region ram

        private void ramAmountUpgrade_Click(object sender, EventArgs e)
        {
            if (ramA == 0)
            {
                MessageBox.Show("RAM amount is at maximum level");
            }
            else
            {
                if (money < ramA)
                {
                    MessageBox.Show("You don't have enough money");
                }
                else
                {
                    try
                    {
                        if (dbCon.IsConnect())
                        {
                            money -= (ramA * 100);
                            DataTable usrt = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "usrt");
                            string oldRAM = usrt.Rows[0]["ram_amount"].ToString();
                            string sql = "UPDATE tbl_users SET money=@money, ram_amount=@ramA WHERE (username=@username)";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", label1.Text);
                            #region oldRAM
                            if (oldRAM == "4 GB")
                            {
                                cmd.Parameters.AddWithValue("@ramA", "6 GB");
                            }
                            else if (oldRAM == "6 GB")
                            {
                                cmd.Parameters.AddWithValue("@ramA", "8 GB");
                            }
                            else if (oldRAM == "8 GB")
                            {
                                cmd.Parameters.AddWithValue("@ramA", "12 GB");
                            }
                            else if (oldRAM == "12 GB")
                            {
                                cmd.Parameters.AddWithValue("@ramA", "16 GB");
                            }
                            else if (oldRAM == "16 GB")
                            {
                                cmd.Parameters.AddWithValue("@ramA", "24 GB");
                            }
                            else if (oldRAM == "24 GB")
                            {
                                cmd.Parameters.AddWithValue("@ramA", "32 GB");
                            }
                            #endregion
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            reader.Close();
                            viewStats();
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
                }
            }
        }

        private void ramTypeUpgrade_Click(object sender, EventArgs e)
        {
            if (ramT == 0)
            {
                MessageBox.Show("RAM type is at maximum level");
            }
            else
            {
                if (money < ramT)
                {
                    MessageBox.Show("You don't have enough money");
                }
                else
                {
                    try
                    {
                        if (dbCon.IsConnect())
                        {
                            money -= (ramT * 100);
                            DataTable usrt = dbCon.Select("SELECT * FROM tbl_users WHERE (username='" + label1.Text + "')", "usrt");
                            string oldRAM = usrt.Rows[0]["ram_type"].ToString();
                            string sql = "UPDATE tbl_users SET money=@money, ram_type=@ramT WHERE (username=@username)";
                            MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@username", label1.Text);
                            #region oldRAM
                            if (oldRAM == "DDR2")
                            {
                                cmd.Parameters.AddWithValue("@ramT", "DDR3");
                            }
                            else if (oldRAM == "DDR3")
                            {
                                cmd.Parameters.AddWithValue("@ramT", "DDR4");
                            }
                            else if (oldRAM == "DDR4")
                            {
                                cmd.Parameters.AddWithValue("@ramT", "DDR5");
                            }
                            #endregion
                            cmd.Prepare();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            reader.Close();
                            viewStats();
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
                }
            }
        }

        #endregion

        #endregion


    }
}
