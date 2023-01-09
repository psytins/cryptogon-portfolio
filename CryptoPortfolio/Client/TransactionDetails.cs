using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPortfolio.Client
{
    public partial class TransactionDetails : Form
    {
        /// <summary>
        /// The current coin that the current user is using in the transaction.
        /// </summary>
        private Coin CURRENT_COIN;
        /// <summary>
        /// The current portfolio that the current user is adding the transaction.
        /// </summary>
        private Portfolio CURRENT_PORTFOLIO;
        private Transaction CURRENT_TRANSACTION;
        private int TRANSACTION_ID;
        internal void SetPortfolio(Portfolio portfolio, int transactionID)
        {
            this.CURRENT_PORTFOLIO   = portfolio;
            this.TRANSACTION_ID      = transactionID;
            this.CURRENT_TRANSACTION = CURRENT_PORTFOLIO.GetTransaction(transactionID);
        }

        public TransactionDetails()
        {
            InitializeComponent();
        }
        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            transactionNumLabel.Text = "#" + TRANSACTION_ID;
            transactionTypeLabel.Text = CURRENT_TRANSACTION.TransactionType.ToString();

            dateLabel.Text = CURRENT_TRANSACTION.Date.ToShortDateString();
            timeLabel.Text = CURRENT_TRANSACTION.Date.ToLongTimeString();

            boughtLabel.Text = "You bought " + CURRENT_TRANSACTION.Amount.ToString("0.00") + " " + CURRENT_TRANSACTION.Coin.Name;
            coinPriceLabel.Text = "Coin price of " + CURRENT_TRANSACTION.Coin.Name + " was " + CURRENT_TRANSACTION.CoinPrice.ToString("0.00" + Properties.Settings.Default.Currency);
            feesLabel.Text = "You paid " + CURRENT_TRANSACTION.Fee.ToString("0.00" + Properties.Settings.Default.Currency) + " of fees.";
            totalTransactionLabel.Text = CURRENT_TRANSACTION.TotalCost.ToString("0.00" + Properties.Settings.Default.Currency);

            _ = CURRENT_TRANSACTION.Notes == string.Empty ? notesTextBox.Text = "Empty notes." : notesTextBox.Text = CURRENT_TRANSACTION.Notes;

        }
        private void CloseForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

   
    }
}
