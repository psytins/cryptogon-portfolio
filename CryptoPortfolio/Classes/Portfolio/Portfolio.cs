using System;
using System.Collections.Generic;

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
        public Portfolio(int ownerID, String portfolioName, float totalInvested)
        {
            this.transactions = new List<Transaction>();
            this.id = readLastID();
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;
            this.totalInvested = totalInvested;           
        }
        public Portfolio(int id, int ownerID, String portfolioName, float totalInvested)
        {
            this.transactions = new List<Transaction>();
            this.id = id;
            this.ownerID = ownerID;
            this.portfolioName = portfolioName;
            this.totalInvested = totalInvested;
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
    }
}
