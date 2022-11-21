using System;

namespace CryptoPortfolio
{
    class Coin
    {
        //Variables
        private String name;
        private String symbol;

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
    }
}
