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
    public partial class CompanyManagement : Form
    {
        public CompanyManagement()
        {
            InitializeComponent();
        }

        #region main

        DatabaseHandler dbCon;

        private void CompanyManagement_Load(object sender, EventArgs e)
        {
            centerAll();
            try
            {
                join_comp_ceoBOX.Text = "";
                dbCon = DatabaseHandler.Instance();
                if (dbCon.IsConnect())
                {
                    DataTable companies = dbCon.Select("SELECT * FROM tbl_companies WHERE (ceo='" + username1.Text + "')", "companies");
                    if (companies.Rows.Count > 0)
                    {
                        join_a_company.Dispose();
                    }
                    else
                    {
                        finance.Dispose();
                        employees.Dispose();
                        developments.Dispose();
                        select_companie.Dispose();
                        management.Dispose();
                    }
                    for (int i = 0; i < companies.Rows.Count; i++)
                    {
                        DataRow company = companies.Rows[i];
                        companySelector.Items.Add(company["name"].ToString());
                    }
                    if (companies.Rows.Count > 0)
                    {
                        companySelector.SelectedIndex = 0;
                    }
                    DataTable allCompanies = dbCon.Select("SELECT * FROM tbl_companies", "companies");
                    for (int i = 0; i < allCompanies.Rows.Count; i++)
                    {
                        DataRow Acompany = allCompanies.Rows[i];
                        listAllCompanies.Items.Add(Acompany["name"].ToString());
                    }
                    if (allCompanies.Rows.Count > 0)
                    {
                        listAllCompanies.SelectedIndex = 0;
                        showDetails();
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

        private void CompanyManagement_Resize(object sender, EventArgs e)
        {
            centerAll();
        }

        private void ShowItems(DataTable table)
        {
            financeView.Items.Clear();
            int totalProfit = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dataRow = table.Rows[i];
                ListViewItem lstItem = new ListViewItem((i + 1).ToString());
                lstItem.Text = dataRow["name"].ToString();
                lstItem.SubItems.Add(dataRow["price"].ToString());
                lstItem.SubItems.Add(dataRow["sold"].ToString());
                int price = Convert.ToInt32(dataRow["price"]);
                int sold = Convert.ToInt32(dataRow["sold"]);
                int profit = price * sold;
                lstItem.SubItems.Add(profit.ToString());
                financeView.Items.Add(lstItem);
                totalProfit += profit;
            }
            total_F.Text = totalProfit.ToString();
        }

        #endregion
        #region select company
        private void companySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectingCompany();
        }
        private void selectingCompany()
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    
                    
                    DataTable my_company = dbCon.Select("SELECT * FROM tbl_companies WHERE (name='" + companySelector.SelectedItem.ToString() + "')", "my_company");
                    DataRow my_company_row = my_company.Rows[0];
                    DataTable company_products = dbCon.Select("SELECT * FROM tbl_programs WHERE (made_by='" + companySelector.SelectedItem.ToString() + "')", "companyProducts");
                    #region finance
                    ShowItems(company_products);
                    #endregion
                    #region management
                    if (my_company_row["searching"].ToString() == "True")
                    {
                        searchStateBtn.Text = "Searching";
                        searchStateBtn.ForeColor = Color.Green;
                    }
                    else
                    {
                        searchStateBtn.Text = "Not searching";
                        searchStateBtn.ForeColor = Color.Red;
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
        #region start company

        private void centerAll()
        {
            start_ceo.Location = new Point(start_a_company.Width / 2 - start_ceo.Width / 2, start_ceo.Location.Y);
            start_ceo_box.Location = new Point(start_a_company.Width / 2 - start_ceo_box.Width / 2, start_ceo_box.Location.Y);
            start_comp_box.Location = new Point(start_a_company.Width / 2 - start_comp_box.Width / 2, start_comp_box.Location.Y);
            start_comp_name.Location = new Point(start_a_company.Width / 2 - start_comp_name.Width / 2, start_comp_name.Location.Y);
            start_description.Location = new Point(start_a_company.Width / 2 - start_description.Width / 2, start_description.Location.Y);
            start_title.Location = new Point(start_a_company.Width / 2 - start_title.Width / 2, start_title.Location.Y);
            start_new_comp.Location = new Point(start_a_company.Width / 2 - start_new_comp.Width / 2, start_new_comp.Location.Y);
        }

        private void start_new_comp_Click(object sender, EventArgs e)
        {
            if (start_comp_box.Text == null || start_comp_box.Text == "")
            {
                MessageBox.Show("There is no name inserted.");
            }
            else
            {
                DataTable readCEO = dbCon.Select("SELECT money FROM tbl_users WHERE (username='" + start_ceo_box.Text + "')", "readCEO");
                DataRow readCEOrow = readCEO.Rows[0];
                double money = Convert.ToDouble(readCEOrow["money"].ToString());
                if ((money / 100) < 1000)
                {
                    MessageBox.Show("You don't have enaugh money");
                }
                else
                {
                    DataTable checkCreate = dbCon.Select("SELECT * FROM tbl_companies WHERE (name='" + start_comp_box.Text + "')", "checkCreate");
                    if (checkCreate.Rows.Count > 0)
                    {
                        MessageBox.Show("This company name is already taken.");
                    }
                    else
                    {
                        try
                        {
                            if (dbCon.IsConnect())
                            {
                                string sql = "INSERT INTO tbl_companies (name, ceo) VALUES (@name, @ceo)";
                                MySqlCommand cmd2 = new MySqlCommand(sql, dbCon.Connection);
                                cmd2.Parameters.AddWithValue("@name", start_comp_box.Text);
                                cmd2.Parameters.AddWithValue("@ceo", start_ceo_box.Text);
                                cmd2.Prepare();
                                MySqlDataReader reader2 = cmd2.ExecuteReader();
                                while (reader2.Read())
                                {

                                }
                                reader2.Close();
                                money -= (1000 * 100);
                                string sql2 = "UPDATE tbl_users SET money=@money WHERE username=@username";
                                MySqlCommand cmd3 = new MySqlCommand(sql2, dbCon.Connection);
                                cmd3.Parameters.AddWithValue("@money", money);
                                cmd3.Parameters.AddWithValue("@username", start_ceo_box.Text);
                                cmd3.Prepare();
                                MySqlDataReader reader3 = cmd2.ExecuteReader();
                                while (reader3.Read())
                                {

                                }
                                reader3.Close();
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
        }

        #endregion
        #region join company
        private void listAllCompanies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showDetails();
        }
        private void showDetails()
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    DataTable company_details = dbCon.Select("SELECT * FROM tbl_companies WHERE (name='" + listAllCompanies.SelectedItem.ToString() + "')", "company_details");
                    for (int i = 0; i < company_details.Rows.Count; i++)
                    {
                        DataRow company_detail = company_details.Rows[i];
                        join_comp_nameBOX.Text = company_detail["name"].ToString();
                        join_comp_ceoBOX.Text = company_detail["ceo"].ToString();
                        if (company_detail["searching"].ToString() == "True")
                        {
                            join_comp_hireBOX.Text = "YES";
                            join_comp_hireBOX.ForeColor = Color.Green;
                        }
                        else
                        {
                            join_comp_hireBOX.Text = "No";
                            join_comp_hireBOX.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
        #region finance

        #endregion
        #region developments

        #endregion
        #region employees

        #endregion
        #region management

        private void searchStateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    if (searchStateBtn.Text == "Not searching")
                    {
                        searchStateBtn.Text = "Searching";
                        searchStateBtn.ForeColor = Color.Green;
                        string sql = "UPDATE tbl_companies SET searching=@searching WHERE (name=@name)";
                        MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                        cmd.Parameters.AddWithValue("@searching", "1");
                        cmd.Parameters.AddWithValue("@name", companySelector.SelectedItem.ToString());
                        cmd.Prepare();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                    else if (searchStateBtn.Text == "Searching")
                    {
                        searchStateBtn.Text = "Not searching";
                        searchStateBtn.ForeColor = Color.Red;
                        string sql = "UPDATE tbl_companies SET searching=@searching WHERE (name=@name)";
                        MySqlCommand cmd = new MySqlCommand(sql, dbCon.Connection);
                        cmd.Parameters.AddWithValue("@searching", "0");
                        cmd.Parameters.AddWithValue("@name", companySelector.SelectedItem.ToString());
                        cmd.Prepare();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }







        #endregion

        
    }
}
