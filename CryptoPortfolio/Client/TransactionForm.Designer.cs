namespace CryptoPortfolio
{
    partial class TransactionForm
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
            this.selectCoinPanel = new System.Windows.Forms.Panel();
            this.closeOneButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.smallSearchLineLabel = new System.Windows.Forms.Label();
            this.coinPanel = new System.Windows.Forms.Panel();
            this.selectCoinLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTransactionPanel = new System.Windows.Forms.Panel();
            this.buyPanel = new System.Windows.Forms.Panel();
            this.amountRequiredLabel = new System.Windows.Forms.Label();
            this.sellPanel = new System.Windows.Forms.Panel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.pricePerCoinLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.pricePerCoinRequiredLabel = new System.Windows.Forms.Label();
            this.addTransactionButon = new System.Windows.Forms.Button();
            this.totalSpentPanel = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.currencyTotalSpent = new System.Windows.Forms.Label();
            this.totalSpentLabel = new System.Windows.Forms.Label();
            this.notesTextPanel = new System.Windows.Forms.Panel();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.feeTextPanel = new System.Windows.Forms.Panel();
            this.feeNum = new System.Windows.Forms.NumericUpDown();
            this.currencyFeeLabel = new System.Windows.Forms.Label();
            this.pricePerCoinTextPanel = new System.Windows.Forms.Panel();
            this.pricePerCoinNum = new System.Windows.Forms.NumericUpDown();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.amountTextPanel = new System.Windows.Forms.Panel();
            this.amountNum = new System.Windows.Forms.NumericUpDown();
            this.coinShortLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.closeTwoButton = new System.Windows.Forms.Button();
            this.sellButon = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.addTransactionLabel = new System.Windows.Forms.Label();
            this.selectCoinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addTransactionPanel.SuspendLayout();
            this.buyPanel.SuspendLayout();
            this.totalSpentPanel.SuspendLayout();
            this.notesTextPanel.SuspendLayout();
            this.feeTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeNum)).BeginInit();
            this.pricePerCoinTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerCoinNum)).BeginInit();
            this.amountTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCoinPanel
            // 
            this.selectCoinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.selectCoinPanel.Controls.Add(this.closeOneButton);
            this.selectCoinPanel.Controls.Add(this.pictureBox1);
            this.selectCoinPanel.Controls.Add(this.smallSearchLineLabel);
            this.selectCoinPanel.Controls.Add(this.coinPanel);
            this.selectCoinPanel.Controls.Add(this.selectCoinLabel);
            this.selectCoinPanel.Controls.Add(this.textBox1);
            this.selectCoinPanel.Location = new System.Drawing.Point(12, 12);
            this.selectCoinPanel.Name = "selectCoinPanel";
            this.selectCoinPanel.Size = new System.Drawing.Size(351, 476);
            this.selectCoinPanel.TabIndex = 0;
            // 
            // closeOneButton
            // 
            this.closeOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeOneButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.closeButton;
            this.closeOneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeOneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeOneButton.FlatAppearance.BorderSize = 0;
            this.closeOneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeOneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeOneButton.Location = new System.Drawing.Point(312, 12);
            this.closeOneButton.Name = "closeOneButton";
            this.closeOneButton.Size = new System.Drawing.Size(26, 23);
            this.closeOneButton.TabIndex = 6;
            this.closeOneButton.UseVisualStyleBackColor = false;
            this.closeOneButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseForm);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = global::CryptoPortfolio.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(170, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // smallSearchLineLabel
            // 
            this.smallSearchLineLabel.AutoSize = true;
            this.smallSearchLineLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.smallSearchLineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.smallSearchLineLabel.Location = new System.Drawing.Point(143, 65);
            this.smallSearchLineLabel.Name = "smallSearchLineLabel";
            this.smallSearchLineLabel.Size = new System.Drawing.Size(72, 19);
            this.smallSearchLineLabel.TabIndex = 4;
            this.smallSearchLineLabel.Text = "_________";
            this.smallSearchLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinPanel
            // 
            this.coinPanel.AutoScroll = true;
            this.coinPanel.Location = new System.Drawing.Point(0, 100);
            this.coinPanel.Name = "coinPanel";
            this.coinPanel.Size = new System.Drawing.Size(351, 376);
            this.coinPanel.TabIndex = 2;
            // 
            // selectCoinLabel
            // 
            this.selectCoinLabel.AutoSize = true;
            this.selectCoinLabel.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCoinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.selectCoinLabel.Location = new System.Drawing.Point(11, 12);
            this.selectCoinLabel.Name = "selectCoinLabel";
            this.selectCoinLabel.Size = new System.Drawing.Size(148, 29);
            this.selectCoinLabel.TabIndex = 0;
            this.selectCoinLabel.Text = "Select Coin";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(27, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 5;
            // 
            // addTransactionPanel
            // 
            this.addTransactionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.addTransactionPanel.Controls.Add(this.buyPanel);
            this.addTransactionPanel.Controls.Add(this.closeTwoButton);
            this.addTransactionPanel.Controls.Add(this.sellButon);
            this.addTransactionPanel.Controls.Add(this.buyButton);
            this.addTransactionPanel.Controls.Add(this.goBackButton);
            this.addTransactionPanel.Controls.Add(this.addTransactionLabel);
            this.addTransactionPanel.Location = new System.Drawing.Point(12, 12);
            this.addTransactionPanel.Name = "addTransactionPanel";
            this.addTransactionPanel.Size = new System.Drawing.Size(351, 476);
            this.addTransactionPanel.TabIndex = 6;
            // 
            // buyPanel
            // 
            this.buyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.buyPanel.BackgroundImage = global::CryptoPortfolio.Properties.Resources.addTransactionPanel;
            this.buyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyPanel.Controls.Add(this.amountRequiredLabel);
            this.buyPanel.Controls.Add(this.sellPanel);
            this.buyPanel.Controls.Add(this.timePicker);
            this.buyPanel.Controls.Add(this.datePicker);
            this.buyPanel.Controls.Add(this.pricePerCoinLabel);
            this.buyPanel.Controls.Add(this.amountLabel);
            this.buyPanel.Controls.Add(this.pricePerCoinRequiredLabel);
            this.buyPanel.Controls.Add(this.addTransactionButon);
            this.buyPanel.Controls.Add(this.totalSpentPanel);
            this.buyPanel.Controls.Add(this.notesTextPanel);
            this.buyPanel.Controls.Add(this.feeTextPanel);
            this.buyPanel.Controls.Add(this.pricePerCoinTextPanel);
            this.buyPanel.Controls.Add(this.amountTextPanel);
            this.buyPanel.Controls.Add(this.dateLabel);
            this.buyPanel.Controls.Add(this.notesLabel);
            this.buyPanel.Controls.Add(this.feeLabel);
            this.buyPanel.Location = new System.Drawing.Point(7, 67);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(338, 410);
            this.buyPanel.TabIndex = 7;
            // 
            // amountRequiredLabel
            // 
            this.amountRequiredLabel.AutoSize = true;
            this.amountRequiredLabel.Font = new System.Drawing.Font("Inter SemiBold", 9.75F);
            this.amountRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.amountRequiredLabel.Location = new System.Drawing.Point(8, 1);
            this.amountRequiredLabel.Name = "amountRequiredLabel";
            this.amountRequiredLabel.Size = new System.Drawing.Size(67, 16);
            this.amountRequiredLabel.TabIndex = 17;
            this.amountRequiredLabel.Text = "required !";
            this.amountRequiredLabel.Visible = false;
            // 
            // sellPanel
            // 
            this.sellPanel.Location = new System.Drawing.Point(5, 83);
            this.sellPanel.Name = "sellPanel";
            this.sellPanel.Size = new System.Drawing.Size(329, 188);
            this.sellPanel.TabIndex = 19;
            this.sellPanel.Visible = false;
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Inter", 9F);
            this.timePicker.Font = new System.Drawing.Font("Inter", 12F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(6, 217);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(134, 27);
            this.timePicker.TabIndex = 2;
            this.timePicker.Value = new System.DateTime(2022, 12, 1, 13, 35, 0, 0);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Inter", 9F);
            this.datePicker.CalendarForeColor = System.Drawing.Color.DarkBlue;
            this.datePicker.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.datePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.datePicker.Font = new System.Drawing.Font("Inter", 12F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(6, 184);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(135, 27);
            this.datePicker.TabIndex = 1;
            // 
            // pricePerCoinLabel
            // 
            this.pricePerCoinLabel.AutoSize = true;
            this.pricePerCoinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.pricePerCoinLabel.Location = new System.Drawing.Point(156, 14);
            this.pricePerCoinLabel.Name = "pricePerCoinLabel";
            this.pricePerCoinLabel.Size = new System.Drawing.Size(117, 19);
            this.pricePerCoinLabel.TabIndex = 1;
            this.pricePerCoinLabel.Text = "Price Per Coin";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.amountLabel.Location = new System.Drawing.Point(3, 14);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(68, 19);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // pricePerCoinRequiredLabel
            // 
            this.pricePerCoinRequiredLabel.AutoSize = true;
            this.pricePerCoinRequiredLabel.Font = new System.Drawing.Font("Inter SemiBold", 9.75F);
            this.pricePerCoinRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.pricePerCoinRequiredLabel.Location = new System.Drawing.Point(270, 15);
            this.pricePerCoinRequiredLabel.Name = "pricePerCoinRequiredLabel";
            this.pricePerCoinRequiredLabel.Size = new System.Drawing.Size(67, 16);
            this.pricePerCoinRequiredLabel.TabIndex = 18;
            this.pricePerCoinRequiredLabel.Text = "required !";
            this.pricePerCoinRequiredLabel.Visible = false;
            // 
            // addTransactionButon
            // 
            this.addTransactionButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addTransactionButon.BackgroundImage = global::CryptoPortfolio.Properties.Resources.addTransactionButton;
            this.addTransactionButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addTransactionButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTransactionButon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addTransactionButon.FlatAppearance.BorderSize = 0;
            this.addTransactionButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addTransactionButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addTransactionButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTransactionButon.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTransactionButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.addTransactionButon.Location = new System.Drawing.Point(15, 356);
            this.addTransactionButon.Name = "addTransactionButon";
            this.addTransactionButon.Size = new System.Drawing.Size(307, 37);
            this.addTransactionButon.TabIndex = 16;
            this.addTransactionButon.Text = "Add Transaction";
            this.addTransactionButon.UseVisualStyleBackColor = false;
            this.addTransactionButon.Click += new System.EventHandler(this.addTransactionButon_Click);
            // 
            // totalSpentPanel
            // 
            this.totalSpentPanel.BackgroundImage = global::CryptoPortfolio.Properties.Resources.totalSpent;
            this.totalSpentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.totalSpentPanel.Controls.Add(this.totalLabel);
            this.totalSpentPanel.Controls.Add(this.currencyTotalSpent);
            this.totalSpentPanel.Controls.Add(this.totalSpentLabel);
            this.totalSpentPanel.Location = new System.Drawing.Point(6, 277);
            this.totalSpentPanel.Name = "totalSpentPanel";
            this.totalSpentPanel.Size = new System.Drawing.Size(326, 66);
            this.totalSpentPanel.TabIndex = 15;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.totalLabel.Font = new System.Drawing.Font("Inter Medium", 9.75F);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.totalLabel.Location = new System.Drawing.Point(6, 6);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(77, 16);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "Total Spent";
            // 
            // currencyTotalSpent
            // 
            this.currencyTotalSpent.AutoSize = true;
            this.currencyTotalSpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.currencyTotalSpent.Font = new System.Drawing.Font("Inter Medium", 14F, System.Drawing.FontStyle.Bold);
            this.currencyTotalSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(173)))));
            this.currencyTotalSpent.Location = new System.Drawing.Point(5, 30);
            this.currencyTotalSpent.Name = "currencyTotalSpent";
            this.currencyTotalSpent.Size = new System.Drawing.Size(0, 23);
            this.currencyTotalSpent.TabIndex = 3;
            // 
            // totalSpentLabel
            // 
            this.totalSpentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.totalSpentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalSpentLabel.Font = new System.Drawing.Font("Inter SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.totalSpentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.totalSpentLabel.Location = new System.Drawing.Point(25, 25);
            this.totalSpentLabel.Name = "totalSpentLabel";
            this.totalSpentLabel.Size = new System.Drawing.Size(285, 28);
            this.totalSpentLabel.TabIndex = 18;
            this.totalSpentLabel.Text = "0";
            // 
            // notesTextPanel
            // 
            this.notesTextPanel.BackgroundImage = global::CryptoPortfolio.Properties.Resources.notesTextBox;
            this.notesTextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notesTextPanel.Controls.Add(this.notesTextBox);
            this.notesTextPanel.Location = new System.Drawing.Point(160, 104);
            this.notesTextPanel.Name = "notesTextPanel";
            this.notesTextPanel.Size = new System.Drawing.Size(172, 154);
            this.notesTextPanel.TabIndex = 8;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.notesTextBox.Location = new System.Drawing.Point(6, 7);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(156, 140);
            this.notesTextBox.TabIndex = 0;
            // 
            // feeTextPanel
            // 
            this.feeTextPanel.BackgroundImage = global::CryptoPortfolio.Properties.Resources.feesTextBox;
            this.feeTextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feeTextPanel.Controls.Add(this.feeNum);
            this.feeTextPanel.Controls.Add(this.currencyFeeLabel);
            this.feeTextPanel.Location = new System.Drawing.Point(6, 104);
            this.feeTextPanel.Name = "feeTextPanel";
            this.feeTextPanel.Size = new System.Drawing.Size(148, 38);
            this.feeTextPanel.TabIndex = 7;
            // 
            // feeNum
            // 
            this.feeNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.feeNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feeNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.feeNum.DecimalPlaces = 2;
            this.feeNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.feeNum.Location = new System.Drawing.Point(22, 7);
            this.feeNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.feeNum.Name = "feeNum";
            this.feeNum.Size = new System.Drawing.Size(118, 23);
            this.feeNum.TabIndex = 20;
            this.feeNum.ValueChanged += new System.EventHandler(this.CalculateTotal);
            // 
            // currencyFeeLabel
            // 
            this.currencyFeeLabel.AutoSize = true;
            this.currencyFeeLabel.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(173)))));
            this.currencyFeeLabel.Location = new System.Drawing.Point(6, 9);
            this.currencyFeeLabel.Name = "currencyFeeLabel";
            this.currencyFeeLabel.Size = new System.Drawing.Size(13, 16);
            this.currencyFeeLabel.TabIndex = 2;
            this.currencyFeeLabel.Text = "-";
            // 
            // pricePerCoinTextPanel
            // 
            this.pricePerCoinTextPanel.BackgroundImage = global::CryptoPortfolio.Properties.Resources.pricePerCoinLabel;
            this.pricePerCoinTextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pricePerCoinTextPanel.Controls.Add(this.pricePerCoinNum);
            this.pricePerCoinTextPanel.Controls.Add(this.currencyLabel);
            this.pricePerCoinTextPanel.Location = new System.Drawing.Point(160, 36);
            this.pricePerCoinTextPanel.Name = "pricePerCoinTextPanel";
            this.pricePerCoinTextPanel.Size = new System.Drawing.Size(172, 38);
            this.pricePerCoinTextPanel.TabIndex = 6;
            // 
            // pricePerCoinNum
            // 
            this.pricePerCoinNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.pricePerCoinNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricePerCoinNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricePerCoinNum.DecimalPlaces = 2;
            this.pricePerCoinNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.pricePerCoinNum.Location = new System.Drawing.Point(22, 7);
            this.pricePerCoinNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.pricePerCoinNum.Name = "pricePerCoinNum";
            this.pricePerCoinNum.Size = new System.Drawing.Size(140, 23);
            this.pricePerCoinNum.TabIndex = 20;
            this.pricePerCoinNum.ValueChanged += new System.EventHandler(this.CalculateTotal);
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(173)))));
            this.currencyLabel.Location = new System.Drawing.Point(6, 9);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(13, 16);
            this.currencyLabel.TabIndex = 2;
            this.currencyLabel.Text = "-";
            // 
            // amountTextPanel
            // 
            this.amountTextPanel.BackgroundImage = global::CryptoPortfolio.Properties.Resources.amountTextBox;
            this.amountTextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.amountTextPanel.Controls.Add(this.amountNum);
            this.amountTextPanel.Controls.Add(this.coinShortLabel);
            this.amountTextPanel.Location = new System.Drawing.Point(6, 36);
            this.amountTextPanel.Name = "amountTextPanel";
            this.amountTextPanel.Size = new System.Drawing.Size(148, 38);
            this.amountTextPanel.TabIndex = 5;
            // 
            // amountNum
            // 
            this.amountNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.amountNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountNum.DecimalPlaces = 2;
            this.amountNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.amountNum.Location = new System.Drawing.Point(51, 7);
            this.amountNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(90, 23);
            this.amountNum.TabIndex = 19;
            this.amountNum.ValueChanged += new System.EventHandler(this.CalculateTotal);
            // 
            // coinShortLabel
            // 
            this.coinShortLabel.AutoSize = true;
            this.coinShortLabel.Font = new System.Drawing.Font("Inter", 8F);
            this.coinShortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(173)))));
            this.coinShortLabel.Location = new System.Drawing.Point(4, 10);
            this.coinShortLabel.Name = "coinShortLabel";
            this.coinShortLabel.Size = new System.Drawing.Size(12, 14);
            this.coinShortLabel.TabIndex = 0;
            this.coinShortLabel.Text = "-";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.dateLabel.Location = new System.Drawing.Point(3, 157);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(120, 19);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date and Time";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.notesLabel.Location = new System.Drawing.Point(156, 83);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(54, 19);
            this.notesLabel.TabIndex = 3;
            this.notesLabel.Text = "Notes";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.feeLabel.Location = new System.Drawing.Point(3, 83);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(35, 19);
            this.feeLabel.TabIndex = 2;
            this.feeLabel.Text = "Fee";
            // 
            // closeTwoButton
            // 
            this.closeTwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeTwoButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.closeButton;
            this.closeTwoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeTwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeTwoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeTwoButton.FlatAppearance.BorderSize = 0;
            this.closeTwoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeTwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTwoButton.Location = new System.Drawing.Point(312, 12);
            this.closeTwoButton.Name = "closeTwoButton";
            this.closeTwoButton.Size = new System.Drawing.Size(26, 23);
            this.closeTwoButton.TabIndex = 10;
            this.closeTwoButton.UseVisualStyleBackColor = false;
            this.closeTwoButton.Click += new System.EventHandler(this.CloseForm);
            this.closeTwoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseForm);
            // 
            // sellButon
            // 
            this.sellButon.BackgroundImage = global::CryptoPortfolio.Properties.Resources.sellTab_un;
            this.sellButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sellButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellButon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButon.FlatAppearance.BorderSize = 0;
            this.sellButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButon.Location = new System.Drawing.Point(101, 38);
            this.sellButon.Name = "sellButon";
            this.sellButon.Size = new System.Drawing.Size(90, 40);
            this.sellButon.TabIndex = 9;
            this.sellButon.UseVisualStyleBackColor = true;
            this.sellButon.Click += new System.EventHandler(this.sellButon_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.buyTab;
            this.buyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Location = new System.Drawing.Point(7, 38);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(90, 40);
            this.buyButton.TabIndex = 8;
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goBackButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.next1;
            this.goBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Location = new System.Drawing.Point(11, 11);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(16, 16);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GoBack);
            // 
            // addTransactionLabel
            // 
            this.addTransactionLabel.AutoSize = true;
            this.addTransactionLabel.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTransactionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.addTransactionLabel.Location = new System.Drawing.Point(24, 7);
            this.addTransactionLabel.Name = "addTransactionLabel";
            this.addTransactionLabel.Size = new System.Drawing.Size(164, 23);
            this.addTransactionLabel.TabIndex = 0;
            this.addTransactionLabel.Text = "Add Transaction";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(375, 500);
            this.Controls.Add(this.addTransactionPanel);
            this.Controls.Add(this.selectCoinPanel);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 500);
            this.MinimumSize = new System.Drawing.Size(375, 500);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.selectCoinPanel.ResumeLayout(false);
            this.selectCoinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addTransactionPanel.ResumeLayout(false);
            this.addTransactionPanel.PerformLayout();
            this.buyPanel.ResumeLayout(false);
            this.buyPanel.PerformLayout();
            this.totalSpentPanel.ResumeLayout(false);
            this.totalSpentPanel.PerformLayout();
            this.notesTextPanel.ResumeLayout(false);
            this.notesTextPanel.PerformLayout();
            this.feeTextPanel.ResumeLayout(false);
            this.feeTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeNum)).EndInit();
            this.pricePerCoinTextPanel.ResumeLayout(false);
            this.pricePerCoinTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerCoinNum)).EndInit();
            this.amountTextPanel.ResumeLayout(false);
            this.amountTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectCoinPanel;
        private System.Windows.Forms.Label selectCoinLabel;
        private System.Windows.Forms.Panel coinPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label smallSearchLineLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel addTransactionPanel;
        private System.Windows.Forms.Label addTransactionLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButon;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label pricePerCoinLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Panel amountTextPanel;
        private System.Windows.Forms.Label coinShortLabel;
        private System.Windows.Forms.Panel pricePerCoinTextPanel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Panel feeTextPanel;
        private System.Windows.Forms.Label currencyFeeLabel;
        private System.Windows.Forms.Panel notesTextPanel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Panel totalSpentPanel;
        private System.Windows.Forms.Button addTransactionButon;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label currencyTotalSpent;
        private System.Windows.Forms.Label totalSpentLabel;
        private System.Windows.Forms.Button closeOneButton;
        private System.Windows.Forms.Button closeTwoButton;
        private System.Windows.Forms.Label amountRequiredLabel;
        private System.Windows.Forms.Label pricePerCoinRequiredLabel;
        private System.Windows.Forms.NumericUpDown amountNum;
        private System.Windows.Forms.NumericUpDown pricePerCoinNum;
        private System.Windows.Forms.NumericUpDown feeNum;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Panel sellPanel;
    }
}