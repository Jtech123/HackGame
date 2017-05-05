namespace HackGame
{
    partial class CompanyManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyManagement));
            this.tabs = new System.Windows.Forms.TabControl();
            this.select_companie = new System.Windows.Forms.TabPage();
            this.companySelector = new System.Windows.Forms.ComboBox();
            this.start_a_company = new System.Windows.Forms.TabPage();
            this.start_description = new System.Windows.Forms.Label();
            this.start_title = new System.Windows.Forms.Label();
            this.start_ceo_box = new System.Windows.Forms.TextBox();
            this.start_new_comp = new System.Windows.Forms.Button();
            this.start_comp_box = new System.Windows.Forms.TextBox();
            this.start_ceo = new System.Windows.Forms.Label();
            this.start_comp_name = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.Label();
            this.join_a_company = new System.Windows.Forms.TabPage();
            this.join_comp_hireBOX = new System.Windows.Forms.TextBox();
            this.join_comp_nameBOX = new System.Windows.Forms.TextBox();
            this.join_comp_ceoBOX = new System.Windows.Forms.TextBox();
            this.join_comp_hireringLbl = new System.Windows.Forms.Label();
            this.join_comp_ceoLbl = new System.Windows.Forms.Label();
            this.join_comp_nameLbl = new System.Windows.Forms.Label();
            this.listAllCompanies = new System.Windows.Forms.ComboBox();
            this.finance = new System.Windows.Forms.TabPage();
            this.total_F = new System.Windows.Forms.Label();
            this.total_F_lbl = new System.Windows.Forms.Label();
            this.financeView = new System.Windows.Forms.ListView();
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pBal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.developments = new System.Windows.Forms.TabPage();
            this.employees = new System.Windows.Forms.TabPage();
            this.management = new System.Windows.Forms.TabPage();
            this.searchStateLbl = new System.Windows.Forms.Label();
            this.searchStateBtn = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.select_companie.SuspendLayout();
            this.start_a_company.SuspendLayout();
            this.join_a_company.SuspendLayout();
            this.finance.SuspendLayout();
            this.management.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.select_companie);
            this.tabs.Controls.Add(this.start_a_company);
            this.tabs.Controls.Add(this.join_a_company);
            this.tabs.Controls.Add(this.finance);
            this.tabs.Controls.Add(this.developments);
            this.tabs.Controls.Add(this.employees);
            this.tabs.Controls.Add(this.management);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(953, 493);
            this.tabs.TabIndex = 0;
            // 
            // select_companie
            // 
            this.select_companie.Controls.Add(this.companySelector);
            this.select_companie.Location = new System.Drawing.Point(4, 22);
            this.select_companie.Name = "select_companie";
            this.select_companie.Padding = new System.Windows.Forms.Padding(3);
            this.select_companie.Size = new System.Drawing.Size(945, 467);
            this.select_companie.TabIndex = 5;
            this.select_companie.Text = "Select company";
            this.select_companie.UseVisualStyleBackColor = true;
            // 
            // companySelector
            // 
            this.companySelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companySelector.FormattingEnabled = true;
            this.companySelector.Location = new System.Drawing.Point(6, 6);
            this.companySelector.Name = "companySelector";
            this.companySelector.Size = new System.Drawing.Size(931, 21);
            this.companySelector.TabIndex = 0;
            this.companySelector.SelectedIndexChanged += new System.EventHandler(this.companySelector_SelectedIndexChanged);
            // 
            // start_a_company
            // 
            this.start_a_company.Controls.Add(this.start_description);
            this.start_a_company.Controls.Add(this.start_title);
            this.start_a_company.Controls.Add(this.start_ceo_box);
            this.start_a_company.Controls.Add(this.start_new_comp);
            this.start_a_company.Controls.Add(this.start_comp_box);
            this.start_a_company.Controls.Add(this.start_ceo);
            this.start_a_company.Controls.Add(this.start_comp_name);
            this.start_a_company.Controls.Add(this.username1);
            this.start_a_company.Location = new System.Drawing.Point(4, 22);
            this.start_a_company.Name = "start_a_company";
            this.start_a_company.Padding = new System.Windows.Forms.Padding(3);
            this.start_a_company.Size = new System.Drawing.Size(945, 467);
            this.start_a_company.TabIndex = 0;
            this.start_a_company.Text = "Start a company";
            this.start_a_company.UseVisualStyleBackColor = true;
            // 
            // start_description
            // 
            this.start_description.AutoSize = true;
            this.start_description.Location = new System.Drawing.Point(381, 65);
            this.start_description.Name = "start_description";
            this.start_description.Size = new System.Drawing.Size(179, 13);
            this.start_description.TabIndex = 7;
            this.start_description.Text = "Costs 1000$ to start a new company";
            // 
            // start_title
            // 
            this.start_title.AutoSize = true;
            this.start_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_title.Location = new System.Drawing.Point(331, 26);
            this.start_title.Name = "start_title";
            this.start_title.Size = new System.Drawing.Size(270, 39);
            this.start_title.TabIndex = 6;
            this.start_title.Text = "Start a company";
            // 
            // start_ceo_box
            // 
            this.start_ceo_box.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.start_ceo_box.Location = new System.Drawing.Point(359, 196);
            this.start_ceo_box.Name = "start_ceo_box";
            this.start_ceo_box.ReadOnly = true;
            this.start_ceo_box.Size = new System.Drawing.Size(182, 20);
            this.start_ceo_box.TabIndex = 5;
            this.start_ceo_box.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // start_new_comp
            // 
            this.start_new_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_new_comp.Location = new System.Drawing.Point(359, 276);
            this.start_new_comp.Name = "start_new_comp";
            this.start_new_comp.Size = new System.Drawing.Size(182, 57);
            this.start_new_comp.TabIndex = 4;
            this.start_new_comp.Text = "Start new company (1000$)";
            this.start_new_comp.UseVisualStyleBackColor = true;
            this.start_new_comp.Click += new System.EventHandler(this.start_new_comp_Click);
            // 
            // start_comp_box
            // 
            this.start_comp_box.Location = new System.Drawing.Point(359, 129);
            this.start_comp_box.Name = "start_comp_box";
            this.start_comp_box.Size = new System.Drawing.Size(182, 20);
            this.start_comp_box.TabIndex = 3;
            // 
            // start_ceo
            // 
            this.start_ceo.AutoSize = true;
            this.start_ceo.Location = new System.Drawing.Point(429, 180);
            this.start_ceo.Name = "start_ceo";
            this.start_ceo.Size = new System.Drawing.Size(29, 13);
            this.start_ceo.TabIndex = 2;
            this.start_ceo.Text = "CEO";
            // 
            // start_comp_name
            // 
            this.start_comp_name.AutoSize = true;
            this.start_comp_name.Location = new System.Drawing.Point(381, 113);
            this.start_comp_name.Name = "start_comp_name";
            this.start_comp_name.Size = new System.Drawing.Size(80, 13);
            this.start_comp_name.TabIndex = 1;
            this.start_comp_name.Text = "Company name";
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.username1.Location = new System.Drawing.Point(839, -17);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(0, 13);
            this.username1.TabIndex = 0;
            this.username1.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // join_a_company
            // 
            this.join_a_company.Controls.Add(this.join_comp_hireBOX);
            this.join_a_company.Controls.Add(this.join_comp_nameBOX);
            this.join_a_company.Controls.Add(this.join_comp_ceoBOX);
            this.join_a_company.Controls.Add(this.join_comp_hireringLbl);
            this.join_a_company.Controls.Add(this.join_comp_ceoLbl);
            this.join_a_company.Controls.Add(this.join_comp_nameLbl);
            this.join_a_company.Controls.Add(this.listAllCompanies);
            this.join_a_company.Location = new System.Drawing.Point(4, 22);
            this.join_a_company.Name = "join_a_company";
            this.join_a_company.Size = new System.Drawing.Size(945, 467);
            this.join_a_company.TabIndex = 4;
            this.join_a_company.Text = "Join a company";
            this.join_a_company.UseVisualStyleBackColor = true;
            // 
            // join_comp_hireBOX
            // 
            this.join_comp_hireBOX.Location = new System.Drawing.Point(195, 123);
            this.join_comp_hireBOX.Name = "join_comp_hireBOX";
            this.join_comp_hireBOX.ReadOnly = true;
            this.join_comp_hireBOX.Size = new System.Drawing.Size(253, 20);
            this.join_comp_hireBOX.TabIndex = 6;
            // 
            // join_comp_nameBOX
            // 
            this.join_comp_nameBOX.Location = new System.Drawing.Point(195, 63);
            this.join_comp_nameBOX.Name = "join_comp_nameBOX";
            this.join_comp_nameBOX.ReadOnly = true;
            this.join_comp_nameBOX.Size = new System.Drawing.Size(253, 20);
            this.join_comp_nameBOX.TabIndex = 5;
            // 
            // join_comp_ceoBOX
            // 
            this.join_comp_ceoBOX.Location = new System.Drawing.Point(195, 93);
            this.join_comp_ceoBOX.Name = "join_comp_ceoBOX";
            this.join_comp_ceoBOX.ReadOnly = true;
            this.join_comp_ceoBOX.Size = new System.Drawing.Size(253, 20);
            this.join_comp_ceoBOX.TabIndex = 4;
            this.join_comp_ceoBOX.Text = "TEST";
            // 
            // join_comp_hireringLbl
            // 
            this.join_comp_hireringLbl.AutoSize = true;
            this.join_comp_hireringLbl.Location = new System.Drawing.Point(8, 126);
            this.join_comp_hireringLbl.Name = "join_comp_hireringLbl";
            this.join_comp_hireringLbl.Size = new System.Drawing.Size(72, 13);
            this.join_comp_hireringLbl.TabIndex = 3;
            this.join_comp_hireringLbl.Text = "Hirering state:";
            // 
            // join_comp_ceoLbl
            // 
            this.join_comp_ceoLbl.AutoSize = true;
            this.join_comp_ceoLbl.Location = new System.Drawing.Point(8, 96);
            this.join_comp_ceoLbl.Name = "join_comp_ceoLbl";
            this.join_comp_ceoLbl.Size = new System.Drawing.Size(29, 13);
            this.join_comp_ceoLbl.TabIndex = 2;
            this.join_comp_ceoLbl.Text = "CEO";
            // 
            // join_comp_nameLbl
            // 
            this.join_comp_nameLbl.AutoSize = true;
            this.join_comp_nameLbl.Location = new System.Drawing.Point(8, 66);
            this.join_comp_nameLbl.Name = "join_comp_nameLbl";
            this.join_comp_nameLbl.Size = new System.Drawing.Size(80, 13);
            this.join_comp_nameLbl.TabIndex = 1;
            this.join_comp_nameLbl.Text = "Company name";
            // 
            // listAllCompanies
            // 
            this.listAllCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAllCompanies.FormattingEnabled = true;
            this.listAllCompanies.Location = new System.Drawing.Point(8, 3);
            this.listAllCompanies.Name = "listAllCompanies";
            this.listAllCompanies.Size = new System.Drawing.Size(929, 21);
            this.listAllCompanies.TabIndex = 0;
            this.listAllCompanies.SelectionChangeCommitted += new System.EventHandler(this.listAllCompanies_SelectionChangeCommitted);
            // 
            // finance
            // 
            this.finance.Controls.Add(this.total_F);
            this.finance.Controls.Add(this.total_F_lbl);
            this.finance.Controls.Add(this.financeView);
            this.finance.Location = new System.Drawing.Point(4, 22);
            this.finance.Name = "finance";
            this.finance.Padding = new System.Windows.Forms.Padding(3);
            this.finance.Size = new System.Drawing.Size(945, 467);
            this.finance.TabIndex = 1;
            this.finance.Text = "Finance";
            this.finance.UseVisualStyleBackColor = true;
            // 
            // total_F
            // 
            this.total_F.AutoSize = true;
            this.total_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_F.Location = new System.Drawing.Point(574, 47);
            this.total_F.Name = "total_F";
            this.total_F.Size = new System.Drawing.Size(28, 20);
            this.total_F.TabIndex = 2;
            this.total_F.Text = "{0}";
            // 
            // total_F_lbl
            // 
            this.total_F_lbl.AutoSize = true;
            this.total_F_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_F_lbl.Location = new System.Drawing.Point(480, 47);
            this.total_F_lbl.Name = "total_F_lbl";
            this.total_F_lbl.Size = new System.Drawing.Size(88, 20);
            this.total_F_lbl.TabIndex = 1;
            this.total_F_lbl.Text = "Total profit:";
            // 
            // financeView
            // 
            this.financeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.financeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pName,
            this.pPrice,
            this.pSold,
            this.pBal});
            this.financeView.FullRowSelect = true;
            this.financeView.Location = new System.Drawing.Point(8, 6);
            this.financeView.Name = "financeView";
            this.financeView.Size = new System.Drawing.Size(466, 455);
            this.financeView.TabIndex = 0;
            this.financeView.UseCompatibleStateImageBehavior = false;
            this.financeView.View = System.Windows.Forms.View.Details;
            // 
            // pName
            // 
            this.pName.Text = "Product name";
            this.pName.Width = 237;
            // 
            // pPrice
            // 
            this.pPrice.Text = "Price";
            // 
            // pSold
            // 
            this.pSold.Text = "Sold";
            // 
            // pBal
            // 
            this.pBal.Text = "Profit";
            this.pBal.Width = 100;
            // 
            // developments
            // 
            this.developments.Location = new System.Drawing.Point(4, 22);
            this.developments.Name = "developments";
            this.developments.Size = new System.Drawing.Size(945, 467);
            this.developments.TabIndex = 2;
            this.developments.Text = "Developments";
            this.developments.UseVisualStyleBackColor = true;
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(4, 22);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(945, 467);
            this.employees.TabIndex = 3;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            // 
            // management
            // 
            this.management.Controls.Add(this.searchStateLbl);
            this.management.Controls.Add(this.searchStateBtn);
            this.management.Location = new System.Drawing.Point(4, 22);
            this.management.Name = "management";
            this.management.Padding = new System.Windows.Forms.Padding(3);
            this.management.Size = new System.Drawing.Size(945, 467);
            this.management.TabIndex = 6;
            this.management.Text = "Management";
            this.management.UseVisualStyleBackColor = true;
            // 
            // searchStateLbl
            // 
            this.searchStateLbl.AutoSize = true;
            this.searchStateLbl.Location = new System.Drawing.Point(8, 22);
            this.searchStateLbl.Name = "searchStateLbl";
            this.searchStateLbl.Size = new System.Drawing.Size(103, 13);
            this.searchStateLbl.TabIndex = 1;
            this.searchStateLbl.Text = "Toggle Search state";
            // 
            // searchStateBtn
            // 
            this.searchStateBtn.Location = new System.Drawing.Point(117, 5);
            this.searchStateBtn.Name = "searchStateBtn";
            this.searchStateBtn.Size = new System.Drawing.Size(75, 46);
            this.searchStateBtn.TabIndex = 0;
            this.searchStateBtn.Text = "...";
            this.searchStateBtn.UseVisualStyleBackColor = true;
            this.searchStateBtn.Click += new System.EventHandler(this.searchStateBtn_Click);
            // 
            // CompanyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 493);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompanyManagement";
            this.Text = "CompanyManagement";
            this.Load += new System.EventHandler(this.CompanyManagement_Load);
            this.tabs.ResumeLayout(false);
            this.select_companie.ResumeLayout(false);
            this.start_a_company.ResumeLayout(false);
            this.start_a_company.PerformLayout();
            this.join_a_company.ResumeLayout(false);
            this.join_a_company.PerformLayout();
            this.finance.ResumeLayout(false);
            this.finance.PerformLayout();
            this.management.ResumeLayout(false);
            this.management.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage start_a_company;
        private System.Windows.Forms.Label username1;
        private System.Windows.Forms.TabPage join_a_company;
        private System.Windows.Forms.TabPage finance;
        private System.Windows.Forms.TabPage developments;
        private System.Windows.Forms.TabPage employees;
        private System.Windows.Forms.TabPage select_companie;
        private System.Windows.Forms.ComboBox companySelector;
        private System.Windows.Forms.Label start_description;
        private System.Windows.Forms.Label start_title;
        private System.Windows.Forms.TextBox start_ceo_box;
        private System.Windows.Forms.Button start_new_comp;
        private System.Windows.Forms.TextBox start_comp_box;
        private System.Windows.Forms.Label start_ceo;
        private System.Windows.Forms.Label start_comp_name;
        private System.Windows.Forms.ComboBox listAllCompanies;
        private System.Windows.Forms.Label join_comp_hireringLbl;
        private System.Windows.Forms.Label join_comp_ceoLbl;
        private System.Windows.Forms.Label join_comp_nameLbl;
        private System.Windows.Forms.TextBox join_comp_hireBOX;
        private System.Windows.Forms.TextBox join_comp_nameBOX;
        private System.Windows.Forms.TextBox join_comp_ceoBOX;
        private System.Windows.Forms.TabPage management;
        private System.Windows.Forms.Label searchStateLbl;
        private System.Windows.Forms.Button searchStateBtn;
        private System.Windows.Forms.ListView financeView;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ColumnHeader pPrice;
        private System.Windows.Forms.ColumnHeader pSold;
        private System.Windows.Forms.ColumnHeader pBal;
        private System.Windows.Forms.Label total_F;
        private System.Windows.Forms.Label total_F_lbl;
    }
}