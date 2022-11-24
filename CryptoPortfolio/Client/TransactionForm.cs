﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            selectCoinPanel.BringToFront(); //Get always the coin selection first
            //load all coins in the coin panel
            LoadCoins();

        }

        private void LoadCoins()
        {
            int y_location = 0;

            foreach(Coin coin in XmlHandler.readAllCoins()) //Go throught all existant coins
            {
                Button tempButton = new Button();

                tempButton.Text = coin.Name;
                tempButton.Tag = coin;
                //Design attributes
                tempButton.SetBounds(5, y_location, 329, 32);
                tempButton.BackgroundImage = Properties.Resources.coinButton;
                tempButton.BackgroundImageLayout = ImageLayout.None;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.ForeColor = Color.FromArgb(39, 76, 119);
                tempButton.TextAlign = ContentAlignment.MiddleLeft;
                //add the event listener
                tempButton.MouseClick += new MouseEventHandler(CoinSelected);
                //add it to the coin panel
                coinPanel.Controls.Add(tempButton);

                y_location += 35;
            }
        }
        
        private void CoinSelected(object sender, EventArgs e)
        {
            Button selectedButton = (Button) sender;

            Coin selectedCoin = selectedButton.Tag as Coin;

            LoadAddTransaction(selectedCoin);            
        }

        private void GoBack(object sender, EventArgs e)
        {
            selectCoinPanel.BringToFront();
        }

        private void LoadAddTransaction(Coin coin)
        {
            addTransactionPanel.BringToFront();
            amountTextBox       .Text = string.Empty;
            pricePerCoinTextBox .Text = string.Empty;
            feeTextBox          .Text = string.Empty;
            notesTextBox        .Text = string.Empty;
            dayTextBox          .Text = string.Empty;
            monthComboBox       .SelectedIndex = 0;    
            yearTextBox         .Text = string.Empty;
            hourTextBox         .Text = string.Empty;
            minuteTextBox       .Text = string.Empty;
            secondTextBox       .Text = string.Empty;

            //Set up labels
            coinShortLabel.Text = coin.Symbol;
            currencyLabel.Text = Properties.Settings.Default.Currency;
            currencyFeeLabel.Text = Properties.Settings.Default.Currency;
            currencyTotalSpent.Text = Properties.Settings.Default.Currency;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
