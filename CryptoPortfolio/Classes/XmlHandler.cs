using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CryptoPortfolio.Classes
{
    class XmlHandler
    {
        //Write ------------------------------
        public static void writeCoin(Coin coinToRegister) { }

        public static void writeUser(User userToRegister) 
        {
            XDocument xmldoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLuserPath);
            XElement root = xmldoc.Root;
            //Create a user
            XElement sub_root = new XElement("User");//Create the Head
            sub_root.Add(new XElement("ID", userToRegister.ID));
            sub_root.Add(new XElement("FirstName", userToRegister.FirstName));
            sub_root.Add(new XElement("LastName", userToRegister.LastName));
            sub_root.Add(new XElement("EmailAddress", userToRegister.EmailAddress));
            sub_root.Add(new XElement("Password", userToRegister.Password));
            root.Add(sub_root);//Add the Head to the root
            //Save to XML
            xmldoc.Save(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLuserPath);
        }

        public static void writePortfolio(Portfolio portfolioToRegister) { }

        //Read ----------------------
        // public Coin readCoin(string coinName) { }

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

        //public void readPortfolio(int portfolioID) { }

        //Update...
    }
}
