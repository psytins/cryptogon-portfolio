using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CryptoPortfolio.Classes
{
    class XmlHandler
    {
        public XmlHandler() { }

        //Write
        public void writeCoin(Coin coinToRegister) { }
        public void writeUser(User userToRegister) 
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
        public void writePortfolio(Portfolio portfolioToRegister) { }
        //Read
        public void readCoin(int coinID) { }
        public void readUser(int userID) 
        {


        
        }
        public void readPortfolio(int portfolioID) { }

        //Update...
    }
}
