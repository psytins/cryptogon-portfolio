namespace CryptoPortfolio.Client
{
    partial class TransactionDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.transactionNumLabel = new System.Windows.Forms.Label();
            this.boughtLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.coinPriceLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.totalTransactionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(113)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.transactionTypeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.boughtLabel);
            this.panel1.Controls.Add(this.transactionNumLabel);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.tittleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 122);
            this.panel1.TabIndex = 0;
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.tittleLabel.Location = new System.Drawing.Point(10, 13);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(241, 29);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "Transaction Details";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Inter", 12F);
            this.typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.typeLabel.Location = new System.Drawing.Point(16, 42);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(163, 19);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Transaction number:";
            // 
            // transactionNumLabel
            // 
            this.transactionNumLabel.AutoSize = true;
            this.transactionNumLabel.Font = new System.Drawing.Font("Inter Medium", 12F);
            this.transactionNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.transactionNumLabel.Location = new System.Drawing.Point(176, 42);
            this.transactionNumLabel.Name = "transactionNumLabel";
            this.transactionNumLabel.Size = new System.Drawing.Size(16, 19);
            this.transactionNumLabel.TabIndex = 2;
            this.transactionNumLabel.Text = "-";
            // 
            // boughtLabel
            // 
            this.boughtLabel.AutoSize = true;
            this.boughtLabel.Font = new System.Drawing.Font("Inter Medium", 14F);
            this.boughtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.boughtLabel.Location = new System.Drawing.Point(11, 94);
            this.boughtLabel.Name = "boughtLabel";
            this.boughtLabel.Size = new System.Drawing.Size(259, 23);
            this.boughtLabel.TabIndex = 3;
            this.boughtLabel.Text = "You bought 3,00 Ethereum !";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Inter", 12F);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.dateLabel.Location = new System.Drawing.Point(403, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(16, 19);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "-";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Inter", 10F);
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.timeLabel.Location = new System.Drawing.Point(431, 32);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(14, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "-";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // coinPriceLabel
            // 
            this.coinPriceLabel.AutoSize = true;
            this.coinPriceLabel.Font = new System.Drawing.Font("Inter Medium", 15F);
            this.coinPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.coinPriceLabel.Location = new System.Drawing.Point(11, 134);
            this.coinPriceLabel.Name = "coinPriceLabel";
            this.coinPriceLabel.Size = new System.Drawing.Size(19, 24);
            this.coinPriceLabel.TabIndex = 6;
            this.coinPriceLabel.Text = "-";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Inter Medium", 15F);
            this.feesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.feesLabel.Location = new System.Drawing.Point(11, 174);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(19, 24);
            this.feesLabel.TabIndex = 7;
            this.feesLabel.Text = "-";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Inter Medium", 15F);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.totalLabel.Location = new System.Drawing.Point(11, 214);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(322, 24);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "The total of your transaction was";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Inter Medium", 15F);
            this.notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.notesLabel.Location = new System.Drawing.Point(11, 262);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(119, 24);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Your notes:";
            // 
            // totalTransactionLabel
            // 
            this.totalTransactionLabel.AutoSize = true;
            this.totalTransactionLabel.Font = new System.Drawing.Font("Inter Medium", 15F);
            this.totalTransactionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.totalTransactionLabel.Location = new System.Drawing.Point(328, 214);
            this.totalTransactionLabel.Name = "totalTransactionLabel";
            this.totalTransactionLabel.Size = new System.Drawing.Size(19, 24);
            this.totalTransactionLabel.TabIndex = 10;
            this.totalTransactionLabel.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(16, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 11;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.notesTextBox.Location = new System.Drawing.Point(12, 289);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(488, 83);
            this.notesTextBox.TabIndex = 12;
            this.notesTextBox.Text = "Empty notes.";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.closeButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(478, 133);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Font = new System.Drawing.Font("Inter Medium", 12F);
            this.transactionTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(186)))), ((int)(((byte)(143)))));
            this.transactionTypeLabel.Location = new System.Drawing.Point(156, 62);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(16, 19);
            this.transactionTypeLabel.TabIndex = 7;
            this.transactionTypeLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transaction type:";
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(512, 384);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTransactionLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.coinPriceLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "TransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.TransactionDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label transactionNumLabel;
        private System.Windows.Forms.Label boughtLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label coinPriceLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label totalTransactionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Label label3;
    }
}