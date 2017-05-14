namespace HackGame
{
    partial class CodingTool2017
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodingTool2017));
            this.CategorieLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.mbLbl = new System.Windows.Forms.Label();
            this.Publish = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.featureTab = new System.Windows.Forms.TabPage();
            this.featureList = new System.Windows.Forms.CheckedListBox();
            this.codeTab = new System.Windows.Forms.TabPage();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.madeByBox = new System.Windows.Forms.ComboBox();
            this.username1 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.Label();
            this.priceUpdater = new System.Windows.Forms.Timer(this.components);
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.tabs.SuspendLayout();
            this.featureTab.SuspendLayout();
            this.codeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategorieLbl
            // 
            this.CategorieLbl.AutoSize = true;
            this.CategorieLbl.Location = new System.Drawing.Point(652, 54);
            this.CategorieLbl.Name = "CategorieLbl";
            this.CategorieLbl.Size = new System.Drawing.Size(52, 13);
            this.CategorieLbl.TabIndex = 2;
            this.CategorieLbl.Text = "Categorie";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(652, 93);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(31, 13);
            this.PriceLbl.TabIndex = 4;
            this.PriceLbl.Text = "Price";
            // 
            // mbLbl
            // 
            this.mbLbl.AutoSize = true;
            this.mbLbl.Location = new System.Drawing.Point(649, 132);
            this.mbLbl.Name = "mbLbl";
            this.mbLbl.Size = new System.Drawing.Size(49, 13);
            this.mbLbl.TabIndex = 6;
            this.mbLbl.Text = "Made By";
            // 
            // Publish
            // 
            this.Publish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Publish.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publish.Location = new System.Drawing.Point(652, 396);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(222, 60);
            this.Publish.TabIndex = 7;
            this.Publish.Text = "Publish";
            this.Publish.UseVisualStyleBackColor = true;
            this.Publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(652, 15);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(652, 31);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(222, 20);
            this.nameBox.TabIndex = 8;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.featureTab);
            this.tabs.Controls.Add(this.codeTab);
            this.tabs.Location = new System.Drawing.Point(12, 6);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(631, 450);
            this.tabs.TabIndex = 10;
            // 
            // featureTab
            // 
            this.featureTab.Controls.Add(this.featureList);
            this.featureTab.Location = new System.Drawing.Point(4, 22);
            this.featureTab.Name = "featureTab";
            this.featureTab.Padding = new System.Windows.Forms.Padding(3);
            this.featureTab.Size = new System.Drawing.Size(623, 424);
            this.featureTab.TabIndex = 1;
            this.featureTab.Text = "Features";
            this.featureTab.UseVisualStyleBackColor = true;
            // 
            // featureList
            // 
            this.featureList.CheckOnClick = true;
            this.featureList.ColumnWidth = 200;
            this.featureList.FormattingEnabled = true;
            this.featureList.Location = new System.Drawing.Point(6, 3);
            this.featureList.MultiColumn = true;
            this.featureList.Name = "featureList";
            this.featureList.Size = new System.Drawing.Size(614, 409);
            this.featureList.TabIndex = 0;
            this.featureList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.featureList_ItemCheck);
            // 
            // codeTab
            // 
            this.codeTab.Controls.Add(this.codeBox);
            this.codeTab.Location = new System.Drawing.Point(4, 22);
            this.codeTab.Name = "codeTab";
            this.codeTab.Padding = new System.Windows.Forms.Padding(3);
            this.codeTab.Size = new System.Drawing.Size(623, 424);
            this.codeTab.TabIndex = 0;
            this.codeTab.Text = "Code";
            this.codeTab.UseVisualStyleBackColor = true;
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categorieComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(652, 69);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(222, 21);
            this.categorieComboBox.TabIndex = 11;
            this.categorieComboBox.SelectionChangeCommitted += new System.EventHandler(this.categorieComboBox_SelectionChangeCommitted);
            // 
            // madeByBox
            // 
            this.madeByBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.madeByBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.madeByBox.FormattingEnabled = true;
            this.madeByBox.Location = new System.Drawing.Point(652, 148);
            this.madeByBox.Name = "madeByBox";
            this.madeByBox.Size = new System.Drawing.Size(222, 21);
            this.madeByBox.TabIndex = 12;
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.username1.Location = new System.Drawing.Point(649, 380);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(0, 13);
            this.username1.TabIndex = 13;
            this.username1.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // priceBox
            // 
            this.priceBox.AutoSize = true;
            this.priceBox.Location = new System.Drawing.Point(652, 110);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(48, 13);
            this.priceBox.TabIndex = 14;
            this.priceBox.Text = "priceBox";
            // 
            // priceUpdater
            // 
            this.priceUpdater.Enabled = true;
            this.priceUpdater.Tick += new System.EventHandler(this.priceUpdater_Tick);
            // 
            // codeBox
            // 
            this.codeBox.AcceptsTab = true;
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(3, 3);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(617, 418);
            this.codeBox.TabIndex = 0;
            this.codeBox.Text = resources.GetString("codeBox.Text");
            this.codeBox.WordWrap = false;
            this.codeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeBox_KeyDown);
            // 
            // CodingTool2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 466);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.madeByBox);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Publish);
            this.Controls.Add(this.mbLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.CategorieLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CodingTool2017";
            this.Text = "Coding Tool 2017 Enterprice";
            this.Load += new System.EventHandler(this.CodingTool2017_Load);
            this.tabs.ResumeLayout(false);
            this.featureTab.ResumeLayout(false);
            this.codeTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CategorieLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label mbLbl;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage codeTab;
        private System.Windows.Forms.TabPage featureTab;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.CheckedListBox featureList;
        private System.Windows.Forms.ComboBox madeByBox;
        private System.Windows.Forms.Label username1;
        private System.Windows.Forms.Label priceBox;
        private System.Windows.Forms.Timer priceUpdater;
        private System.Windows.Forms.RichTextBox codeBox;
    }
}