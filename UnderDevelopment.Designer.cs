namespace HackGame
{
    partial class UnderDevelopment
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
            this.releasingDisplay = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.madeby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releasing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // releasingDisplay
            // 
            this.releasingDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releasingDisplay.AutoArrange = false;
            this.releasingDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.releasingDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.releasingDisplay.CheckBoxes = true;
            this.releasingDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.naam,
            this.price,
            this.categorie,
            this.madeby,
            this.sold,
            this.releasing});
            this.releasingDisplay.FullRowSelect = true;
            this.releasingDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.releasingDisplay.Location = new System.Drawing.Point(12, 74);
            this.releasingDisplay.Name = "releasingDisplay";
            this.releasingDisplay.Size = new System.Drawing.Size(1065, 475);
            this.releasingDisplay.TabIndex = 1;
            this.releasingDisplay.UseCompatibleStateImageBehavior = false;
            this.releasingDisplay.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 36;
            // 
            // naam
            // 
            this.naam.Text = "Name";
            this.naam.Width = 341;
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
            this.categorie.Width = 170;
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
            this.sold.Width = 106;
            // 
            // releasing
            // 
            this.releasing.Text = "Releasing";
            this.releasing.Width = 165;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(432, 43);
            this.title.TabIndex = 2;
            this.title.Text = "Currently being developed:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1002, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 56);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // UnderDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 561);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.releasingDisplay);
            this.Name = "UnderDevelopment";
            this.Text = "UnderDevelopment";
            this.Load += new System.EventHandler(this.UnderDevelopment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView releasingDisplay;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader categorie;
        private System.Windows.Forms.ColumnHeader madeby;
        private System.Windows.Forms.ColumnHeader sold;
        private System.Windows.Forms.ColumnHeader releasing;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button refreshBtn;
    }
}