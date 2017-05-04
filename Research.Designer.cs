namespace HackGame
{
    partial class Research
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
            this.cpuPanel = new System.Windows.Forms.Panel();
            this.cpuStatsLbl = new System.Windows.Forms.Label();
            this.cpuImage = new System.Windows.Forms.PictureBox();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.gpuPanel = new System.Windows.Forms.Panel();
            this.gpuStatsLbl = new System.Windows.Forms.Label();
            this.gpuImage = new System.Windows.Forms.PictureBox();
            this.gpuLbl = new System.Windows.Forms.Label();
            this.ramPanel = new System.Windows.Forms.Panel();
            this.ramStatsLbl = new System.Windows.Forms.Label();
            this.ramImage = new System.Windows.Forms.PictureBox();
            this.ramLbl = new System.Windows.Forms.Label();
            this.cpuSpeedUpgrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuCoreUpgrade = new System.Windows.Forms.Button();
            this.gpuTypeUpgrade = new System.Windows.Forms.Button();
            this.gpuAmountUpgrade = new System.Windows.Forms.Button();
            this.ramTypeUpgrade = new System.Windows.Forms.Button();
            this.ramAmountUpgrade = new System.Windows.Forms.Button();
            this.moneyLbl = new System.Windows.Forms.Label();
            this.cashTmr = new System.Windows.Forms.Timer(this.components);
            this.cpuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuImage)).BeginInit();
            this.gpuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuImage)).BeginInit();
            this.ramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuPanel
            // 
            this.cpuPanel.BackColor = System.Drawing.Color.Firebrick;
            this.cpuPanel.Controls.Add(this.cpuStatsLbl);
            this.cpuPanel.Controls.Add(this.cpuImage);
            this.cpuPanel.Controls.Add(this.cpuLbl);
            this.cpuPanel.Location = new System.Drawing.Point(12, 12);
            this.cpuPanel.Name = "cpuPanel";
            this.cpuPanel.Size = new System.Drawing.Size(325, 279);
            this.cpuPanel.TabIndex = 0;
            // 
            // cpuStatsLbl
            // 
            this.cpuStatsLbl.AutoSize = true;
            this.cpuStatsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuStatsLbl.ForeColor = System.Drawing.Color.White;
            this.cpuStatsLbl.Location = new System.Drawing.Point(123, 242);
            this.cpuStatsLbl.Name = "cpuStatsLbl";
            this.cpuStatsLbl.Size = new System.Drawing.Size(42, 20);
            this.cpuStatsLbl.TabIndex = 6;
            this.cpuStatsLbl.Text = "CPU";
            // 
            // cpuImage
            // 
            this.cpuImage.Image = global::HackGame.Properties.Resources._003_cpu;
            this.cpuImage.Location = new System.Drawing.Point(3, 42);
            this.cpuImage.Name = "cpuImage";
            this.cpuImage.Size = new System.Drawing.Size(180, 180);
            this.cpuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuImage.TabIndex = 4;
            this.cpuImage.TabStop = false;
            // 
            // cpuLbl
            // 
            this.cpuLbl.AutoSize = true;
            this.cpuLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLbl.ForeColor = System.Drawing.Color.White;
            this.cpuLbl.Location = new System.Drawing.Point(106, 0);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(93, 39);
            this.cpuLbl.TabIndex = 1;
            this.cpuLbl.Text = "CPU";
            this.cpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuPanel
            // 
            this.gpuPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.gpuPanel.Controls.Add(this.gpuStatsLbl);
            this.gpuPanel.Controls.Add(this.gpuImage);
            this.gpuPanel.Controls.Add(this.gpuLbl);
            this.gpuPanel.Location = new System.Drawing.Point(343, 12);
            this.gpuPanel.Name = "gpuPanel";
            this.gpuPanel.Size = new System.Drawing.Size(325, 279);
            this.gpuPanel.TabIndex = 0;
            // 
            // gpuStatsLbl
            // 
            this.gpuStatsLbl.AutoSize = true;
            this.gpuStatsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuStatsLbl.ForeColor = System.Drawing.Color.White;
            this.gpuStatsLbl.Location = new System.Drawing.Point(112, 242);
            this.gpuStatsLbl.Name = "gpuStatsLbl";
            this.gpuStatsLbl.Size = new System.Drawing.Size(44, 20);
            this.gpuStatsLbl.TabIndex = 7;
            this.gpuStatsLbl.Text = "GPU";
            // 
            // gpuImage
            // 
            this.gpuImage.Image = global::HackGame.Properties.Resources._001_graphics_card;
            this.gpuImage.Location = new System.Drawing.Point(3, 42);
            this.gpuImage.Name = "gpuImage";
            this.gpuImage.Size = new System.Drawing.Size(315, 180);
            this.gpuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gpuImage.TabIndex = 5;
            this.gpuImage.TabStop = false;
            // 
            // gpuLbl
            // 
            this.gpuLbl.AutoSize = true;
            this.gpuLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLbl.ForeColor = System.Drawing.Color.White;
            this.gpuLbl.Location = new System.Drawing.Point(109, 0);
            this.gpuLbl.Name = "gpuLbl";
            this.gpuLbl.Size = new System.Drawing.Size(95, 39);
            this.gpuLbl.TabIndex = 2;
            this.gpuLbl.Text = "GPU";
            this.gpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramPanel
            // 
            this.ramPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.ramPanel.Controls.Add(this.ramStatsLbl);
            this.ramPanel.Controls.Add(this.ramImage);
            this.ramPanel.Controls.Add(this.ramLbl);
            this.ramPanel.Location = new System.Drawing.Point(674, 12);
            this.ramPanel.Name = "ramPanel";
            this.ramPanel.Size = new System.Drawing.Size(325, 279);
            this.ramPanel.TabIndex = 0;
            // 
            // ramStatsLbl
            // 
            this.ramStatsLbl.AutoSize = true;
            this.ramStatsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramStatsLbl.ForeColor = System.Drawing.Color.White;
            this.ramStatsLbl.Location = new System.Drawing.Point(119, 242);
            this.ramStatsLbl.Name = "ramStatsLbl";
            this.ramStatsLbl.Size = new System.Drawing.Size(45, 20);
            this.ramStatsLbl.TabIndex = 8;
            this.ramStatsLbl.Text = "RAM";
            // 
            // ramImage
            // 
            this.ramImage.Image = global::HackGame.Properties.Resources._002_ram_memory;
            this.ramImage.Location = new System.Drawing.Point(3, 42);
            this.ramImage.Name = "ramImage";
            this.ramImage.Size = new System.Drawing.Size(315, 180);
            this.ramImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ramImage.TabIndex = 6;
            this.ramImage.TabStop = false;
            // 
            // ramLbl
            // 
            this.ramLbl.AutoSize = true;
            this.ramLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ramLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramLbl.ForeColor = System.Drawing.Color.White;
            this.ramLbl.Location = new System.Drawing.Point(116, 0);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(97, 39);
            this.ramLbl.TabIndex = 3;
            this.ramLbl.Text = "RAM";
            this.ramLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuSpeedUpgrade
            // 
            this.cpuSpeedUpgrade.Location = new System.Drawing.Point(12, 297);
            this.cpuSpeedUpgrade.Name = "cpuSpeedUpgrade";
            this.cpuSpeedUpgrade.Size = new System.Drawing.Size(151, 42);
            this.cpuSpeedUpgrade.TabIndex = 1;
            this.cpuSpeedUpgrade.Text = "Upgrade Speed";
            this.cpuSpeedUpgrade.UseVisualStyleBackColor = true;
            this.cpuSpeedUpgrade.Click += new System.EventHandler(this.cpuSpeedUpgrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HackGame.Properties.Settings.Default, "un", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(9, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = global::HackGame.Properties.Settings.Default.un;
            // 
            // cpuCoreUpgrade
            // 
            this.cpuCoreUpgrade.Location = new System.Drawing.Point(186, 297);
            this.cpuCoreUpgrade.Name = "cpuCoreUpgrade";
            this.cpuCoreUpgrade.Size = new System.Drawing.Size(151, 42);
            this.cpuCoreUpgrade.TabIndex = 8;
            this.cpuCoreUpgrade.Text = "Upgrade Cores";
            this.cpuCoreUpgrade.UseVisualStyleBackColor = true;
            this.cpuCoreUpgrade.Click += new System.EventHandler(this.cpuCoreUpgrade_Click);
            // 
            // gpuTypeUpgrade
            // 
            this.gpuTypeUpgrade.Location = new System.Drawing.Point(517, 297);
            this.gpuTypeUpgrade.Name = "gpuTypeUpgrade";
            this.gpuTypeUpgrade.Size = new System.Drawing.Size(151, 42);
            this.gpuTypeUpgrade.TabIndex = 10;
            this.gpuTypeUpgrade.Text = "Upgrade Type";
            this.gpuTypeUpgrade.UseVisualStyleBackColor = true;
            this.gpuTypeUpgrade.Click += new System.EventHandler(this.gpuTypeUpgrade_Click);
            // 
            // gpuAmountUpgrade
            // 
            this.gpuAmountUpgrade.Location = new System.Drawing.Point(343, 297);
            this.gpuAmountUpgrade.Name = "gpuAmountUpgrade";
            this.gpuAmountUpgrade.Size = new System.Drawing.Size(151, 42);
            this.gpuAmountUpgrade.TabIndex = 9;
            this.gpuAmountUpgrade.Text = "Upgrade Amount";
            this.gpuAmountUpgrade.UseVisualStyleBackColor = true;
            this.gpuAmountUpgrade.Click += new System.EventHandler(this.gpuAmountUpgrade_Click);
            // 
            // ramTypeUpgrade
            // 
            this.ramTypeUpgrade.Location = new System.Drawing.Point(848, 297);
            this.ramTypeUpgrade.Name = "ramTypeUpgrade";
            this.ramTypeUpgrade.Size = new System.Drawing.Size(151, 42);
            this.ramTypeUpgrade.TabIndex = 12;
            this.ramTypeUpgrade.Text = "Upgrade Type";
            this.ramTypeUpgrade.UseVisualStyleBackColor = true;
            this.ramTypeUpgrade.Click += new System.EventHandler(this.ramTypeUpgrade_Click);
            // 
            // ramAmountUpgrade
            // 
            this.ramAmountUpgrade.Location = new System.Drawing.Point(674, 297);
            this.ramAmountUpgrade.Name = "ramAmountUpgrade";
            this.ramAmountUpgrade.Size = new System.Drawing.Size(151, 42);
            this.ramAmountUpgrade.TabIndex = 11;
            this.ramAmountUpgrade.Text = "Upgrade Amount";
            this.ramAmountUpgrade.UseVisualStyleBackColor = true;
            this.ramAmountUpgrade.Click += new System.EventHandler(this.ramAmountUpgrade_Click);
            // 
            // moneyLbl
            // 
            this.moneyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyLbl.AutoSize = true;
            this.moneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLbl.Location = new System.Drawing.Point(481, 357);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(66, 24);
            this.moneyLbl.TabIndex = 13;
            this.moneyLbl.Text = "CASH";
            // 
            // cashTmr
            // 
            this.cashTmr.Enabled = true;
            this.cashTmr.Tick += new System.EventHandler(this.cashTmr_Tick);
            // 
            // Research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 387);
            this.Controls.Add(this.moneyLbl);
            this.Controls.Add(this.ramTypeUpgrade);
            this.Controls.Add(this.ramAmountUpgrade);
            this.Controls.Add(this.gpuTypeUpgrade);
            this.Controls.Add(this.gpuAmountUpgrade);
            this.Controls.Add(this.cpuCoreUpgrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpuSpeedUpgrade);
            this.Controls.Add(this.ramPanel);
            this.Controls.Add(this.gpuPanel);
            this.Controls.Add(this.cpuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Research";
            this.ShowIcon = false;
            this.Text = "Research";
            this.Load += new System.EventHandler(this.Research_Load);
            this.Resize += new System.EventHandler(this.Research_Resize);
            this.cpuPanel.ResumeLayout(false);
            this.cpuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuImage)).EndInit();
            this.gpuPanel.ResumeLayout(false);
            this.gpuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpuImage)).EndInit();
            this.ramPanel.ResumeLayout(false);
            this.ramPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cpuPanel;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Panel gpuPanel;
        private System.Windows.Forms.Label gpuLbl;
        private System.Windows.Forms.Panel ramPanel;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.PictureBox cpuImage;
        private System.Windows.Forms.PictureBox gpuImage;
        private System.Windows.Forms.PictureBox ramImage;
        private System.Windows.Forms.Label cpuStatsLbl;
        private System.Windows.Forms.Label gpuStatsLbl;
        private System.Windows.Forms.Label ramStatsLbl;
        private System.Windows.Forms.Button cpuSpeedUpgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cpuCoreUpgrade;
        private System.Windows.Forms.Button gpuTypeUpgrade;
        private System.Windows.Forms.Button gpuAmountUpgrade;
        private System.Windows.Forms.Button ramTypeUpgrade;
        private System.Windows.Forms.Button ramAmountUpgrade;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Timer cashTmr;
    }
}