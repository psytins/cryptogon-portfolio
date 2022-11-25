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
        private float totalInvested;
        private List<Transaction> transactions;

        //New Portfolio (no transaction)
        public Portfolio(int ownerID, String portfolioName)
        {
            this.transactions = new List<Transaction>();
            this.id = readLastID();
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;
            this.totalInvested = CalculateTotalInvested();           
        }
        public Portfolio(int id, int ownerID, String portfolioName)
        {
            this.transactions = new List<Transaction>();
            this.id = id;
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;
            this.totalInvested = CalculateTotalInvested();
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
        public float TotalInvested
        {

            get { return this.totalInvested; }
            set { this.totalInvested = value; }
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

        private float CalculateTotalInvested()
        {
            float totalInvested = 0;

            if(this.transactions.Count == 0)
                return 0;
            else
            {
                foreach (Transaction transaction in this.transactions)
                {
                    totalInvested += transaction.TotaLCost;
                }

                return totalInvested;
            }
        }
    }
}
