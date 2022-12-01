using System;

namespace CryptoPortfolio
{
    class Transaction
    {
        //Enum - Type
        public enum Type { Buy = 1, Sell = 0 }
        //Variables - Buy
        private int id;
        private Type type;
        private Coin coin;
        private DateTime date;
        private float amount;
        private float coinPrice;
        private float cost;
        private float fee;
        private float totalCost;
        private string notes;

        public Transaction(Type type, Coin coin, DateTime date, float amount, float coinPrice, float cost, float fee, float totalCost, string notes)
        {
            this.id = this.readLastID();
            this.type = type;
            this.coin = coin;
            this.date = date;
            this.amount = amount;
            this.coinPrice = coinPrice;
            this.cost = cost;
            this.fee = fee;
            this.totalCost = totalCost;
            this.notes = notes;
        }

        public Transaction(int id, Type type, Coin coin, DateTime date, float amount, float coinPrice, float cost, float fee, float totalCost, string notes)
        {
            this.id = id;
            this.type = type;
            this.coin = coin;
            this.date = date;
            this.amount = amount;
            this.coinPrice = coinPrice;
            this.cost = cost;
            this.fee = fee;
            this.totalCost = totalCost;
            this.notes = notes;
        }
        public int ID
        {
            get { return this.id; }
        }
        public Type TransactionType
        {
            get { return this.type; }
        }
        public Coin Coin {

            get { return this.coin; }
            set { this.coin = value; }
        }
        public DateTime Date
        {

            get { return this.date; }
            set { this.date = value; }
        }
        public float Amount
        {

            get { return this.amount; }
            set { this.amount = value; }
        }
        public float CoinPrice
        {

            get { return this.coinPrice; }
            set { this.coinPrice = value; }
        }
        public float Cost
        {

            get { return this.cost; }
            set { this.cost = value; }
        }
        public float Fee
        {

            get { return this.fee; }
            set { this.fee = value; }
        }
        public float TotaLCost
        {

            get { return this.totalCost; }
            set { this.totalCost = value; }
        }
        public string Notes
        {

            get { return this.notes; }
            set { this.notes = value; }
        }

        private int readLastID()
        {
            int lastID = XmlHandler.readTransactionLastID();
            if (lastID == -1)
                return 0;
            else
                return lastID + 1;
        }
    }
}
