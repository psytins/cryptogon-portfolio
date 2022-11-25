using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CryptoPortfolio
{
    class XmlHandler
    {
        // WRITE #########################################################
        // ###############################################################
        public static void writeCoin(Coin coinToRegister) { }

        public static void writeUser(User userToRegister) 
        {
            XDocument xmldoc  = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLuserPath);
            XElement root     = xmldoc.Root;
            //Create a user
            XElement sub_root = new XElement("User");//Create the Head
            sub_root          .Add(new XElement("ID", userToRegister.ID));
            sub_root          .Add(new XElement("FirstName", userToRegister.FirstName));
            sub_root          .Add(new XElement("LastName", userToRegister.LastName));
            sub_root          .Add(new XElement("EmailAddress", userToRegister.EmailAddress));
            sub_root          .Add(new XElement("Password", userToRegister.Password)); //not encrypted
            root              .Add(sub_root);//Add the Head to the root
            //Save to XML
            xmldoc            .Save(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLuserPath);
        }

        public static void writePortfolio(Portfolio portfolioToRegister) 
        {
            NumberFormatInfo commaDecimal = new CultureInfo("pt-PT", false).NumberFormat; //Number Format, to display commas instead of points
            commaDecimal.NumberDecimalSeparator = ",";

            XDocument xmldoc    = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);
            XElement root       = xmldoc.Root;
            //Create a Portfolio
            XElement sub_root   = new XElement("Portfolio");//Create the Head
            sub_root            .Add(new XElement("ID", portfolioToRegister.ID));
            sub_root            .Add(new XElement("OwnershipID", portfolioToRegister.OwnerID));
            sub_root            .Add(new XElement("PortfolioName", portfolioToRegister.PorfolioName));
            sub_root            .Add(new XElement("TotalInvested", portfolioToRegister.TotalInvested));

            //Add Transactions -----------
            XElement sub_root_transactions = new XElement("TransactionHistory");//Create the Head for transactions

            foreach(Transaction transactions in portfolioToRegister.Transactions)
            {
                XElement sub_root_transaction   = new XElement("Transaction");//Create the Head for each transaction
                sub_root_transaction            .Add(new XElement("Type", ((int)transactions.TransactionType)));
                sub_root_transaction            .Add(new XElement("Coin", transactions.Coin.Name));
                sub_root_transaction            .Add(new XElement("Date", transactions.Date));
                sub_root_transaction            .Add(new XElement("Amount", transactions.Amount.ToString("N", commaDecimal)));
                sub_root_transaction            .Add(new XElement("CoinPrice", transactions.CoinPrice.ToString("N", commaDecimal)));
                sub_root_transaction            .Add(new XElement("Cost", transactions.Cost.ToString("N", commaDecimal)));
                sub_root_transaction            .Add(new XElement("Fee", transactions.Fee.ToString("N", commaDecimal)));
                sub_root_transaction            .Add(new XElement("TotalCost", transactions.TotaLCost.ToString("N", commaDecimal)));
                sub_root_transaction            .Add(new XElement("Notes", transactions.Notes));
                sub_root_transactions           .Add(sub_root_transaction);
            }

            sub_root.Add(sub_root_transactions);

            root.Add(sub_root);//Add the Head to the root
            
            xmldoc.Save(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath); //Save to XML
        }

        public static void writeTransaction(Transaction transactionToRegister, Portfolio respectivePortfolio)
        {
            NumberFormatInfo commaDecimal = new CultureInfo("pt-PT", false).NumberFormat; //Number Format, to display commas instead of points
            commaDecimal.NumberDecimalSeparator = ",";

            XDocument xmldoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);
            XElement root = xmldoc.Root;

            XElement sub_root = xmldoc.Descendants("Portfolio").Where(x => x.Element("ID").Value == respectivePortfolio.ID.ToString()).First();
            XElement sub_root_transactions = sub_root.Descendants("TransactionHistory").First();


            XElement sub_root_transaction   = new XElement("Transaction");//Create the Head for the transaction
            sub_root_transaction            .Add(new XElement("Type", ((int)transactionToRegister.TransactionType)));
            sub_root_transaction            .Add(new XElement("Coin", transactionToRegister.Coin.Name));
            sub_root_transaction            .Add(new XElement("Date", transactionToRegister.Date));
            sub_root_transaction            .Add(new XElement("Amount", transactionToRegister.Amount.ToString("N",commaDecimal)));
            sub_root_transaction            .Add(new XElement("CoinPrice", transactionToRegister.CoinPrice.ToString("N", commaDecimal)));
            sub_root_transaction            .Add(new XElement("Cost", transactionToRegister.Cost.ToString("N", commaDecimal)));
            sub_root_transaction            .Add(new XElement("Fee", transactionToRegister.Fee.ToString("N", commaDecimal)));
            sub_root_transaction            .Add(new XElement("TotalCost", transactionToRegister.TotaLCost.ToString("N", commaDecimal)));
            sub_root_transaction            .Add(new XElement("Notes", transactionToRegister.Notes));
            sub_root_transactions           .Add(sub_root_transaction);

            xmldoc.Save(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath); //Save to XML

        }

        // READ #########################################################
        // ###############################################################
        public static List<Coin> readAllCoins() {

            //Load xml
            XDocument xdoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLcoinPath);

            //Run query
            var coinQuery = from coins in xdoc.Descendants("Coin")
                            select new Coin(
                                coins.Element("Name").Value,
                                coins.Element("Short").Value);

            return coinQuery.ToList();
        }

        public static Coin readCoin(string name)
        {
            //Load xml
            XDocument xdoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLcoinPath);

            //Run query
            var coinQuery = from coins in xdoc.Descendants("Coin").Where(x => x.Element("Name").Value == name)
                            select new Coin(
                                coins.Element("Name").Value,
                                coins.Element("Short").Value);

            return coinQuery.First();
        }

        public static User readUser(string email) 
        {
            //Load xml
            XDocument xdoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLuserPath);

            //Run query to select all User objects
            var userQuery = from user in xdoc.Descendants("User")
                           select new User(
                               int.Parse(user.Element("ID").Value),
                               user.Element("FirstName").Value,
                               user.Element("LastName").Value,
                               user.Element("EmailAddress").Value,
                               user.Element("Password").Value);

            //Go throught each user objects
            foreach (User users in userQuery)
            {
                if (users.EmailAddress == email) //return the correct user
                    return users;
            }

            return null; //return null if there is no user with the respective email
        }

        public static int readUserLastID()
        {
            //Load xml
            XDocument xdoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLuserPath);

            //Run query to select all IDS
            var idsQuery = from user in xdoc.Descendants("User")
                             select user.Element("ID").Value;

            if (idsQuery.Count() == 0)
                return -1;
            else
                return int.Parse(idsQuery.Last<string>());
        }

        public static List<Portfolio> readPortfolio(int ownerID) {

            List<Portfolio> finalList = new List<Portfolio>();

            //Load xml
            XDocument xdoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);

            //Run query to select all Portfolio objects
            var portfolioQuery = from portfolio in xdoc.Descendants("Portfolio")
                                 select new Portfolio(
                                     int.Parse(portfolio.Element("ID").Value),
                                     int.Parse(portfolio.Element("OwnershipID").Value),
                                     portfolio.Element("PortfolioName").Value);


            //Go throught each portfolio objects
            foreach (Portfolio portfolios in portfolioQuery)
            {
                var transactionQuery = from transactions in xdoc.Descendants("Portfolio").Where(x => x.Element("ID").Value == portfolios.ID.ToString()).Descendants("TransactionHistory").Descendants("Transaction")
                                       select new Transaction(
                                               int.Parse(transactions.Element("Type").Value) == 1 ? Transaction.Type.Buy : Transaction.Type.Sell,
                                               readCoin(transactions.Element("Coin").Value),                                   
                                               transactions.Element("Date").Value,
                                               float.Parse(transactions.Element("Amount").Value),
                                               float.Parse(transactions.Element("CoinPrice").Value),
                                               float.Parse(transactions.Element("Cost").Value),
                                               float.Parse(transactions.Element("Fee").Value),
                                               float.Parse(transactions.Element("TotalCost").Value),
                                               transactions.Element("Notes").Value);
                                        

                portfolios.Transactions = transactionQuery.ToList();

                if (portfolios.OwnerID == ownerID)
                {
                    finalList.Add(portfolios);
                }
            }

            return finalList;
        }

        public static int readPortfolioLastID()
        {
            //Load xml
            XDocument xdoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);

            //Run query to select all IDS
            var idsQuery = from portfolio in xdoc.Descendants("Portfolio")
                           select portfolio.Element("ID").Value;

            if (idsQuery.Count() == 0)
                return -1;
            else
                return int.Parse(idsQuery.Last<string>());
        }


        // UPDATE #########################################################
        // ###############################################################


        // DELETE #########################################################
        // ###############################################################
    }
}
