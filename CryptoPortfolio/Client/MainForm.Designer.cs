
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
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.portfolioNameLabel = new System.Windows.Forms.Label();
            this.mouseGrab = new System.Windows.Forms.Panel();
            this.mainInsightPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainAssetsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mainHistoryPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.totalInvestedStaticLabel = new System.Windows.Forms.Label();
            this.totalInvestedCurrencyLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.totalInvestedLabel = new System.Windows.Forms.Label();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.gainLossStaticLabel = new System.Windows.Forms.Label();
            this.valueCurrencyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gainLossLabel = new System.Windows.Forms.Label();
            this.currentValueLabel = new System.Windows.Forms.Label();
            this.mainDashboardPanel = new System.Windows.Forms.Panel();
            this.gainLossCurrencyLabel = new System.Windows.Forms.Label();
            this.showPortfoliosPanel = new System.Windows.Forms.Panel();
            this.openPortfolio2Button = new System.Windows.Forms.Button();
            this.openPortfolio1Button = new System.Windows.Forms.Button();
            this.openPortfolio0Button = new System.Windows.Forms.Button();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.notificationButton = new System.Windows.Forms.Button();
            this.showPortfoliosButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signInOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.insightButton = new System.Windows.Forms.Button();
            this.assetsButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.percentageShowPanel = new System.Windows.Forms.Panel();
            this.percentageNumberLabel = new System.Windows.Forms.Label();
            this.arrowPanel = new System.Windows.Forms.Panel();
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.mouseGrab.SuspendLayout();
            this.mainInsightPanel.SuspendLayout();
            this.mainAssetsPanel.SuspendLayout();
            this.mainHistoryPanel.SuspendLayout();
            this.mainDashboardPanel.SuspendLayout();
            this.showPortfoliosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.percentageShowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountNameLabel.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.accountNameLabel.Location = new System.Drawing.Point(866, 27);
            this.accountNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(115, 19);
            this.accountNameLabel.TabIndex = 4;
            this.accountNameLabel.Text = "Gonçalo Vidal";
            // 
            // portfolioNameLabel
            // 
            this.portfolioNameLabel.AutoSize = true;
            this.portfolioNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portfolioNameLabel.Font = new System.Drawing.Font("Inter Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfolioNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.portfolioNameLabel.Location = new System.Drawing.Point(866, 45);
            this.portfolioNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portfolioNameLabel.Name = "portfolioNameLabel";
            this.portfolioNameLabel.Size = new System.Drawing.Size(63, 14);
            this.portfolioNameLabel.TabIndex = 5;
            this.portfolioNameLabel.Text = "Investment";
            // 
            // mouseGrab
            // 
            this.mouseGrab.Controls.Add(this.accountNameLabel);
            this.mouseGrab.Controls.Add(this.notificationButton);
            this.mouseGrab.Controls.Add(this.showPortfoliosButton);
            this.mouseGrab.Controls.Add(this.portfolioNameLabel);
            this.mouseGrab.Controls.Add(this.settingsButton);
            this.mouseGrab.Location = new System.Drawing.Point(0, 0);
            this.mouseGrab.Margin = new System.Windows.Forms.Padding(4);
            this.mouseGrab.Name = "mouseGrab";
            this.mouseGrab.Size = new System.Drawing.Size(1024, 69);
            this.mouseGrab.TabIndex = 13;
            this.mouseGrab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseGrab_MouseDown);
            // 
            // mainInsightPanel
            // 
            this.mainInsightPanel.Controls.Add(this.label2);
            this.mainInsightPanel.Location = new System.Drawing.Point(208, 77);
            this.mainInsightPanel.Name = "mainInsightPanel";
            this.mainInsightPanel.Size = new System.Drawing.Size(804, 691);
            this.mainInsightPanel.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insight Container";
            // 
            // mainAssetsPanel
            // 
            this.mainAssetsPanel.Controls.Add(this.label3);
            this.mainAssetsPanel.Location = new System.Drawing.Point(208, 76);
            this.mainAssetsPanel.Name = "mainAssetsPanel";
            this.mainAssetsPanel.Size = new System.Drawing.Size(804, 691);
            this.mainAssetsPanel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "My Assets Container";
            // 
            // mainHistoryPanel
            // 
            this.mainHistoryPanel.Controls.Add(this.label5);
            this.mainHistoryPanel.Location = new System.Drawing.Point(208, 76);
            this.mainHistoryPanel.Name = "mainHistoryPanel";
            this.mainHistoryPanel.Size = new System.Drawing.Size(804, 691);
            this.mainHistoryPanel.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transaction History Container";
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.chartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartPanel.Location = new System.Drawing.Point(22, 162);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(481, 250);
            this.chartPanel.TabIndex = 20;
            // 
            // totalInvestedStaticLabel
            // 
            this.totalInvestedStaticLabel.AutoSize = true;
            this.totalInvestedStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalInvestedStaticLabel.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInvestedStaticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.totalInvestedStaticLabel.Location = new System.Drawing.Point(19, 100);
            this.totalInvestedStaticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalInvestedStaticLabel.Name = "totalInvestedStaticLabel";
            this.totalInvestedStaticLabel.Size = new System.Drawing.Size(90, 15);
            this.totalInvestedStaticLabel.TabIndex = 10;
            this.totalInvestedStaticLabel.Text = "Total Invested";
            // 
            // totalInvestedCurrencyLabel
            // 
            this.totalInvestedCurrencyLabel.AutoSize = true;
            this.totalInvestedCurrencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalInvestedCurrencyLabel.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInvestedCurrencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.totalInvestedCurrencyLabel.Location = new System.Drawing.Point(18, 120);
            this.totalInvestedCurrencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalInvestedCurrencyLabel.Name = "totalInvestedCurrencyLabel";
            this.totalInvestedCurrencyLabel.Size = new System.Drawing.Size(23, 23);
            this.totalInvestedCurrencyLabel.TabIndex = 11;
            this.totalInvestedCurrencyLabel.Text = "€";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueLabel.Font = new System.Drawing.Font("Inter SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.valueLabel.Location = new System.Drawing.Point(19, 31);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(97, 16);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "Portfolio Value";
            // 
            // totalInvestedLabel
            // 
            this.totalInvestedLabel.AutoSize = true;
            this.totalInvestedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalInvestedLabel.Font = new System.Drawing.Font("Inter SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.totalInvestedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.totalInvestedLabel.Location = new System.Drawing.Point(37, 115);
            this.totalInvestedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalInvestedLabel.Name = "totalInvestedLabel";
            this.totalInvestedLabel.Size = new System.Drawing.Size(110, 29);
            this.totalInvestedLabel.TabIndex = 12;
            this.totalInvestedLabel.Text = "1000,00";
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.separatorPanel.Location = new System.Drawing.Point(165, 102);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(1, 42);
            this.separatorPanel.TabIndex = 14;
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.historyPanel.Location = new System.Drawing.Point(22, 418);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(481, 260);
            this.historyPanel.TabIndex = 21;
            // 
            // gainLossStaticLabel
            // 
            this.gainLossStaticLabel.AutoSize = true;
            this.gainLossStaticLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gainLossStaticLabel.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gainLossStaticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.gainLossStaticLabel.Location = new System.Drawing.Point(171, 99);
            this.gainLossStaticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gainLossStaticLabel.Name = "gainLossStaticLabel";
            this.gainLossStaticLabel.Size = new System.Drawing.Size(87, 15);
            this.gainLossStaticLabel.TabIndex = 15;
            this.gainLossStaticLabel.Text = "Gains/Losses";
            // 
            // valueCurrencyLabel
            // 
            this.valueCurrencyLabel.AutoSize = true;
            this.valueCurrencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueCurrencyLabel.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCurrencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.valueCurrencyLabel.Location = new System.Drawing.Point(13, 58);
            this.valueCurrencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueCurrencyLabel.Name = "valueCurrencyLabel";
            this.valueCurrencyLabel.Size = new System.Drawing.Size(29, 29);
            this.valueCurrencyLabel.TabIndex = 8;
            this.valueCurrencyLabel.Text = "€";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.panel1.Location = new System.Drawing.Point(509, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 516);
            this.panel1.TabIndex = 22;
            // 
            // gainLossLabel
            // 
            this.gainLossLabel.AutoSize = true;
            this.gainLossLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gainLossLabel.Font = new System.Drawing.Font("Inter SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.gainLossLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.gainLossLabel.Location = new System.Drawing.Point(188, 114);
            this.gainLossLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gainLossLabel.Name = "gainLossLabel";
            this.gainLossLabel.Size = new System.Drawing.Size(110, 29);
            this.gainLossLabel.TabIndex = 17;
            this.gainLossLabel.Text = "1000,00";
            // 
            // currentValueLabel
            // 
            this.currentValueLabel.AutoSize = true;
            this.currentValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentValueLabel.Font = new System.Drawing.Font("Inter SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.currentValueLabel.Location = new System.Drawing.Point(35, 47);
            this.currentValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentValueLabel.Name = "currentValueLabel";
            this.currentValueLabel.Size = new System.Drawing.Size(158, 42);
            this.currentValueLabel.TabIndex = 9;
            this.currentValueLabel.Text = "1000,00";
            // 
            // mainDashboardPanel
            // 
            this.mainDashboardPanel.Controls.Add(this.gainLossLabel);
            this.mainDashboardPanel.Controls.Add(this.percentageShowPanel);
            this.mainDashboardPanel.Controls.Add(this.newTransactionButton);
            this.mainDashboardPanel.Controls.Add(this.currentValueLabel);
            this.mainDashboardPanel.Controls.Add(this.panel1);
            this.mainDashboardPanel.Controls.Add(this.valueCurrencyLabel);
            this.mainDashboardPanel.Controls.Add(this.gainLossStaticLabel);
            this.mainDashboardPanel.Controls.Add(this.historyPanel);
            this.mainDashboardPanel.Controls.Add(this.separatorPanel);
            this.mainDashboardPanel.Controls.Add(this.totalInvestedLabel);
            this.mainDashboardPanel.Controls.Add(this.valueLabel);
            this.mainDashboardPanel.Controls.Add(this.totalInvestedCurrencyLabel);
            this.mainDashboardPanel.Controls.Add(this.totalInvestedStaticLabel);
            this.mainDashboardPanel.Controls.Add(this.chartPanel);
            this.mainDashboardPanel.Controls.Add(this.gainLossCurrencyLabel);
            this.mainDashboardPanel.Location = new System.Drawing.Point(208, 77);
            this.mainDashboardPanel.Name = "mainDashboardPanel";
            this.mainDashboardPanel.Size = new System.Drawing.Size(804, 691);
            this.mainDashboardPanel.TabIndex = 24;
            // 
            // gainLossCurrencyLabel
            // 
            this.gainLossCurrencyLabel.AutoSize = true;
            this.gainLossCurrencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gainLossCurrencyLabel.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gainLossCurrencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(149)))));
            this.gainLossCurrencyLabel.Location = new System.Drawing.Point(169, 120);
            this.gainLossCurrencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gainLossCurrencyLabel.Name = "gainLossCurrencyLabel";
            this.gainLossCurrencyLabel.Size = new System.Drawing.Size(23, 23);
            this.gainLossCurrencyLabel.TabIndex = 16;
            this.gainLossCurrencyLabel.Text = "€";
            // 
            // showPortfoliosPanel
            // 
            this.showPortfoliosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.showPortfoliosPanel.Controls.Add(this.openPortfolio2Button);
            this.showPortfoliosPanel.Controls.Add(this.openPortfolio1Button);
            this.showPortfoliosPanel.Controls.Add(this.openPortfolio0Button);
            this.showPortfoliosPanel.Location = new System.Drawing.Point(861, 62);
            this.showPortfoliosPanel.Name = "showPortfoliosPanel";
            this.showPortfoliosPanel.Size = new System.Drawing.Size(151, 121);
            this.showPortfoliosPanel.TabIndex = 24;
            this.showPortfoliosPanel.Visible = false;
            // 
            // openPortfolio2Button
            // 
            this.openPortfolio2Button.BackgroundImage = global::CryptoPortfolio.Properties.Resources.portfolioNotCreated;
            this.openPortfolio2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openPortfolio2Button.FlatAppearance.BorderSize = 0;
            this.openPortfolio2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPortfolio2Button.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortfolio2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.openPortfolio2Button.Location = new System.Drawing.Point(11, 80);
            this.openPortfolio2Button.Name = "openPortfolio2Button";
            this.openPortfolio2Button.Size = new System.Drawing.Size(130, 27);
            this.openPortfolio2Button.TabIndex = 2;
            this.openPortfolio2Button.Tag = "-1";
            this.openPortfolio2Button.Text = "- Click to add -";
            this.openPortfolio2Button.UseVisualStyleBackColor = true;
            this.openPortfolio2Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPortfolio);
            // 
            // openPortfolio1Button
            // 
            this.openPortfolio1Button.BackgroundImage = global::CryptoPortfolio.Properties.Resources.portfolioNotCreated;
            this.openPortfolio1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openPortfolio1Button.FlatAppearance.BorderSize = 0;
            this.openPortfolio1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPortfolio1Button.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortfolio1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.openPortfolio1Button.Location = new System.Drawing.Point(11, 45);
            this.openPortfolio1Button.Name = "openPortfolio1Button";
            this.openPortfolio1Button.Size = new System.Drawing.Size(130, 27);
            this.openPortfolio1Button.TabIndex = 1;
            this.openPortfolio1Button.Tag = "-1";
            this.openPortfolio1Button.Text = "- Click to add -";
            this.openPortfolio1Button.UseVisualStyleBackColor = true;
            this.openPortfolio1Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPortfolio);
            // 
            // openPortfolio0Button
            // 
            this.openPortfolio0Button.BackgroundImage = global::CryptoPortfolio.Properties.Resources.portfolioNotCreated;
            this.openPortfolio0Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openPortfolio0Button.FlatAppearance.BorderSize = 0;
            this.openPortfolio0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPortfolio0Button.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortfolio0Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.openPortfolio0Button.Location = new System.Drawing.Point(11, 10);
            this.openPortfolio0Button.Name = "openPortfolio0Button";
            this.openPortfolio0Button.Size = new System.Drawing.Size(130, 27);
            this.openPortfolio0Button.TabIndex = 0;
            this.openPortfolio0Button.Tag = "-1";
            this.openPortfolio0Button.Text = "- Click to add -";
            this.openPortfolio0Button.UseVisualStyleBackColor = true;
            this.openPortfolio0Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPortfolio);
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImage = global::CryptoPortfolio.Properties.Resources.Logo;
            this.logoImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImage.InitialImage")));
            this.logoImage.Location = new System.Drawing.Point(12, 11);
            this.logoImage.Margin = new System.Windows.Forms.Padding(4);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(156, 48);
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // notificationButton
            // 
            this.notificationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.notificationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notificationButton.BackgroundImage")));
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notificationButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.notificationButton.FlatAppearance.BorderSize = 0;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.Location = new System.Drawing.Point(804, 35);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(4);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(24, 22);
            this.notificationButton.TabIndex = 2;
            this.notificationButton.UseVisualStyleBackColor = false;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // showPortfoliosButton
            // 
            this.showPortfoliosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.showPortfoliosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPortfoliosButton.BackgroundImage")));
            this.showPortfoliosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showPortfoliosButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.showPortfoliosButton.FlatAppearance.BorderSize = 0;
            this.showPortfoliosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPortfoliosButton.Location = new System.Drawing.Point(981, 31);
            this.showPortfoliosButton.Margin = new System.Windows.Forms.Padding(4);
            this.showPortfoliosButton.Name = "showPortfoliosButton";
            this.showPortfoliosButton.Size = new System.Drawing.Size(32, 15);
            this.showPortfoliosButton.TabIndex = 6;
            this.showPortfoliosButton.UseVisualStyleBackColor = false;
            this.showPortfoliosButton.Click += new System.EventHandler(this.showPortfoliosButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(830, 34);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(24, 22);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBar.BackgroundImage")));
            this.sideBar.Controls.Add(this.versionLabel);
            this.sideBar.Controls.Add(this.label1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.signInOutButton);
            this.sideBar.Controls.Add(this.pictureBox1);
            this.sideBar.Controls.Add(this.dashboardButton);
            this.sideBar.Controls.Add(this.insightButton);
            this.sideBar.Controls.Add(this.assetsButton);
            this.sideBar.Controls.Add(this.historyButton);
            this.sideBar.Location = new System.Drawing.Point(0, 77);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(205, 691);
            this.sideBar.TabIndex = 0;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionLabel.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.versionLabel.Location = new System.Drawing.Point(3, 663);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(48, 15);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(3, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Made by Gonçalo vidal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.panel2.Location = new System.Drawing.Point(2, 631);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 7;
            // 
            // signInOutButton
            // 
            this.signInOutButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.logout_button;
            this.signInOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signInOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signInOutButton.FlatAppearance.BorderSize = 0;
            this.signInOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signInOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInOutButton.Location = new System.Drawing.Point(21, 31);
            this.signInOutButton.Name = "signInOutButton";
            this.signInOutButton.Size = new System.Drawing.Size(160, 30);
            this.signInOutButton.TabIndex = 5;
            this.signInOutButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.AutoSize = true;
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.Dashboard;
            this.dashboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dashboardButton.Location = new System.Drawing.Point(21, 131);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(187, 30);
            this.dashboardButton.TabIndex = 5;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            this.dashboardButton.MouseEnter += new System.EventHandler(this.dashboardButton_MouseEnter);
            this.dashboardButton.MouseLeave += new System.EventHandler(this.dashboardButton_MouseLeave);
            // 
            // insightButton
            // 
            this.insightButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.Insights;
            this.insightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insightButton.FlatAppearance.BorderSize = 0;
            this.insightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insightButton.Location = new System.Drawing.Point(21, 174);
            this.insightButton.Name = "insightButton";
            this.insightButton.Size = new System.Drawing.Size(187, 30);
            this.insightButton.TabIndex = 5;
            this.insightButton.UseVisualStyleBackColor = true;
            this.insightButton.Click += new System.EventHandler(this.insightButton_Click);
            this.insightButton.MouseEnter += new System.EventHandler(this.insightButton_MouseEnter);
            this.insightButton.MouseLeave += new System.EventHandler(this.insightButton_MouseLeave);
            // 
            // assetsButton
            // 
            this.assetsButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.Assets;
            this.assetsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assetsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.assetsButton.FlatAppearance.BorderSize = 0;
            this.assetsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.assetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.assetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetsButton.Location = new System.Drawing.Point(21, 216);
            this.assetsButton.Name = "assetsButton";
            this.assetsButton.Size = new System.Drawing.Size(187, 30);
            this.assetsButton.TabIndex = 5;
            this.assetsButton.UseVisualStyleBackColor = true;
            this.assetsButton.Click += new System.EventHandler(this.assetsButton_Click);
            this.assetsButton.MouseEnter += new System.EventHandler(this.assetsButton_MouseEnter);
            this.assetsButton.MouseLeave += new System.EventHandler(this.assetsButton_MouseLeave);
            // 
            // historyButton
            // 
            this.historyButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.History;
            this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.historyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Location = new System.Drawing.Point(21, 258);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(187, 30);
            this.historyButton.TabIndex = 5;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            this.historyButton.MouseEnter += new System.EventHandler(this.historyButton_MouseEnter);
            this.historyButton.MouseLeave += new System.EventHandler(this.historyButton_MouseLeave);
            // 
            // percentageShowPanel
            // 
            this.percentageShowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.percentageShowPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("percentageShowPanel.BackgroundImage")));
            this.percentageShowPanel.Controls.Add(this.percentageNumberLabel);
            this.percentageShowPanel.Controls.Add(this.arrowPanel);
            this.percentageShowPanel.Location = new System.Drawing.Point(213, 57);
            this.percentageShowPanel.Name = "percentageShowPanel";
            this.percentageShowPanel.Size = new System.Drawing.Size(60, 30);
            this.percentageShowPanel.TabIndex = 19;
            this.percentageShowPanel.Visible = false;
            // 
            // percentageNumberLabel
            // 
            this.percentageNumberLabel.AutoSize = true;
            this.percentageNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentageNumberLabel.Font = new System.Drawing.Font("Inter Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.percentageNumberLabel.Location = new System.Drawing.Point(17, 7);
            this.percentageNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentageNumberLabel.Name = "percentageNumberLabel";
            this.percentageNumberLabel.Size = new System.Drawing.Size(39, 16);
            this.percentageNumberLabel.TabIndex = 23;
            this.percentageNumberLabel.Text = "100%";
            // 
            // arrowPanel
            // 
            this.arrowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.arrowPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowPanel.BackgroundImage")));
            this.arrowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arrowPanel.Location = new System.Drawing.Point(3, 11);
            this.arrowPanel.Name = "arrowPanel";
            this.arrowPanel.Size = new System.Drawing.Size(15, 9);
            this.arrowPanel.TabIndex = 21;
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newTransactionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newTransactionButton.BackgroundImage")));
            this.newTransactionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newTransactionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newTransactionButton.FlatAppearance.BorderSize = 0;
            this.newTransactionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newTransactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTransactionButton.Location = new System.Drawing.Point(654, 114);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(130, 30);
            this.newTransactionButton.TabIndex = 23;
            this.newTransactionButton.UseVisualStyleBackColor = false;
            this.newTransactionButton.Click += new System.EventHandler(this.newTransactionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.showPortfoliosPanel);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.mouseGrab);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.mainDashboardPanel);
            this.Controls.Add(this.mainHistoryPanel);
            this.Controls.Add(this.mainAssetsPanel);
            this.Controls.Add(this.mainInsightPanel);
            this.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "CryptoGon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mouseGrab.ResumeLayout(false);
            this.mouseGrab.PerformLayout();
            this.mainInsightPanel.ResumeLayout(false);
            this.mainInsightPanel.PerformLayout();
            this.mainAssetsPanel.ResumeLayout(false);
            this.mainAssetsPanel.PerformLayout();
            this.mainHistoryPanel.ResumeLayout(false);
            this.mainHistoryPanel.PerformLayout();
            this.mainDashboardPanel.ResumeLayout(false);
            this.mainDashboardPanel.PerformLayout();
            this.showPortfoliosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.percentageShowPanel.ResumeLayout(false);
            this.percentageShowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label portfolioNameLabel;
        private System.Windows.Forms.Button showPortfoliosButton;
        private System.Windows.Forms.Panel mouseGrab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button assetsButton;
        private System.Windows.Forms.Button insightButton;
        private System.Windows.Forms.Button signInOutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel mainInsightPanel;
        private System.Windows.Forms.Panel mainAssetsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mainHistoryPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Label totalInvestedStaticLabel;
        private System.Windows.Forms.Label totalInvestedCurrencyLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label totalInvestedLabel;
        private System.Windows.Forms.Panel separatorPanel;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Label gainLossStaticLabel;
        private System.Windows.Forms.Label valueCurrencyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gainLossLabel;
        private System.Windows.Forms.Label currentValueLabel;
        private System.Windows.Forms.Button newTransactionButton;
        private System.Windows.Forms.Panel percentageShowPanel;
        private System.Windows.Forms.Label percentageNumberLabel;
        private System.Windows.Forms.Panel arrowPanel;
        private System.Windows.Forms.Panel mainDashboardPanel;
        private System.Windows.Forms.Label gainLossCurrencyLabel;
        private System.Windows.Forms.Panel showPortfoliosPanel;
        private System.Windows.Forms.Button openPortfolio0Button;
        private System.Windows.Forms.Button openPortfolio2Button;
        private System.Windows.Forms.Button openPortfolio1Button;
    }
}