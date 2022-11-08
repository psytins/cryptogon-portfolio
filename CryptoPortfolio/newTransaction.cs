using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CryptoPortfolio
{
    public partial class newTransaction_form : Form
    {
        List<Coin> CoinList = new List<Coin>();
        public portfolioStart_form rootPortfolioForm;

        public newTransaction_form()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void newTransaction_form_Load(object sender, EventArgs e)
        {
            //Load TextBoxes
            time_textBox.Text = "00:00:00";
            exchangeEuro_textBox.Text = "€"; 
            taxesEuro_textBox.Text = "€";

            //Create Coin Objects 
            //Read XML
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLcoinPath, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Coin");
            String tempName;
            String tempSymbol;
            Coin tempCoin;
            for (int i = 0; i < xmlnode.Count; i++)
            {
                tempName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                tempSymbol = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                tempCoin = new Coin(tempName, tempSymbol); //Create a temp object 
                CoinList.Add(tempCoin);//Add the temp object to the global list
                tempCoin = null; //clear the temp object
            }
            //With the CoinList created, add it to the combo Box
            foreach(Coin coins in CoinList)
            {
                coins_comboBox.Items.Add(coins.Name);
            }
            try
            {
                coins_comboBox.SelectedIndex = 0; //Show right away in the combo box
            }
            catch 
            { 
                coins_comboBox.Items.Add("Não existem moedas. Volte atrás e registe.");
                coins_comboBox.SelectedIndex = 0;
            }
            fs.Close(); //Close file
        }

        private void time_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(time_textBox.Text == "00:00:00")
                time_textBox.Text = "";
        }

        private void time_textBox_MouseLeave(object sender, EventArgs e)
        {
            if(time_textBox.Text == "")
                time_textBox.Text = "00:00:00";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void coins_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coin_textBox.Text = CoinList.ToArray()[coins_comboBox.SelectedIndex].Symbol;
            }
            catch { coin_textBox.Text = " - "; }
        }

        private void addTransaction_button_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                double cost = Convert.ToSingle(amount_textBox.Text) * Convert.ToSingle(exchange_textBox.Text);
                double total = cost + Convert.ToSingle(taxes_textBox.Text);

                NumberFormatInfo commaDecimal = new CultureInfo("pt-PT", false).NumberFormat;       //Number Format
                NumberFormatInfo hightDecimalNumbers = new CultureInfo("pt-PT", false).NumberFormat;//Number Format
                commaDecimal.NumberDecimalSeparator = ",";                                          //To display a comma
                commaDecimal.NumberDecimalDigits = 2;
                hightDecimalNumbers.NumberDecimalSeparator = ",";
                hightDecimalNumbers.NumberDecimalDigits = 5;

                XDocument xmldoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);
                XElement root = xmldoc.Root;
                //Create a transaction
                XElement sub_root = new XElement("Transaction");//Create the Head
                sub_root.Add(new XElement("Type", "BUY")); //At this point, is always BUY
                sub_root.Add(new XElement("Coin", coins_comboBox.SelectedItem.ToString()));
                sub_root.Add(new XElement("Date", date_datetimePicker.Value.Date.ToString()));
                sub_root.Add(new XElement("Time", time_textBox.Text));
                sub_root.Add(new XElement("Amount", Convert.ToDouble(amount_textBox.Text).ToString("N", hightDecimalNumbers)));
                sub_root.Add(new XElement("Price", Convert.ToDouble(exchange_textBox.Text).ToString("N", hightDecimalNumbers)));
                sub_root.Add(new XElement("Cost", cost.ToString("N", commaDecimal)));
                sub_root.Add(new XElement("Adicional", Convert.ToDouble(taxes_textBox.Text).ToString("N", commaDecimal)));
                sub_root.Add(new XElement("Total", total.ToString("N", commaDecimal)));
                root.Add(sub_root);//Add the Head to the root
                //Save to XML
                xmldoc.Save(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);
                //Update Main Form and Close this Form
                rootPortfolioForm.UpdateForm();
                this.Dispose();
            }
        }

        private bool validateForm()
        {
            Regex regex = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(,)\d+)?$");
            if (amount_textBox.Text == string.Empty || exchange_textBox.Text == string.Empty || taxes_textBox.Text == string.Empty)
            {
                MessageBox.Show("Não deixe valores em branco!", "Algo correu mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!regex.IsMatch(amount_textBox.Text) || !regex.IsMatch(exchange_textBox.Text) || !regex.IsMatch(taxes_textBox.Text))
            {
                MessageBox.Show("Use números e vírgulas apenas!", "Algo correu mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((String)coins_comboBox.SelectedItem == "Não existem moedas. Volte atrás e registe.")
            {
                MessageBox.Show("Não existem moedas. Volte atrás e registe.", "Algo correu mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
