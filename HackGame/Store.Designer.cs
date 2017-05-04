namespace HackGame
{
    partial class store
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
            this.StoreDisplay = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.madeby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.released = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.itemlist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StoreDisplay
            // 
            this.StoreDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreDisplay.AutoArrange = false;
            this.StoreDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.StoreDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StoreDisplay.CheckBoxes = true;
            this.StoreDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.naam,
            this.price,
            this.categorie,
            this.madeby,
            this.sold,
            this.released});
            this.StoreDisplay.FullRowSelect = true;
            this.StoreDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StoreDisplay.Location = new System.Drawing.Point(12, 77);
            this.StoreDisplay.Name = "StoreDisplay";
            this.StoreDisplay.Size = new System.Drawing.Size(1056, 475);
            this.StoreDisplay.TabIndex = 0;
            this.StoreDisplay.UseCompatibleStateImageBehavior = false;
            this.StoreDisplay.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 36;
            // 
            // naam
            // 
            this.naam.Text = "Name";
            this.naam.Width = 297;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 99;
            // 
            // categorie
            // 
            this.categorie.DisplayIndex = 4;
            this.categorie.Text = "Categorie";
            this.categorie.Width = 241;
            // 
            // madeby
            // 
            this.madeby.DisplayIndex = 3;
            this.madeby.Text = "Made By";
            this.madeby.Width = 128;
            // 
            // sold
            // 
            this.sold.Text = "Sold";
            this.sold.Width = 99;
            // 
            // released
            // 
            this.released.Text = "Released";
            this.released.Width = 142;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(234, 43);
            this.title.TabIndex = 1;
            this.title.Text = "Hacker_St0re";
            // 
            // refreshBtn
            // 
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(993, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 59);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.FlatAppearance.BorderSize = 0;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Location = new System.Drawing.Point(912, 12);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 59);
            this.downloadBtn.TabIndex = 3;
            this.downloadBtn.Text = "Download/ Buy";
            this.downloadBtn.UseVisualStyleBackColor = true;
            // 
            // itemlist
            // 
            this.itemlist.FormattingEnabled = true;
            this.itemlist.Location = new System.Drawing.Point(505, 32);
            this.itemlist.Name = "itemlist";
            this.itemlist.Size = new System.Drawing.Size(401, 21);
            this.itemlist.TabIndex = 4;
            // 
            // store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 564);
            this.Controls.Add(this.itemlist);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.StoreDisplay);
            this.DoubleBuffered = true;
            this.Name = "store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StoreDisplay;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader madeby;
        private System.Windows.Forms.ColumnHeader categorie;
        private System.Windows.Forms.ColumnHeader sold;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.ColumnHeader released;
        private System.Windows.Forms.ComboBox itemlist;
    }
}