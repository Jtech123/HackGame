namespace HackGame
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.libraryTabs = new System.Windows.Forms.TabControl();
            this.owned = new System.Windows.Forms.TabPage();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.ownedListView = new System.Windows.Forms.ListView();
            this.NameColOwn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.developed = new System.Windows.Forms.TabPage();
            this.devView = new System.Windows.Forms.ListView();
            this.NameColDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoldColDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryTabs.SuspendLayout();
            this.owned.SuspendLayout();
            this.developed.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryTabs
            // 
            this.libraryTabs.Controls.Add(this.owned);
            this.libraryTabs.Controls.Add(this.developed);
            this.libraryTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryTabs.Location = new System.Drawing.Point(0, 28);
            this.libraryTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libraryTabs.Name = "libraryTabs";
            this.libraryTabs.SelectedIndex = 0;
            this.libraryTabs.Size = new System.Drawing.Size(945, 366);
            this.libraryTabs.TabIndex = 0;
            // 
            // owned
            // 
            this.owned.Controls.Add(this.usernameLbl);
            this.owned.Controls.Add(this.ownedListView);
            this.owned.Location = new System.Drawing.Point(4, 25);
            this.owned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.owned.Name = "owned";
            this.owned.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.owned.Size = new System.Drawing.Size(937, 337);
            this.owned.TabIndex = 0;
            this.owned.Text = "Software owned by me";
            this.owned.UseVisualStyleBackColor = true;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameLbl.Location = new System.Drawing.Point(888, -16);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(0, 17);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // ownedListView
            // 
            this.ownedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ownedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColOwn});
            this.ownedListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedListView.FullRowSelect = true;
            this.ownedListView.Location = new System.Drawing.Point(4, 4);
            this.ownedListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ownedListView.Name = "ownedListView";
            this.ownedListView.Size = new System.Drawing.Size(929, 329);
            this.ownedListView.TabIndex = 0;
            this.ownedListView.UseCompatibleStateImageBehavior = false;
            this.ownedListView.View = System.Windows.Forms.View.Details;
            this.ownedListView.Click += new System.EventHandler(this.ownedListView_Click);
            this.ownedListView.DoubleClick += new System.EventHandler(this.ownedListView_DoubleClick);
            // 
            // NameColOwn
            // 
            this.NameColOwn.Text = "Name";
            this.NameColOwn.Width = 180;
            // 
            // developed
            // 
            this.developed.Controls.Add(this.devView);
            this.developed.Location = new System.Drawing.Point(4, 25);
            this.developed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.developed.Name = "developed";
            this.developed.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.developed.Size = new System.Drawing.Size(937, 337);
            this.developed.TabIndex = 1;
            this.developed.Text = "Software developed by me/my company";
            this.developed.UseVisualStyleBackColor = true;
            // 
            // devView
            // 
            this.devView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.devView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColDev,
            this.PriceColDev,
            this.SoldColDev});
            this.devView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devView.FullRowSelect = true;
            this.devView.Location = new System.Drawing.Point(4, 4);
            this.devView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devView.Name = "devView";
            this.devView.Size = new System.Drawing.Size(929, 329);
            this.devView.TabIndex = 0;
            this.devView.UseCompatibleStateImageBehavior = false;
            this.devView.View = System.Windows.Forms.View.Details;
            // 
            // NameColDev
            // 
            this.NameColDev.Text = "Name";
            this.NameColDev.Width = 180;
            // 
            // PriceColDev
            // 
            this.PriceColDev.Text = "Price";
            // 
            // SoldColDev
            // 
            this.SoldColDev.Text = "Sold";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(945, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 394);
            this.Controls.Add(this.libraryTabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.libraryTabs.ResumeLayout(false);
            this.owned.ResumeLayout(false);
            this.owned.PerformLayout();
            this.developed.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl libraryTabs;
        private System.Windows.Forms.TabPage owned;
        private System.Windows.Forms.ListView ownedListView;
        private System.Windows.Forms.TabPage developed;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.ListView devView;
        private System.Windows.Forms.ColumnHeader NameColDev;
        private System.Windows.Forms.ColumnHeader PriceColDev;
        private System.Windows.Forms.ColumnHeader SoldColDev;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader NameColOwn;
    }
}