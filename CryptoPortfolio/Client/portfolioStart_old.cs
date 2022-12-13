using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CryptoPortfolio
{
    public partial class portfolioStart_form : Form
    {
        public portfolioStart_form()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) // portfolioStart_form_Load()
        {
            //Verion Output
            versionLabel.Text = "Version 1.0.0.2 - Pre-alpha";
            //Update Dashboard
            UpdateForm();
        }
        
        public void UpdateForm()
        {
            NumberFormatInfo commaDecimal = new CultureInfo("pt-PT", false).NumberFormat;//Number Format
            commaDecimal.NumberDecimalSeparator = ",";                                   //To display a comma
            commaDecimal.NumberDecimalDigits = 2;                                        //2 decimal places
            //Create a DataSet object and bind it to the desired XML
            DataSet portfolio_dataSet = new DataSet();
            portfolio_dataSet.ReadXml(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLportfolioPath);
            //Display XML in DataGridView
            try
            {
                portfolio_dataGridView.DataSource = portfolio_dataSet.Tables[0];
            }
            catch { }
            portfolio_dataGridView.AllowUserToAddRows = false;

            //Dashboard
            double totalExpenses = 0;
            double totalExpensesNT = 0;
            //Get total expensess
            for(int i = 0; i < portfolio_dataGridView.RowCount; i++)
            {
                totalExpenses += Convert.ToDouble(portfolio_dataGridView.Rows[i].Cells["Total"].Value);
                totalExpensesNT += Convert.ToDouble(portfolio_dataGridView.Rows[i].Cells["Cost"].Value);

            }
            portfofioTotal_label.Text = totalExpenses.ToString("N", commaDecimal);
            portfolioLabelNT_label.Text = totalExpensesNT.ToString("N", commaDecimal);
        }

        private void newTransaction_button_Click(object sender, EventArgs e)
        {
            newTransaction_form transactionForm = new newTransaction_form();
            transactionForm.rootPortfolioForm = this;
            transactionForm.ShowDialog();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addCoin_button_Click(object sender, EventArgs e)
        {
            if (validateCoinForm())
            {
                XDocument xmldoc = XDocument.Load(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLcoinPath);
                XElement root = xmldoc.Root;
                //Create a coin
                XElement sub_root = new XElement("Coin");//Create the Head
                sub_root.Add(new XElement("Name", coinName_textbox.Text));
                sub_root.Add(new XElement("Short", coinShort_textBox.Text));
                root.Add(sub_root);//Add the Head to the root
                //Save to XML
                xmldoc.Save(Application.LocalUserAppDataPath + Properties.Settings.Default.XMLcoinPath);
                coinName_textbox.Text = string.Empty;
                coinShort_textBox.Text = string.Empty;
            }
        }

        private bool validateCoinForm()
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (coinName_textbox.Text == string.Empty || coinShort_textBox.Text == string.Empty)
            {
                MessageBox.Show("Não deixe valores em branco!", "Algo correu mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!regex.IsMatch(coinName_textbox.Text) || !regex.IsMatch(coinShort_textBox.Text))
            {
                MessageBox.Show("Usa apenas letras!", "Algo correu mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
