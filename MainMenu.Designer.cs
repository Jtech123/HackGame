namespace HackGame
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.taskbar = new System.Windows.Forms.Panel();
            this.timeLbl = new System.Windows.Forms.Label();
            this.cashLbl = new System.Windows.Forms.Label();
            this.cashTmr = new System.Windows.Forms.Timer(this.components);
            this.username = new System.Windows.Forms.Label();
            this.newsPopup = new System.Windows.Forms.Panel();
            this.releasePh = new System.Windows.Forms.Label();
            this.releaseLbl = new System.Windows.Forms.Label();
            this.catPh = new System.Windows.Forms.Label();
            this.pricePh = new System.Windows.Forms.Label();
            this.devPh = new System.Windows.Forms.Label();
            this.namePh = new System.Windows.Forms.Label();
            this.categorieLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.developerLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.newsPopupTitle = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Timer(this.components);
            this.libraryBtn = new System.Windows.Forms.Button();
            this.browserLauncher = new System.Windows.Forms.Button();
            this.companyLauncher = new System.Windows.Forms.Button();
            this.researchLauncher = new System.Windows.Forms.Button();
            this.underdevLauncher = new System.Windows.Forms.Button();
            this.CT2017Launcher = new System.Windows.Forms.Button();
            this.statBtn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.powerBtn = new System.Windows.Forms.Button();
            this.taskbar.SuspendLayout();
            this.newsPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskbar.Controls.Add(this.statBtn);
            this.taskbar.Controls.Add(this.storeBtn);
            this.taskbar.Controls.Add(this.timeLbl);
            this.taskbar.Controls.Add(this.powerBtn);
            this.taskbar.Location = new System.Drawing.Point(0, 562);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(1236, 49);
            this.taskbar.TabIndex = 0;
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(1154, 12);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(79, 20);
            this.timeLbl.TabIndex = 1;
            this.timeLbl.Text = "00:00:00";
            // 
            // cashLbl
            // 
            this.cashLbl.AutoSize = true;
            this.cashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLbl.Location = new System.Drawing.Point(12, 9);
            this.cashLbl.Name = "cashLbl";
            this.cashLbl.Size = new System.Drawing.Size(49, 18);
            this.cashLbl.TabIndex = 3;
            this.cashLbl.Text = "CASH";
            // 
            // cashTmr
            // 
            this.cashTmr.Enabled = true;
            this.cashTmr.Interval = 90;
            this.cashTmr.Tick += new System.EventHandler(this.cashTmr_Tick);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.username.Location = new System.Drawing.Point(12, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 13);
            this.username.TabIndex = 4;
            this.username.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // newsPopup
            // 
            this.newsPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newsPopup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newsPopup.Controls.Add(this.releasePh);
            this.newsPopup.Controls.Add(this.releaseLbl);
            this.newsPopup.Controls.Add(this.catPh);
            this.newsPopup.Controls.Add(this.pricePh);
            this.newsPopup.Controls.Add(this.devPh);
            this.newsPopup.Controls.Add(this.namePh);
            this.newsPopup.Controls.Add(this.categorieLbl);
            this.newsPopup.Controls.Add(this.priceLbl);
            this.newsPopup.Controls.Add(this.developerLbl);
            this.newsPopup.Controls.Add(this.nameLbl);
            this.newsPopup.Controls.Add(this.newsPopupTitle);
            this.newsPopup.Location = new System.Drawing.Point(898, 348);
            this.newsPopup.Name = "newsPopup";
            this.newsPopup.Size = new System.Drawing.Size(335, 208);
            this.newsPopup.TabIndex = 8;
            this.newsPopup.Visible = false;
            // 
            // releasePh
            // 
            this.releasePh.AutoSize = true;
            this.releasePh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releasePh.Location = new System.Drawing.Point(114, 184);
            this.releasePh.Name = "releasePh";
            this.releasePh.Size = new System.Drawing.Size(60, 24);
            this.releasePh.TabIndex = 10;
            this.releasePh.Text = "label1";
            // 
            // releaseLbl
            // 
            this.releaseLbl.AutoSize = true;
            this.releaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseLbl.Location = new System.Drawing.Point(3, 184);
            this.releaseLbl.Name = "releaseLbl";
            this.releaseLbl.Size = new System.Drawing.Size(79, 24);
            this.releaseLbl.TabIndex = 9;
            this.releaseLbl.Text = "Release";
            // 
            // catPh
            // 
            this.catPh.AutoSize = true;
            this.catPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catPh.Location = new System.Drawing.Point(114, 144);
            this.catPh.Name = "catPh";
            this.catPh.Size = new System.Drawing.Size(60, 24);
            this.catPh.TabIndex = 8;
            this.catPh.Text = "label1";
            // 
            // pricePh
            // 
            this.pricePh.AutoSize = true;
            this.pricePh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePh.Location = new System.Drawing.Point(114, 110);
            this.pricePh.Name = "pricePh";
            this.pricePh.Size = new System.Drawing.Size(60, 24);
            this.pricePh.TabIndex = 7;
            this.pricePh.Text = "label1";
            // 
            // devPh
            // 
            this.devPh.AutoSize = true;
            this.devPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devPh.Location = new System.Drawing.Point(114, 76);
            this.devPh.Name = "devPh";
            this.devPh.Size = new System.Drawing.Size(60, 24);
            this.devPh.TabIndex = 6;
            this.devPh.Text = "label6";
            // 
            // namePh
            // 
            this.namePh.AutoSize = true;
            this.namePh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePh.Location = new System.Drawing.Point(114, 42);
            this.namePh.Name = "namePh";
            this.namePh.Size = new System.Drawing.Size(60, 24);
            this.namePh.TabIndex = 5;
            this.namePh.Text = "label1";
            // 
            // categorieLbl
            // 
            this.categorieLbl.AutoSize = true;
            this.categorieLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorieLbl.Location = new System.Drawing.Point(3, 144);
            this.categorieLbl.Name = "categorieLbl";
            this.categorieLbl.Size = new System.Drawing.Size(91, 24);
            this.categorieLbl.TabIndex = 4;
            this.categorieLbl.Text = "Categorie";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(3, 110);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(53, 24);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "Price";
            // 
            // developerLbl
            // 
            this.developerLbl.AutoSize = true;
            this.developerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerLbl.Location = new System.Drawing.Point(3, 76);
            this.developerLbl.Name = "developerLbl";
            this.developerLbl.Size = new System.Drawing.Size(97, 24);
            this.developerLbl.TabIndex = 2;
            this.developerLbl.Text = "Developer";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(3, 42);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 24);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // newsPopupTitle
            // 
            this.newsPopupTitle.AutoEllipsis = true;
            this.newsPopupTitle.AutoSize = true;
            this.newsPopupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsPopupTitle.Location = new System.Drawing.Point(4, 0);
            this.newsPopupTitle.Name = "newsPopupTitle";
            this.newsPopupTitle.Size = new System.Drawing.Size(328, 37);
            this.newsPopupTitle.TabIndex = 0;
            this.newsPopupTitle.Text = "Upcomming Releases";
            // 
            // income
            // 
            this.income.Enabled = true;
            this.income.Interval = 325;
            // 
            // libraryBtn
            // 
            this.libraryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryBtn.BackColor = System.Drawing.Color.Transparent;
            this.libraryBtn.BackgroundImage = global::HackGame.Properties.Resources.globe;
            this.libraryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.libraryBtn.FlatAppearance.BorderSize = 0;
            this.libraryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.libraryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.libraryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libraryBtn.Location = new System.Drawing.Point(846, 104);
            this.libraryBtn.Name = "libraryBtn";
            this.libraryBtn.Size = new System.Drawing.Size(122, 89);
            this.libraryBtn.TabIndex = 11;
            this.libraryBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.libraryBtn.UseVisualStyleBackColor = false;
            this.libraryBtn.Click += new System.EventHandler(this.libraryBtn_Click);
            // 
            // browserLauncher
            // 
            this.browserLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browserLauncher.BackColor = System.Drawing.Color.Transparent;
            this.browserLauncher.BackgroundImage = global::HackGame.Properties.Resources.globe;
            this.browserLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.browserLauncher.FlatAppearance.BorderSize = 0;
            this.browserLauncher.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.browserLauncher.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browserLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browserLauncher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browserLauncher.Location = new System.Drawing.Point(846, 9);
            this.browserLauncher.Name = "browserLauncher";
            this.browserLauncher.Size = new System.Drawing.Size(122, 89);
            this.browserLauncher.TabIndex = 10;
            this.browserLauncher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.browserLauncher.UseVisualStyleBackColor = false;
            this.browserLauncher.Click += new System.EventHandler(this.browserLauncher_Click);
            // 
            // companyLauncher
            // 
            this.companyLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyLauncher.BackColor = System.Drawing.Color.Transparent;
            this.companyLauncher.BackgroundImage = global::HackGame.Properties.Resources.company;
            this.companyLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.companyLauncher.FlatAppearance.BorderSize = 0;
            this.companyLauncher.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.companyLauncher.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.companyLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyLauncher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.companyLauncher.Location = new System.Drawing.Point(1102, 104);
            this.companyLauncher.Name = "companyLauncher";
            this.companyLauncher.Size = new System.Drawing.Size(122, 89);
            this.companyLauncher.TabIndex = 9;
            this.companyLauncher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.companyLauncher.UseVisualStyleBackColor = false;
            this.companyLauncher.Click += new System.EventHandler(this.companyLauncher_Click);
            // 
            // researchLauncher
            // 
            this.researchLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.researchLauncher.BackColor = System.Drawing.Color.Transparent;
            this.researchLauncher.BackgroundImage = global::HackGame.Properties.Resources.research;
            this.researchLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.researchLauncher.FlatAppearance.BorderSize = 0;
            this.researchLauncher.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.researchLauncher.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.researchLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.researchLauncher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.researchLauncher.Location = new System.Drawing.Point(974, 104);
            this.researchLauncher.Name = "researchLauncher";
            this.researchLauncher.Size = new System.Drawing.Size(122, 89);
            this.researchLauncher.TabIndex = 7;
            this.researchLauncher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.researchLauncher.UseVisualStyleBackColor = false;
            this.researchLauncher.Click += new System.EventHandler(this.researchLauncher_Click);
            // 
            // underdevLauncher
            // 
            this.underdevLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.underdevLauncher.BackgroundImage = global::HackGame.Properties.Resources.newspaper;
            this.underdevLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.underdevLauncher.FlatAppearance.BorderSize = 0;
            this.underdevLauncher.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.underdevLauncher.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.underdevLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underdevLauncher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.underdevLauncher.Location = new System.Drawing.Point(974, 12);
            this.underdevLauncher.Name = "underdevLauncher";
            this.underdevLauncher.Size = new System.Drawing.Size(122, 89);
            this.underdevLauncher.TabIndex = 6;
            this.underdevLauncher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.underdevLauncher.UseVisualStyleBackColor = true;
            this.underdevLauncher.Click += new System.EventHandler(this.underdevLauncher_Click);
            // 
            // CT2017Launcher
            // 
            this.CT2017Launcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CT2017Launcher.BackgroundImage = global::HackGame.Properties.Resources._006_code;
            this.CT2017Launcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CT2017Launcher.FlatAppearance.BorderSize = 0;
            this.CT2017Launcher.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CT2017Launcher.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CT2017Launcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CT2017Launcher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CT2017Launcher.Location = new System.Drawing.Point(1102, 9);
            this.CT2017Launcher.Name = "CT2017Launcher";
            this.CT2017Launcher.Size = new System.Drawing.Size(122, 89);
            this.CT2017Launcher.TabIndex = 5;
            this.CT2017Launcher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CT2017Launcher.UseVisualStyleBackColor = true;
            this.CT2017Launcher.Click += new System.EventHandler(this.CT2017Launcher_Click);
            // 
            // statBtn
            // 
            this.statBtn.BackgroundImage = global::HackGame.Properties.Resources._001_wifi;
            this.statBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statBtn.FlatAppearance.BorderSize = 0;
            this.statBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statBtn.Location = new System.Drawing.Point(109, 3);
            this.statBtn.Name = "statBtn";
            this.statBtn.Size = new System.Drawing.Size(40, 40);
            this.statBtn.TabIndex = 3;
            this.statBtn.UseVisualStyleBackColor = true;
            this.statBtn.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.BackgroundImage = global::HackGame.Properties.Resources._003_shopping_cart;
            this.storeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.storeBtn.FlatAppearance.BorderSize = 0;
            this.storeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.storeBtn.Location = new System.Drawing.Point(63, 3);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(40, 40);
            this.storeBtn.TabIndex = 2;
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // powerBtn
            // 
            this.powerBtn.BackgroundImage = global::HackGame.Properties.Resources._004_power_button;
            this.powerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powerBtn.FlatAppearance.BorderSize = 0;
            this.powerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerBtn.ForeColor = System.Drawing.Color.White;
            this.powerBtn.Location = new System.Drawing.Point(3, 3);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(40, 40);
            this.powerBtn.TabIndex = 0;
            this.powerBtn.UseVisualStyleBackColor = true;
            this.powerBtn.Click += new System.EventHandler(this.powerBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1236, 610);
            this.Controls.Add(this.libraryBtn);
            this.Controls.Add(this.browserLauncher);
            this.Controls.Add(this.companyLauncher);
            this.Controls.Add(this.newsPopup);
            this.Controls.Add(this.researchLauncher);
            this.Controls.Add(this.underdevLauncher);
            this.Controls.Add(this.CT2017Launcher);
            this.Controls.Add(this.username);
            this.Controls.Add(this.cashLbl);
            this.Controls.Add(this.taskbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.taskbar.ResumeLayout(false);
            this.taskbar.PerformLayout();
            this.newsPopup.ResumeLayout(false);
            this.newsPopup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button powerBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Label cashLbl;
        private System.Windows.Forms.Timer cashTmr;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button CT2017Launcher;
        private System.Windows.Forms.Button statBtn;
        private System.Windows.Forms.Button underdevLauncher;
        private System.Windows.Forms.Button researchLauncher;
        private System.Windows.Forms.Panel newsPopup;
        private System.Windows.Forms.Label catPh;
        private System.Windows.Forms.Label pricePh;
        private System.Windows.Forms.Label devPh;
        private System.Windows.Forms.Label namePh;
        private System.Windows.Forms.Label categorieLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label developerLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label newsPopupTitle;
        private System.Windows.Forms.Label releasePh;
        private System.Windows.Forms.Label releaseLbl;
        private System.Windows.Forms.Button companyLauncher;
        private System.Windows.Forms.Timer income;
        private System.Windows.Forms.Button browserLauncher;
        private System.Windows.Forms.Panel taskbar;
        private System.Windows.Forms.Button libraryBtn;
    }
}