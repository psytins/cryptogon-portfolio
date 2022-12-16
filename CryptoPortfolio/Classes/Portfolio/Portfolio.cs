using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CryptoPortfolio
{
    class Portfolio
    {
        //Variables
        private int id;
        private int ownerID;
        private String portfolioName;
        private List<Transaction> transactions;
        //Temp Variables
        private float totalCost;
        private Dictionary<Coin, float> totalCostOf;


        //New Portfolio (no transaction)
        public Portfolio(int ownerID, String portfolioName)
        {
            this.transactions = new List<Transaction>();
            this.id = readLastID();
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;

            this.totalCost = 0;
            this.totalCostOf = new Dictionary<Coin, float>();
        }
        public Portfolio(int id, int ownerID, String portfolioName)
        {
            this.transactions = new List<Transaction>();
            this.id = id;
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;

            this.totalCost = 0;
            this.totalCostOf = new Dictionary<Coin, float>();
        }

        //Temp ---
        public float TotalCost
        {
            get { return this.totalCost; }
            set { this.totalCost = value; }
        }

        public Dictionary<Coin,float> TotalCostOf
        {
            get { return this.totalCostOf; }
            set { this.totalCostOf = value; }
        }

        //----
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
        public async Task<float> GetTotalCostOf(Coin coin)
        {
            float totalCost = 0;

            if (this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    if (transaction.TransactionType == Transaction.Type.Buy && transaction.Coin.Symbol == coin.Symbol)
                        totalCost += await this.CoinMarketValue(coin, transaction.Amount);

                    if (transaction.TransactionType == Transaction.Type.Sell && transaction.Coin.Symbol == coin.Symbol)
                        totalCost -= await this.CoinMarketValue(coin, transaction.Cost); //Here cost is the cost of the sell in Coins (not in fiat)
                }

                return totalCost;
            }
        }

        /// <summary>
        /// Calculate the total cost of all coins in the current portfolio.
        /// </summary>
        /// <returns>Return a float number corresponding to the total coin cost or return 0 in case the current portfolio does not have any transactions.</returns>
        public async Task<float> GetTotalCost() {

            float totalCost = 0;

            if (this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    if (transaction.TransactionType == Transaction.Type.Buy)
                        totalCost += await this.CoinMarketValue(transaction.Coin, transaction.Amount);

                    if (transaction.TransactionType == Transaction.Type.Sell)
                        totalCost -= await this.CoinMarketValue(transaction.Coin, transaction.Cost); //Here cost is the cost of the sell in Coins (not in fiat)
                }

                return totalCost;
            }

        }

        /// <summary>
        /// Calculate the total amount of a coin in the current portfolio.
        /// </summary>
        /// <param name="coin">A Coin object that corresponds to the the coin that is suppose to search.</param>
        /// <returns>Return a float number corresponding to the coin amount or return 0 in case the current portfolio does not have any transactions.</returns>
        public float TotalAmountOf(Coin coin)
        {
            float totalAmount = 0;

            if (this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    if (transaction.TransactionType == Transaction.Type.Buy && transaction.Coin.Symbol == coin.Symbol)
                        totalAmount += transaction.Amount;

                    if (transaction.TransactionType == Transaction.Type.Sell && transaction.Coin.Symbol == coin.Symbol)
                        totalAmount -= transaction.Cost;
                }

                return totalAmount;
            }
        }

        /// <summary>
        /// Get a Coin object with symbol.
        /// </summary>
        /// <param name="symbol">The symbol of the coin to search.</param>
        /// <returns>Return a Coin object corresponding to the search or return null in case the current portfolio does not have any transactions or in case the seach fails.</returns>
        public Coin GetCoinFromSymbol(string symbol)
        {
            foreach (Transaction transaction in this.transactions)
            {
                if (transaction.Coin.Symbol == symbol)
                    return transaction.Coin;
            }

            return null;
        }

        public async Task<float> CoinMarketValue(Coin coin, float amount)
        {
            if (coin == null)
                return 0;

            float marketValue = await CurrentAvgPrice.GetMarketValue(coin.Symbol);

            float value = marketValue * amount;

            return value;
        }
    }
}
