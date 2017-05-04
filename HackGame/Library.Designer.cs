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
            this.libraryTabs = new System.Windows.Forms.TabControl();
            this.owned = new System.Windows.Forms.TabPage();
            this.developed = new System.Windows.Forms.TabPage();
            this.ownedListView = new System.Windows.Forms.ListView();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.devView = new System.Windows.Forms.ListView();
            this.NameColDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoldColDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libraryTabs.SuspendLayout();
            this.owned.SuspendLayout();
            this.developed.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryTabs
            // 
            this.libraryTabs.Controls.Add(this.owned);
            this.libraryTabs.Controls.Add(this.developed);
            this.libraryTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryTabs.Location = new System.Drawing.Point(0, 0);
            this.libraryTabs.Name = "libraryTabs";
            this.libraryTabs.SelectedIndex = 0;
            this.libraryTabs.Size = new System.Drawing.Size(709, 320);
            this.libraryTabs.TabIndex = 0;
            // 
            // owned
            // 
            this.owned.Controls.Add(this.usernameLbl);
            this.owned.Controls.Add(this.ownedListView);
            this.owned.Location = new System.Drawing.Point(4, 22);
            this.owned.Name = "owned";
            this.owned.Padding = new System.Windows.Forms.Padding(3);
            this.owned.Size = new System.Drawing.Size(701, 294);
            this.owned.TabIndex = 0;
            this.owned.Text = "Software owned by me";
            this.owned.UseVisualStyleBackColor = true;
            // 
            // developed
            // 
            this.developed.Controls.Add(this.devView);
            this.developed.Location = new System.Drawing.Point(4, 22);
            this.developed.Name = "developed";
            this.developed.Padding = new System.Windows.Forms.Padding(3);
            this.developed.Size = new System.Drawing.Size(701, 294);
            this.developed.TabIndex = 1;
            this.developed.Text = "Software developed by me/my company";
            this.developed.UseVisualStyleBackColor = true;
            // 
            // ownedListView
            // 
            this.ownedListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownedListView.Location = new System.Drawing.Point(3, 3);
            this.ownedListView.Name = "ownedListView";
            this.ownedListView.Size = new System.Drawing.Size(695, 288);
            this.ownedListView.TabIndex = 0;
            this.ownedListView.UseCompatibleStateImageBehavior = false;
            this.ownedListView.View = System.Windows.Forms.View.Details;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameLbl.Location = new System.Drawing.Point(666, -13);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(0, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // devView
            // 
            this.devView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColDev,
            this.PriceColDev,
            this.SoldColDev});
            this.devView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devView.Location = new System.Drawing.Point(3, 3);
            this.devView.Name = "devView";
            this.devView.Size = new System.Drawing.Size(695, 288);
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
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 320);
            this.Controls.Add(this.libraryTabs);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.libraryTabs.ResumeLayout(false);
            this.owned.ResumeLayout(false);
            this.owned.PerformLayout();
            this.developed.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}