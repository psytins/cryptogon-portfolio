using System;
using System.Net.Http;
using System.Threading.Tasks;
using Binance.Spot;

namespace CryptoPortfolio
{
    public class CurrentAvgPrice //Current avg price of a coin for the last 5 min
    {
        public static async Task<float> GetMarketValue(string symbol)
        {
            float marketValue;

            HttpClient httpClient = new HttpClient();

            var market = new Market(httpClient);
         
            var result = await market.SymbolPriceTicker(symbol + "BUSD");

            marketValue = float.Parse(result.Split('"')[7].Replace(".", ",")); // IN USD
            
            //Convertions
            if(Properties.Settings.Default.Currency == "€")
            {
                var euroValue = await market.SymbolPriceTicker("EURBUSD");

                float euro = float.Parse(euroValue.Split('"')[7].Replace(".", ",")); // EUR value

                marketValue = marketValue / euro; // IN EUR

            }

            return marketValue;
        }
    }
}
