﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class TransactionForm : Form
    {
        /// <summary>
        /// The current coin that the current user is using in the transaction.
        /// </summary>
        private Coin CURRENT_COIN;
        /// <summary>
        /// The current portfolio that the current user is adding the transaction.
        /// </summary>
        private Portfolio CURRENT_PORTFOLIO;
        private int CURRENT_PORTFOLIO_INDEX;
        internal void SetPortfolio(Portfolio portfolio, int index)
        {
            this.CURRENT_PORTFOLIO       = portfolio;
            this.CURRENT_PORTFOLIO_INDEX = index;
        }

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

                tempButton.BackgroundImage           = Properties.Resources.coinButton;
                tempButton.BackgroundImageLayout     = ImageLayout.None;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.FlatStyle                 = FlatStyle.Flat;
                tempButton.ForeColor                 = Color.FromArgb(39, 76, 119);
                tempButton.TextAlign                 = ContentAlignment.MiddleLeft;

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

        private async void LoadAddTransaction(Coin coin)
        {
            CURRENT_COIN = coin;

            addTransactionPanel.BringToFront();
            timePicker.Text = DateTime.Now.ToLongTimeString();
            amountNum           .Value = 0;
            float pricePerCoin         = await CurrentAvgPrice.GetMarketValue(coin.Symbol);
            pricePerCoinNum.Value      = decimal.Parse(pricePerCoin.ToString());
            feeNum              .Value = 0;
            notesTextBox        .Text  = string.Empty;

            //Set up labels
            coinShortLabel.Text      = coin.Symbol + " |";
            currencyLabel.Text       = Properties.Settings.Default.Currency;
            currencyFeeLabel.Text    = Properties.Settings.Default.Currency;
            currencyTotalSpent.Text  = Properties.Settings.Default.Currency;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CalculateTotal(object sender, EventArgs e) //bug: when numeric is leaved empty, this don't trigger. 
        {
            decimal newValue = (amountNum.Value * pricePerCoinNum.Value) + feeNum.Value;
            totalSpentLabel.Text = newValue.ToString(); //Show a total updated
        }

        private void addTransactionButon_Click(object sender, EventArgs e) //bug: time can be inputed in the wrong way. (seconds||minutes above 60)
        {
            if (ValidateTransaction())
            {
                //Buy -------------
                if (sellPanel.Visible == false)
                {
                    Transaction tempTransaction = new Transaction(
                        Transaction.Type.Buy,
                        CURRENT_COIN,
                        DateTime.Parse(datePicker.Value.ToShortDateString() + " " + timePicker.Value.ToLongTimeString()),
                        (float)amountNum.Value,
                        (float)pricePerCoinNum.Value,
                        (float.Parse(totalSpentLabel.Text) - (float)feeNum.Value),
                        (float)feeNum.Value,
                        float.Parse(totalSpentLabel.Text),
                        notesTextBox.Text);

                    XmlHandler.writeTransaction(tempTransaction, CURRENT_PORTFOLIO);

                    ((MainForm)Owner).ResetAndUpdatePortfolio();

                    this.Dispose();
                }
                //Sell -------------
                else if(sellPanel.Visible == true)
                {
                    Transaction tempTransaction = new Transaction(
                        Transaction.Type.Sell,
                        CURRENT_COIN,
                        DateTime.Parse(datePicker.Value.ToShortDateString() + " " + timePicker.Value.ToLongTimeString()),
                        (float)amountNum.Value,
                        (float)pricePerCoinNum.Value,
                        (float.Parse(totalSpentLabel.Text) - (float)feeNum.Value),
                        (float)feeNum.Value,
                        float.Parse(totalSpentLabel.Text),
                        notesTextBox.Text);

                    XmlHandler.writeTransaction(tempTransaction, CURRENT_PORTFOLIO);

                    ((MainForm)Owner).ResetAndUpdatePortfolio();

                    this.Dispose();
                }
            }
        }

        private bool ValidateTransaction()
        {
            //Reset error labels
            amountRequiredLabel.Visible = false;
            pricePerCoinRequiredLabel.Visible = false;

            if (amountNum.Value == decimal.Zero)
            {
                amountRequiredLabel.Visible = true;
                return false;
            }
            else if (pricePerCoinNum.Value == decimal.Zero)
            {
                pricePerCoinRequiredLabel.Visible = true;
                return false;
            }
            else if(sellPanel.Visible == true && float.Parse(amountNum.Value.ToString()) > CURRENT_PORTFOLIO.TotalAmountOf(CURRENT_COIN))
            {
                MessageBox.Show("You don't have that amount of " + CURRENT_COIN.Name + " to sell!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void sellButon_Click(object sender, EventArgs e)
        {
            buyButton.BackgroundImage = Properties.Resources.buyTab_un;
            sellButon.BackgroundImage = Properties.Resources.sellTab;
            sellPanel.Visible = true;
            totalLabel.Text = "Total Earned";
            amountLabel.Text = "Amount to Sell";
           
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            sellButon.BackgroundImage = Properties.Resources.sellTab_un;
            buyButton.BackgroundImage = Properties.Resources.buyTab;
            sellPanel.Visible = false;
            totalLabel.Text = "Total Spent";
            amountLabel.Text = "Amount";

        }
    }
}
