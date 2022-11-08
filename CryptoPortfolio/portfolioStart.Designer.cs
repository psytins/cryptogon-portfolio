
namespace CryptoPortfolio
{
    partial class portfolioStart_form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.portfolio_dataGridView = new System.Windows.Forms.DataGridView();
            this.newTransaction_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.information_groupBox = new System.Windows.Forms.GroupBox();
            this.coinbShort_label = new System.Windows.Forms.Label();
            this.coinName_label = new System.Windows.Forms.Label();
            this.addCoin_button = new System.Windows.Forms.Button();
            this.coinShort_textBox = new System.Windows.Forms.TextBox();
            this.coinName_textbox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.portfolioLabelNT_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moneySign_label = new System.Windows.Forms.Label();
            this.portfolioTotalTittle_label = new System.Windows.Forms.Label();
            this.portfofioTotal_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portfolio_dataGridView)).BeginInit();
            this.information_groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portfolio_dataGridView
            // 
            this.portfolio_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portfolio_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.portfolio_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portfolio_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.portfolio_dataGridView.Name = "portfolio_dataGridView";
            this.portfolio_dataGridView.ReadOnly = true;
            this.portfolio_dataGridView.Size = new System.Drawing.Size(862, 490);
            this.portfolio_dataGridView.TabIndex = 1;
            // 
            // newTransaction_button
            // 
            this.newTransaction_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newTransaction_button.Location = new System.Drawing.Point(12, 508);
            this.newTransaction_button.Name = "newTransaction_button";
            this.newTransaction_button.Size = new System.Drawing.Size(116, 45);
            this.newTransaction_button.TabIndex = 2;
            this.newTransaction_button.Text = "Nova Transação";
            this.newTransaction_button.UseVisualStyleBackColor = true;
            this.newTransaction_button.Click += new System.EventHandler(this.newTransaction_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exit_button.Location = new System.Drawing.Point(1020, 508);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(81, 45);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Sair";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // information_groupBox
            // 
            this.information_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.information_groupBox.Controls.Add(this.coinbShort_label);
            this.information_groupBox.Controls.Add(this.coinName_label);
            this.information_groupBox.Controls.Add(this.addCoin_button);
            this.information_groupBox.Controls.Add(this.coinShort_textBox);
            this.information_groupBox.Controls.Add(this.coinName_textbox);
            this.information_groupBox.Controls.Add(this.versionLabel);
            this.information_groupBox.Controls.Add(this.panel2);
            this.information_groupBox.Controls.Add(this.panel1);
            this.information_groupBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_groupBox.Location = new System.Drawing.Point(880, 12);
            this.information_groupBox.Name = "information_groupBox";
            this.information_groupBox.Size = new System.Drawing.Size(221, 490);
            this.information_groupBox.TabIndex = 4;
            this.information_groupBox.TabStop = false;
            this.information_groupBox.Text = "Dashboard";
            // 
            // coinbShort_label
            // 
            this.coinbShort_label.AutoSize = true;
            this.coinbShort_label.Location = new System.Drawing.Point(106, 409);
            this.coinbShort_label.Name = "coinbShort_label";
            this.coinbShort_label.Size = new System.Drawing.Size(42, 15);
            this.coinbShort_label.TabIndex = 9;
            this.coinbShort_label.Text = "Abrev.";
            // 
            // coinName_label
            // 
            this.coinName_label.AutoSize = true;
            this.coinName_label.Location = new System.Drawing.Point(3, 409);
            this.coinName_label.Name = "coinName_label";
            this.coinName_label.Size = new System.Drawing.Size(77, 15);
            this.coinName_label.TabIndex = 8;
            this.coinName_label.Text = "Nova Moeda";
            // 
            // addCoin_button
            // 
            this.addCoin_button.Location = new System.Drawing.Point(163, 427);
            this.addCoin_button.Name = "addCoin_button";
            this.addCoin_button.Size = new System.Drawing.Size(52, 23);
            this.addCoin_button.TabIndex = 7;
            this.addCoin_button.Text = "Adic.";
            this.addCoin_button.UseVisualStyleBackColor = true;
            this.addCoin_button.Click += new System.EventHandler(this.addCoin_button_Click);
            // 
            // coinShort_textBox
            // 
            this.coinShort_textBox.Location = new System.Drawing.Point(109, 427);
            this.coinShort_textBox.Name = "coinShort_textBox";
            this.coinShort_textBox.Size = new System.Drawing.Size(48, 23);
            this.coinShort_textBox.TabIndex = 6;
            // 
            // coinName_textbox
            // 
            this.coinName_textbox.Location = new System.Drawing.Point(6, 427);
            this.coinName_textbox.Name = "coinName_textbox";
            this.coinName_textbox.Size = new System.Drawing.Size(100, 23);
            this.coinName_textbox.TabIndex = 5;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.versionLabel.Location = new System.Drawing.Point(87, 468);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(128, 13);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version 1.0.0.0 - Pre-alpha";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.portfolioLabelNT_label);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 43);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // portfolioLabelNT_label
            // 
            this.portfolioLabelNT_label.AutoSize = true;
            this.portfolioLabelNT_label.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfolioLabelNT_label.ForeColor = System.Drawing.Color.Black;
            this.portfolioLabelNT_label.Location = new System.Drawing.Point(83, 10);
            this.portfolioLabelNT_label.Name = "portfolioLabelNT_label";
            this.portfolioLabelNT_label.Size = new System.Drawing.Size(93, 23);
            this.portfolioLabelNT_label.TabIndex = 3;
            this.portfolioLabelNT_label.Text = "999999,23";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sem Taxas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.moneySign_label);
            this.panel1.Controls.Add(this.portfolioTotalTittle_label);
            this.panel1.Controls.Add(this.portfofioTotal_label);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 87);
            this.panel1.TabIndex = 0;
            // 
            // moneySign_label
            // 
            this.moneySign_label.AutoSize = true;
            this.moneySign_label.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneySign_label.ForeColor = System.Drawing.Color.DimGray;
            this.moneySign_label.Location = new System.Drawing.Point(13, 35);
            this.moneySign_label.Name = "moneySign_label";
            this.moneySign_label.Size = new System.Drawing.Size(29, 33);
            this.moneySign_label.TabIndex = 2;
            this.moneySign_label.Text = "€";
            // 
            // portfolioTotalTittle_label
            // 
            this.portfolioTotalTittle_label.AutoSize = true;
            this.portfolioTotalTittle_label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfolioTotalTittle_label.Location = new System.Drawing.Point(3, 10);
            this.portfolioTotalTittle_label.Name = "portfolioTotalTittle_label";
            this.portfolioTotalTittle_label.Size = new System.Drawing.Size(119, 19);
            this.portfolioTotalTittle_label.TabIndex = 0;
            this.portfolioTotalTittle_label.Text = "Despesas Totais";
            // 
            // portfofioTotal_label
            // 
            this.portfofioTotal_label.AutoSize = true;
            this.portfofioTotal_label.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfofioTotal_label.ForeColor = System.Drawing.Color.Black;
            this.portfofioTotal_label.Location = new System.Drawing.Point(34, 29);
            this.portfofioTotal_label.Name = "portfofioTotal_label";
            this.portfofioTotal_label.Size = new System.Drawing.Size(158, 39);
            this.portfofioTotal_label.TabIndex = 1;
            this.portfofioTotal_label.Text = "999999,23";
            // 
            // portfolioStart_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 561);
            this.Controls.Add(this.information_groupBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.newTransaction_button);
            this.Controls.Add(this.portfolio_dataGridView);
            this.MaximizeBox = false;
            this.Name = "portfolioStart_form";
            this.Text = "CryptoGon - Portfólio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portfolio_dataGridView)).EndInit();
            this.information_groupBox.ResumeLayout(false);
            this.information_groupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView portfolio_dataGridView;
        private System.Windows.Forms.Button newTransaction_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.GroupBox information_groupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label portfofioTotal_label;
        private System.Windows.Forms.Label portfolioTotalTittle_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label portfolioLabelNT_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneySign_label;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label coinName_label;
        private System.Windows.Forms.Button addCoin_button;
        private System.Windows.Forms.TextBox coinShort_textBox;
        private System.Windows.Forms.TextBox coinName_textbox;
        private System.Windows.Forms.Label coinbShort_label;
    }
}

