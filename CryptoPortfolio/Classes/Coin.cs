using System;

namespace CryptoPortfolio
{
    class Coin
    {
        //Variables
        private String name;
        private String symbol;
        private float price; //to use in CurrentAvgPrice

        public Coin(String name,String symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }

        public String Name
        {
            get { return this.name;  }
            set { this.name = value; }
        }
        public String Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }
        public float Price
        { 
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
