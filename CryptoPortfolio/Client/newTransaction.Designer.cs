
namespace CryptoPortfolio
{
    partial class newTransaction_form
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
            this.coin_label = new System.Windows.Forms.Label();
            this.coins_comboBox = new System.Windows.Forms.ComboBox();
            this.date_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.date_datetimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_textBox = new System.Windows.Forms.TextBox();
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.coin_textBox = new System.Windows.Forms.TextBox();
            this.exchange_textBox = new System.Windows.Forms.TextBox();
            this.exchange_label = new System.Windows.Forms.Label();
            this.exchangeEuro_textBox = new System.Windows.Forms.TextBox();
            this.taxes_textBox = new System.Windows.Forms.TextBox();
            this.taxes_label = new System.Windows.Forms.Label();
            this.taxesEuro_textBox = new System.Windows.Forms.TextBox();
            this.addTransaction_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coin_label
            // 
            this.coin_label.AutoSize = true;
            this.coin_label.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coin_label.Location = new System.Drawing.Point(12, 9);
            this.coin_label.Name = "coin_label";
            this.coin_label.Size = new System.Drawing.Size(74, 26);
            this.coin_label.TabIndex = 0;
            this.coin_label.Text = "Moeda";
            // 
            // coins_comboBox
            // 
            this.coins_comboBox.FormattingEnabled = true;
            this.coins_comboBox.Location = new System.Drawing.Point(17, 38);
            this.coins_comboBox.Name = "coins_comboBox";
            this.coins_comboBox.Size = new System.Drawing.Size(255, 21);
            this.coins_comboBox.TabIndex = 1;
            this.coins_comboBox.SelectedIndexChanged += new System.EventHandler(this.coins_comboBox_SelectedIndexChanged);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(12, 72);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(55, 26);
            this.date_label.TabIndex = 2;
            this.date_label.Text = "Data";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(153, 72);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(58, 26);
            this.time_label.TabIndex = 3;
            this.time_label.Text = "Hora";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(12, 136);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(100, 26);
            this.amount_label.TabIndex = 4;
            this.amount_label.Text = "Montante";
            // 
            // date_datetimePicker
            // 
            this.date_datetimePicker.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_datetimePicker.Location = new System.Drawing.Point(17, 101);
            this.date_datetimePicker.Name = "date_datetimePicker";
            this.date_datetimePicker.Size = new System.Drawing.Size(135, 21);
            this.date_datetimePicker.TabIndex = 5;
            // 
            // time_textBox
            // 
            this.time_textBox.Location = new System.Drawing.Point(158, 105);
            this.time_textBox.Name = "time_textBox";
            this.time_textBox.Size = new System.Drawing.Size(114, 20);
            this.time_textBox.TabIndex = 6;
            this.time_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.time_textBox_MouseClick);
            this.time_textBox.MouseLeave += new System.EventHandler(this.time_textBox_MouseLeave);
            // 
            // amount_textBox
            // 
            this.amount_textBox.Location = new System.Drawing.Point(17, 165);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.Size = new System.Drawing.Size(203, 20);
            this.amount_textBox.TabIndex = 7;
            // 
            // coin_textBox
            // 
            this.coin_textBox.Location = new System.Drawing.Point(226, 165);
            this.coin_textBox.Name = "coin_textBox";
            this.coin_textBox.ReadOnly = true;
            this.coin_textBox.Size = new System.Drawing.Size(46, 20);
            this.coin_textBox.TabIndex = 8;
            // 
            // exchange_textBox
            // 
            this.exchange_textBox.Location = new System.Drawing.Point(17, 227);
            this.exchange_textBox.Name = "exchange_textBox";
            this.exchange_textBox.Size = new System.Drawing.Size(203, 20);
            this.exchange_textBox.TabIndex = 10;
            // 
            // exchange_label
            // 
            this.exchange_label.AutoSize = true;
            this.exchange_label.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchange_label.Location = new System.Drawing.Point(12, 198);
            this.exchange_label.Name = "exchange_label";
            this.exchange_label.Size = new System.Drawing.Size(63, 26);
            this.exchange_label.TabIndex = 9;
            this.exchange_label.Text = "Preço";
            // 
            // exchangeEuro_textBox
            // 
            this.exchangeEuro_textBox.Location = new System.Drawing.Point(226, 227);
            this.exchangeEuro_textBox.Name = "exchangeEuro_textBox";
            this.exchangeEuro_textBox.ReadOnly = true;
            this.exchangeEuro_textBox.Size = new System.Drawing.Size(46, 20);
            this.exchangeEuro_textBox.TabIndex = 11;
            // 
            // taxes_textBox
            // 
            this.taxes_textBox.Location = new System.Drawing.Point(17, 293);
            this.taxes_textBox.Name = "taxes_textBox";
            this.taxes_textBox.Size = new System.Drawing.Size(203, 20);
            this.taxes_textBox.TabIndex = 13;
            // 
            // taxes_label
            // 
            this.taxes_label.AutoSize = true;
            this.taxes_label.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxes_label.Location = new System.Drawing.Point(12, 264);
            this.taxes_label.Name = "taxes_label";
            this.taxes_label.Size = new System.Drawing.Size(63, 26);
            this.taxes_label.TabIndex = 12;
            this.taxes_label.Text = "Taxas";
            // 
            // taxesEuro_textBox
            // 
            this.taxesEuro_textBox.Location = new System.Drawing.Point(226, 293);
            this.taxesEuro_textBox.Name = "taxesEuro_textBox";
            this.taxesEuro_textBox.ReadOnly = true;
            this.taxesEuro_textBox.Size = new System.Drawing.Size(46, 20);
            this.taxesEuro_textBox.TabIndex = 14;
            // 
            // addTransaction_button
            // 
            this.addTransaction_button.Location = new System.Drawing.Point(17, 324);
            this.addTransaction_button.Name = "addTransaction_button";
            this.addTransaction_button.Size = new System.Drawing.Size(159, 28);
            this.addTransaction_button.TabIndex = 15;
            this.addTransaction_button.Text = "Adicionar Transação";
            this.addTransaction_button.UseVisualStyleBackColor = true;
            this.addTransaction_button.Click += new System.EventHandler(this.addTransaction_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(182, 324);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(90, 28);
            this.cancel_button.TabIndex = 16;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // newTransaction_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addTransaction_button);
            this.Controls.Add(this.taxesEuro_textBox);
            this.Controls.Add(this.taxes_textBox);
            this.Controls.Add(this.taxes_label);
            this.Controls.Add(this.exchangeEuro_textBox);
            this.Controls.Add(this.exchange_textBox);
            this.Controls.Add(this.exchange_label);
            this.Controls.Add(this.coin_textBox);
            this.Controls.Add(this.amount_textBox);
            this.Controls.Add(this.time_textBox);
            this.Controls.Add(this.date_datetimePicker);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.coins_comboBox);
            this.Controls.Add(this.coin_label);
            this.MaximizeBox = false;
            this.Name = "newTransaction_form";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.newTransaction_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coin_label;
        private System.Windows.Forms.ComboBox coins_comboBox;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.DateTimePicker date_datetimePicker;
        private System.Windows.Forms.TextBox time_textBox;
        private System.Windows.Forms.TextBox amount_textBox;
        private System.Windows.Forms.TextBox coin_textBox;
        private System.Windows.Forms.TextBox exchange_textBox;
        private System.Windows.Forms.Label exchange_label;
        private System.Windows.Forms.TextBox exchangeEuro_textBox;
        private System.Windows.Forms.TextBox taxes_textBox;
        private System.Windows.Forms.Label taxes_label;
        private System.Windows.Forms.TextBox taxesEuro_textBox;
        private System.Windows.Forms.Button addTransaction_button;
        private System.Windows.Forms.Button cancel_button;
    }
}