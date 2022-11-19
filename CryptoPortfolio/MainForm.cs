using CryptoPortfolio;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class MainForm : Form
    {
        //Lets the mouse move the form withou border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // -------------------
        //Global Variables
        private String CURRENT_CURRENCY = "€";
        private String CURRENT_VERSION = "Current Version 1.0.0.2 - pre-alpha";
        private int CURRENT_PAGE = 1;

        private User SESSION;
        private List<Portfolio> SESSION_PORTFOLIO;
        private int CURRENT_PORTFOLIO_INDEX;

        internal void setSession(User session)
        {
            this.SESSION = session;            
        }

        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.MainForm_FormClosed);

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Closed here
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set Currency Labels
            valueCurrencyLabel.Text = CURRENT_CURRENCY;
            totalInvestedCurrencyLabel.Text = CURRENT_CURRENCY;
            gainLossCurrencyLabel.Text = CURRENT_CURRENCY;

            //Set Version Label
            versionLabel.Text = CURRENT_VERSION;

            //Load Components ----

            //Read Existant Portfolios
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);

            if(SESSION_PORTFOLIO.Count == 0)
            {
                //Create a new portfolio
                String portfolioName = Interaction.InputBox("Welcome! Please create a new portfolio", "Portfolio Name");
                Portfolio portfolio = new Portfolio(SESSION.ID, portfolioName, 0);
                SESSION_PORTFOLIO.Add(portfolio);
                CURRENT_PORTFOLIO_INDEX = 0;
                XmlHandler.writePortfolio(portfolio);
                UpdateForm();
            }
            else 
            {
                CURRENT_PORTFOLIO_INDEX = 0;
                UpdateForm();               
            }

            dashboardButton.BackgroundImage = Properties.Resources.Dashboard_selected; //maybe
        }

        private void UpdateForm()
        {
            accountNameLabel.Text = SESSION.FirstName + " " + SESSION.LastName;
            portfolioNameLabel.Text = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].PorfolioName;

            //It will change when I implement true values depending on crypto values
            currentValueLabel.Text = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalInvested.ToString();
            totalInvestedLabel.Text = currentValueLabel.Text; //in the future create a method to read the sum of all transactions costs
            gainLossLabel.Text = (float.Parse(currentValueLabel.Text) - float.Parse(totalInvestedLabel.Text)).ToString(); //it will be always zero for now 
            checkGainLoss();
        }

        private void mouseGrab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void showNegativePercentage(int percentage)
        {
            percentageShowPanel.BackgroundImage = Properties.Resources.percentageDOWN;
            arrowPanel.BackgroundImage = Properties.Resources.Polygon_2;
            percentageNumberLabel.Text = percentage.ToString() + "%";
        }
        private void showPositivePercentage(int percentage)
        {
            percentageShowPanel.BackgroundImage = Properties.Resources.percentageUP;
            arrowPanel.BackgroundImage = Properties.Resources.Polygon_1;
            percentageNumberLabel.Text = percentage.ToString() + "%";
        }
        private void checkGainLoss()
        {
            if(float.Parse(gainLossLabel.Text) == 0f)
            {
                gainLossLabel.ForeColor = Color.FromArgb(87, 116, 149); 
            }
            else if (float.Parse(gainLossLabel.Text) > 0f)
            {
                gainLossLabel.ForeColor = Color.FromArgb(120, 188, 97);
            }
            else if (float.Parse(gainLossLabel.Text) < 0f)
            {
                gainLossLabel.ForeColor = Color.FromArgb(194, 118, 112);
            }
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
           
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void dashboardButton_MouseEnter(object sender, EventArgs e)
        {
            if(CURRENT_PAGE != 1)
                dashboardButton.BackgroundImage = Properties.Resources.Dashboard_hover;
            else
                dashboardButton.BackgroundImage = Properties.Resources.Dashboard_selected;
        }

        private void insightButton_MouseEnter(object sender, EventArgs e)
        {
            if (CURRENT_PAGE != 2)
                insightButton.BackgroundImage = Properties.Resources.Insights_hover;
            else
                insightButton.BackgroundImage = Properties.Resources.Insights_selected;
        }      

        private void assetsButton_MouseEnter(object sender, EventArgs e)
        {
            if (CURRENT_PAGE != 3)
                assetsButton.BackgroundImage = Properties.Resources.Assets_hover;
            else
                assetsButton.BackgroundImage = Properties.Resources.Assets_selected;
        }
        private void historyButton_MouseEnter(object sender, EventArgs e)
        {
            if (CURRENT_PAGE != 4)
                historyButton.BackgroundImage = Properties.Resources.History_hover;
            else
                historyButton.BackgroundImage = Properties.Resources.History_selected;
        }

        private void dashboardButton_MouseLeave(object sender, EventArgs e)
        {
            if(CURRENT_PAGE != 1)
                dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            else
                dashboardButton.BackgroundImage = Properties.Resources.Dashboard_selected;
        }

        private void insightButton_MouseLeave(object sender, EventArgs e)
        {

            if (CURRENT_PAGE != 2)
                insightButton.BackgroundImage = Properties.Resources.Insights;
            else
                insightButton.BackgroundImage = Properties.Resources.Insights_selected;
        }

        private void assetsButton_MouseLeave(object sender, EventArgs e)
        {
            if (CURRENT_PAGE != 3)
                assetsButton.BackgroundImage = Properties.Resources.Assets;
            else
                assetsButton.BackgroundImage = Properties.Resources.Assets_selected;
        }

        private void historyButton_MouseLeave(object sender, EventArgs e)
        {
            if (CURRENT_PAGE != 4)
                historyButton.BackgroundImage = Properties.Resources.History;
            else
                historyButton.BackgroundImage = Properties.Resources.History_selected;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 1;
            mainDashboardPanel.BringToFront();
            //Normalize other buttons
            insightButton.BackgroundImage = Properties.Resources.Insights;
            assetsButton.BackgroundImage = Properties.Resources.Assets;
            historyButton.BackgroundImage = Properties.Resources.History;
            //Select current
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard_selected;
        }

        private void insightButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 2;
            mainInsightPanel.BringToFront();
            //Normalize other buttons
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            assetsButton.BackgroundImage = Properties.Resources.Assets;
            historyButton.BackgroundImage = Properties.Resources.History;
            //Select current
            insightButton.BackgroundImage = Properties.Resources.Insights_selected;

        }

        private void assetsButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 3;
            mainAssetsPanel.BringToFront();
            //Normalize other buttons
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            insightButton.BackgroundImage = Properties.Resources.Insights;
            historyButton.BackgroundImage = Properties.Resources.History;
            //Select current
            assetsButton.BackgroundImage = Properties.Resources.Assets_selected;

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 4;
            mainHistoryPanel.BringToFront();
            //Normalize other buttons
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            insightButton.BackgroundImage = Properties.Resources.Insights;
            assetsButton.BackgroundImage = Properties.Resources.Assets;
            //Select current
            historyButton.BackgroundImage = Properties.Resources.History_selected;
        }
    }
}
