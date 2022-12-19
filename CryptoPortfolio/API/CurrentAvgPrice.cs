using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Binance.Spot;
using Newtonsoft.Json;

namespace CryptoPortfolio
{
    public class CurrentAvgPrice //Current avg price of a coin for the last 5 min
    {
        /// <summary>
        /// Get Market Values from API
        /// </summary>
        /// <returns>returns a Dictionary of type <string,float> corresponding to <symbol,marketPrice></returns>
        public static async Task<Dictionary<string,float>> GetMarketValues()
        {
            Dictionary<string,float> marketValues = new Dictionary<string,float>();
            List<Coin> marketCoins = new List<Coin>();

            HttpClient httpClient = new HttpClient();

            var market = new Market(httpClient);
         
            var result = await market.SymbolPriceTicker();

            marketCoins = JsonConvert.DeserializeObject<List<Coin>>(result);

            //Convertions
            if (Properties.Settings.Default.Currency == "$")
            {
                marketValues = marketCoins.ToDictionary(c => c.Symbol, c => c.Price);
            }
            else if (Properties.Settings.Default.Currency == "€")
            {
                var euroValue = await market.SymbolPriceTicker("EURBUSD");

                float euro = float.Parse(euroValue.Split('"')[7].Replace(".", ",")); // EUR value

                marketValues = marketCoins.ToDictionary(c => c.Symbol, c => c.Price/euro);
            } 
            // ...

            marketCoins = null; //clear from mem

            //make marketValues more small (because there are values that it's not gonna interest).
            //(in future)

            return marketValues;
        }

        /// <summary>
        /// Get a single Market Value from API
        /// </summary>
        /// <returns>returns a float corresponding to the market value from the symbol</returns>
        public static async Task<float> GetMarketValue(string symbol)
        {
            float marketValue;

            HttpClient httpClient = new HttpClient();

            var market = new Market(httpClient);

            var result = await market.SymbolPriceTicker(symbol + "BUSD");

            marketValue = float.Parse(result.Split('"')[7].Replace(".", ",")); // IN USD

            //Convertions
            if (Properties.Settings.Default.Currency == "€")
            {
                var euroValue = await market.SymbolPriceTicker("EURBUSD");

                float euro = float.Parse(euroValue.Split('"')[7].Replace(".", ",")); // EUR value

                marketValue /= euro; // IN EUR

            }

            return marketValue;
        }
    }
}
