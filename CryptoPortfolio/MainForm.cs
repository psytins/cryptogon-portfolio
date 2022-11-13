using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class MainForm : Form
    {
        String CURRENT_CURRENCY = "€";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //SET FONTS
            accountNameLabel.Font = new Font("Inter Light", 12, FontStyle.Regular);
            portfolioNameLabel.Font = new Font("Inter ExtraLight", 10, FontStyle.Regular);
            valueLabel.Font = new Font("Inter SemiBold", 10, FontStyle.Regular);

            valueCurrencyLabel.Font = new Font("Inter Bold", 20, FontStyle.Regular);
            valueCurrencyLabel.Text = CURRENT_CURRENCY;

            currentValueLabel.Font = new Font("Inter SemiBold", 27, FontStyle.Regular);
            totalInvestedStaticLabel.Font = new Font("Inter SemiBold", 8, FontStyle.Regular);

            totalInvestedCurrencyLabel.Font = new Font("Inter Bold", 14, FontStyle.Regular);
            totalInvestedCurrencyLabel.Text = CURRENT_CURRENCY;

            totalInvestedLabel.Font = new Font("Inter SemiBold", 16, FontStyle.Regular);
      
        }
    }
}
