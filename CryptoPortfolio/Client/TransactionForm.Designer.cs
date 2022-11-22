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
            this.selectCoinLabel = new System.Windows.Forms.Label();
            this.coinPanel = new System.Windows.Forms.Panel();
            this.smallSearchLineLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTransactionPanel = new System.Windows.Forms.Panel();
            this.addTransactionLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coinButton = new System.Windows.Forms.Button();
            this.sellButon = new System.Windows.Forms.Button();
            this.selectCoinPanel.SuspendLayout();
            this.coinPanel.SuspendLayout();
            this.addTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCoinPanel
            // 
            this.selectCoinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
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
            // coinPanel
            // 
            this.coinPanel.Controls.Add(this.coinButton);
            this.coinPanel.Location = new System.Drawing.Point(0, 100);
            this.coinPanel.Name = "coinPanel";
            this.coinPanel.Size = new System.Drawing.Size(351, 376);
            this.coinPanel.TabIndex = 2;
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
            this.addTransactionPanel.Controls.Add(this.panel1);
            this.addTransactionPanel.Controls.Add(this.sellButon);
            this.addTransactionPanel.Controls.Add(this.buyButton);
            this.addTransactionPanel.Controls.Add(this.goBackButton);
            this.addTransactionPanel.Controls.Add(this.addTransactionLabel);
            this.addTransactionPanel.Location = new System.Drawing.Point(12, 12);
            this.addTransactionPanel.Name = "addTransactionPanel";
            this.addTransactionPanel.Size = new System.Drawing.Size(351, 476);
            this.addTransactionPanel.TabIndex = 6;
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
            // buyButton
            // 
            this.buyButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.buyTab;
            this.buyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Location = new System.Drawing.Point(7, 38);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(90, 40);
            this.buyButton.TabIndex = 8;
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.panel1.BackgroundImage = global::CryptoPortfolio.Properties.Resources.addTransactionPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(7, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 410);
            this.panel1.TabIndex = 7;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goBackButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.next1;
            this.goBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Location = new System.Drawing.Point(11, 11);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(16, 16);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = global::CryptoPortfolio.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(170, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // coinButton
            // 
            this.coinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.coinButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.coinButton;
            this.coinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coinButton.FlatAppearance.BorderSize = 0;
            this.coinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coinButton.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.coinButton.Location = new System.Drawing.Point(10, 0);
            this.coinButton.Name = "coinButton";
            this.coinButton.Size = new System.Drawing.Size(335, 32);
            this.coinButton.TabIndex = 1;
            this.coinButton.Tag = "BTC";
            this.coinButton.Text = "Bitcoin";
            this.coinButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coinButton.UseVisualStyleBackColor = false;
            // 
            // sellButon
            // 
            this.sellButon.BackgroundImage = global::CryptoPortfolio.Properties.Resources.sellTab_un;
            this.sellButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sellButon.FlatAppearance.BorderSize = 0;
            this.sellButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButon.Location = new System.Drawing.Point(101, 38);
            this.sellButon.Name = "sellButon";
            this.sellButon.Size = new System.Drawing.Size(90, 40);
            this.sellButon.TabIndex = 9;
            this.sellButon.UseVisualStyleBackColor = true;
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
            this.Text = "New Transaction";
            this.selectCoinPanel.ResumeLayout(false);
            this.selectCoinPanel.PerformLayout();
            this.coinPanel.ResumeLayout(false);
            this.addTransactionPanel.ResumeLayout(false);
            this.addTransactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectCoinPanel;
        private System.Windows.Forms.Label selectCoinLabel;
        private System.Windows.Forms.Button coinButton;
        private System.Windows.Forms.Panel coinPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label smallSearchLineLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel addTransactionPanel;
        private System.Windows.Forms.Label addTransactionLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButon;
    }
}