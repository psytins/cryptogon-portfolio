using System;

namespace CryptoPortfolio
{
    class Transaction
    {
        //Enum - Type
        public enum Type { Buy = 1, Sell = 0 }
        //Variables - Buy
        private Type type;
        private String coin; //temp string
        private String date;
        private float amount;
        private float coinPrice;
        private float cost;
        private float fee;
        private float totalCost;
        private String notes;

        public Transaction(Type type, String coin, String date, float amount, float coinPrice, float cost, float fee, float totalCost, String notes)
        {
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

        public Type TransactionType
        {
            get { return this.type; }
        }
        public String Coin {

            get { return this.coin; }
            set { this.coin = value; }
        }
        public String Date
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
        public String Notes
        {

            get { return this.notes; }
            set { this.notes = value; }
        }

    }
}
