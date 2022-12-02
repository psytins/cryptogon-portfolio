using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace CryptoPortfolio
{
    class Portfolio
    {
        //Variables
        private int id;
        private int ownerID;
        private String portfolioName;
        private List<Transaction> transactions;

        //New Portfolio (no transaction)
        public Portfolio(int ownerID, String portfolioName)
        {
            this.transactions = new List<Transaction>();
            this.id = readLastID();
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;       
        }
        public Portfolio(int id, int ownerID, String portfolioName)
        {
            this.transactions = new List<Transaction>();
            this.id = id;
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;
        }

        public int ID
        {
            get { return this.id; }
        }
        public int OwnerID
        {
            get { return this.ownerID; }
        }
        public String PorfolioName
        {
            get { return this.portfolioName; }
            set { this.portfolioName = value; }
        }
        public List<Transaction> Transactions
        {
            get { return this.transactions; }
            set { this.transactions = value; }

        }

        private int readLastID()
        {
            int lastID = XmlHandler.readPortfolioLastID();
            if (lastID == -1)
                return 0;
            else
                return lastID + 1;
        }


        /// <summary>
        /// Calculate the total invested in the current portfolio.
        /// </summary>
        /// <returns>Return a float number corresponding to the total invested or return 0 in case the current portfolio does not have any transactions.</returns>
        public float TotalInvested()
        {
            float totalInvested = 0;

            if(this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    totalInvested += transaction.TotalCost;
                }

                return totalInvested;
            }
        }

        /// <summary>
        /// Calculate the total cost of a coin in the current portfolio.
        /// </summary>
        /// <param name="coin">A Coin object that corresponds to the the coin that is suppose to search.</param>
        /// <returns>Return a float number corresponding to the coin cost or return 0 in case the current portfolio does not have any transactions.</returns>
        public float TotalCostOf(Coin coin)
        {
            float totalCost = 0;

            if (this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    if(transaction.TransactionType == Transaction.Type.Buy && transaction.Coin.Symbol == coin.Symbol)
                        totalCost += transaction.Cost;

                    if (transaction.TransactionType == Transaction.Type.Sell && transaction.Coin.Symbol == coin.Symbol)
                        totalCost -= transaction.Cost; //in the future these values will updated
                }

                return totalCost;
            }
        }

        /// <summary>
        /// Calculate the total cost of all coins in the current portfolio.
        /// </summary>
        /// <returns>Return a float number corresponding to the total coin cost or return 0 in case the current portfolio does not have any transactions.</returns>
        public float TotalCost() {

            float totalCost = 0;

            if (this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    if (transaction.TransactionType == Transaction.Type.Buy)
                        totalCost += transaction.Cost;

                    if (transaction.TransactionType == Transaction.Type.Sell)
                        totalCost -= transaction.Cost;
                }

                return totalCost;
            }

        }
    }
}
