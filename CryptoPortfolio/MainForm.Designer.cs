
namespace CryptoPortfolio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBar = new System.Windows.Forms.Panel();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.notificationButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.portfolioNameLabel = new System.Windows.Forms.Label();
            this.showPortfoliosButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueCurrencyLabel = new System.Windows.Forms.Label();
            this.currentValueLabel = new System.Windows.Forms.Label();
            this.totalInvestedStaticLabel = new System.Windows.Forms.Label();
            this.totalInvestedLabel = new System.Windows.Forms.Label();
            this.totalInvestedCurrencyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.sideBar.Location = new System.Drawing.Point(0, 77);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(205, 691);
            this.sideBar.TabIndex = 0;
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoImage.BackgroundImage")));
            this.logoImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImage.InitialImage")));
            this.logoImage.Location = new System.Drawing.Point(11, 11);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(155, 48);
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // notificationButton
            // 
            this.notificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.notificationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notificationButton.BackgroundImage")));
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notificationButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.notificationButton.FlatAppearance.BorderSize = 0;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.Location = new System.Drawing.Point(762, 35);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(16, 16);
            this.notificationButton.TabIndex = 2;
            this.notificationButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(788, 34);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(16, 16);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.accountNameLabel.Location = new System.Drawing.Point(824, 25);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(73, 13);
            this.accountNameLabel.TabIndex = 4;
            this.accountNameLabel.Text = "Gonçalo Vidal";
            // 
            // portfolioNameLabel
            // 
            this.portfolioNameLabel.AutoSize = true;
            this.portfolioNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portfolioNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.portfolioNameLabel.Location = new System.Drawing.Point(825, 42);
            this.portfolioNameLabel.Name = "portfolioNameLabel";
            this.portfolioNameLabel.Size = new System.Drawing.Size(59, 13);
            this.portfolioNameLabel.TabIndex = 5;
            this.portfolioNameLabel.Text = "Investment";
            // 
            // showPortfoliosButton
            // 
            this.showPortfoliosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.showPortfoliosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPortfoliosButton.BackgroundImage")));
            this.showPortfoliosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showPortfoliosButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.showPortfoliosButton.FlatAppearance.BorderSize = 0;
            this.showPortfoliosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPortfoliosButton.Location = new System.Drawing.Point(952, 34);
            this.showPortfoliosButton.Name = "showPortfoliosButton";
            this.showPortfoliosButton.Size = new System.Drawing.Size(16, 16);
            this.showPortfoliosButton.TabIndex = 6;
            this.showPortfoliosButton.UseVisualStyleBackColor = false;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.valueLabel.Location = new System.Drawing.Point(225, 108);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(75, 13);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "Portfolio Value";
            // 
            // valueCurrencyLabel
            // 
            this.valueCurrencyLabel.AutoSize = true;
            this.valueCurrencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueCurrencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.valueCurrencyLabel.Location = new System.Drawing.Point(225, 136);
            this.valueCurrencyLabel.Name = "valueCurrencyLabel";
            this.valueCurrencyLabel.Size = new System.Drawing.Size(13, 13);
            this.valueCurrencyLabel.TabIndex = 8;
            this.valueCurrencyLabel.Text = "€";
            // 
            // currentValueLabel
            // 
            this.currentValueLabel.AutoSize = true;
            this.currentValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.currentValueLabel.Location = new System.Drawing.Point(245, 127);
            this.currentValueLabel.Name = "currentValueLabel";
            this.currentValueLabel.Size = new System.Drawing.Size(46, 13);
            this.currentValueLabel.TabIndex = 9;
            this.currentValueLabel.Text = "1000,00";
            // 
            // totalInvestedStaticLabel
            // 
            this.totalInvestedStaticLabel.AutoSize = true;
            this.totalInvestedStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalInvestedStaticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.totalInvestedStaticLabel.Location = new System.Drawing.Point(225, 173);
            this.totalInvestedStaticLabel.Name = "totalInvestedStaticLabel";
            this.totalInvestedStaticLabel.Size = new System.Drawing.Size(75, 13);
            this.totalInvestedStaticLabel.TabIndex = 10;
            this.totalInvestedStaticLabel.Text = "Total Invested";
            // 
            // totalInvestedLabel
            // 
            this.totalInvestedLabel.AutoSize = true;
            this.totalInvestedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalInvestedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.totalInvestedLabel.Location = new System.Drawing.Point(245, 194);
            this.totalInvestedLabel.Name = "totalInvestedLabel";
            this.totalInvestedLabel.Size = new System.Drawing.Size(46, 13);
            this.totalInvestedLabel.TabIndex = 12;
            this.totalInvestedLabel.Text = "1000,00";
            // 
            // totalInvestedCurrencyLabel
            // 
            this.totalInvestedCurrencyLabel.AutoSize = true;
            this.totalInvestedCurrencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalInvestedCurrencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.totalInvestedCurrencyLabel.Location = new System.Drawing.Point(225, 203);
            this.totalInvestedCurrencyLabel.Name = "totalInvestedCurrencyLabel";
            this.totalInvestedCurrencyLabel.Size = new System.Drawing.Size(13, 13);
            this.totalInvestedCurrencyLabel.TabIndex = 11;
            this.totalInvestedCurrencyLabel.Text = "€";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.totalInvestedLabel);
            this.Controls.Add(this.totalInvestedCurrencyLabel);
            this.Controls.Add(this.totalInvestedStaticLabel);
            this.Controls.Add(this.currentValueLabel);
            this.Controls.Add(this.valueCurrencyLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.showPortfoliosButton);
            this.Controls.Add(this.portfolioNameLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.sideBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label portfolioNameLabel;
        private System.Windows.Forms.Button showPortfoliosButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label valueCurrencyLabel;
        private System.Windows.Forms.Label currentValueLabel;
        private System.Windows.Forms.Label totalInvestedStaticLabel;
        private System.Windows.Forms.Label totalInvestedLabel;
        private System.Windows.Forms.Label totalInvestedCurrencyLabel;
    }
}