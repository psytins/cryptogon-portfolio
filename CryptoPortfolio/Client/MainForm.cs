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
        private string CURRENT_CURRENCY = "€";
        private string CURRENT_VERSION = "Current Version 1.0.0.2 - pre-alpha";
        private int CURRENT_PAGE = 1;

        /// <summary>
        /// The current user.
        /// </summary>
        private User SESSION;
        /// <summary>
        /// The list of portfolio/s that the current user have. The limit of portfolios per user is three.
        /// </summary>
        private List<Portfolio> SESSION_PORTFOLIO; //Limit : 3
        /// <summary>
        /// Current portfolio index. MAX VALUE = 2
        /// </summary>
        private int CURRENT_PORTFOLIO_INDEX;

        internal void SetSession(User session)
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
                CreateNewPortfolio();
            }
            else 
            {
                UpdateDashboard(0);               
            }

            dashboardButton.BackgroundImage = Properties.Resources.Dashboard_selected; //maybe
        }

        /// <summary>
        /// Updates the Dashboard Form with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        private void UpdateDashboard(int portfolio_index)
        {
            CURRENT_PORTFOLIO_INDEX = portfolio_index;
            //Dashboard Update -------------
            accountNameLabel.Text = SESSION.FirstName + " " + SESSION.LastName;
            portfolioNameLabel.Text = SESSION_PORTFOLIO.ToArray()[portfolio_index].PorfolioName;
            showPortfoliosPanel.Visible = false;

            //It will change when I implement true values depending on crypto values
            currentValueLabel.Text = SESSION_PORTFOLIO.ToArray()[portfolio_index].TotalInvested.ToString();
            totalInvestedLabel.Text = currentValueLabel.Text; //in the future create a method to read the sum of all transactions costs
            gainLossLabel.Text = (float.Parse(currentValueLabel.Text) - float.Parse(totalInvestedLabel.Text)).ToString(); //it will be always zero for now 
            CheckGainLoss(); //Set the color of Gains/Losses Label
        }

        /// <summary>
        /// Create a new portfolio for the current user and then load the just created portfolio. The limit per user is three.
        /// </summary>
        private void CreateNewPortfolio()
        {
            if (SESSION_PORTFOLIO.Count == 3)
                MessageBox.Show("You can only create three portfolios. If you wish to add more portfolios, please create a new account.", 
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Create a new portfolio
                string portfolioName = Interaction.InputBox("Please create a new portfolio", "Portfolio Name"); //What if user clicks cancel ????
                Portfolio portfolio = new Portfolio(SESSION.ID, portfolioName, 0);
                SESSION_PORTFOLIO.Add(portfolio);
                XmlHandler.writePortfolio(portfolio);

                UpdateDashboard(SESSION_PORTFOLIO.Count-1); //Update the dashboard with the just created portfolio
            }
        }

        /// <summary>
        ///Used to mouseClick event. Select and load the clicked portfolio or add a new portfolio if this is inexistent.
        /// </summary>
        private void SelectPortfolio(object sender, EventArgs e)
        {
            Button currButton = sender as Button;
            if (currButton.Tag.ToString() == "-1")
            {
                CreateNewPortfolio();
            }
            else
            {
                //Check where the user is (future)
                UpdateDashboard(int.Parse(currButton.Tag.ToString()));
            }


        }

        private void showPortfoliosButton_Click(object sender, EventArgs e) //display all portfolios of the current user
        {
            //Show panel
            if(showPortfoliosPanel.Visible == false)    
                showPortfoliosPanel.Visible = true;
            else if(showPortfoliosPanel.Visible == true)
                showPortfoliosPanel.Visible = false;

            for(int i = 0; i < SESSION_PORTFOLIO.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        openPortfolio0Button.Text = SESSION_PORTFOLIO.ToArray()[i].PorfolioName;
                        openPortfolio0Button.Tag = 0;

                        //Check if this is the current portfolio
                        if (CURRENT_PORTFOLIO_INDEX == i)
                        {
                            openPortfolio0Button.BackgroundImage = Properties.Resources.currentPortfolio;
                            openPortfolio0Button.ForeColor = Color.FromArgb(39, 76, 119);
                        }
                        else
                            openPortfolio0Button.BackgroundImage = Properties.Resources.portfolioCreated;
                        break;

                    case 1:
                        openPortfolio1Button.Text = SESSION_PORTFOLIO.ToArray()[i].PorfolioName;
                        openPortfolio1Button.Tag = 1;

                        if (CURRENT_PORTFOLIO_INDEX == i)
                        {
                            openPortfolio1Button.BackgroundImage = Properties.Resources.currentPortfolio;
                            openPortfolio1Button.ForeColor = Color.FromArgb(39, 76, 119);
                        }
                        else
                            openPortfolio1Button.BackgroundImage = Properties.Resources.portfolioCreated;
                        break;

                    case 2:
                        openPortfolio2Button.Text = SESSION_PORTFOLIO.ToArray()[i].PorfolioName;
                        openPortfolio2Button.Tag= 2;

                        if (CURRENT_PORTFOLIO_INDEX == i)
                        {
                            openPortfolio2Button.BackgroundImage = Properties.Resources.currentPortfolio;
                            openPortfolio2Button.ForeColor = Color.FromArgb(39, 76, 119);
                        }
                        else
                            openPortfolio2Button.BackgroundImage = Properties.Resources.portfolioCreated;
                        break;
                    default: break;
                }
            }




        }

        private void mouseGrab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Display a negative percentage in the dashboard.
        /// </summary>
        /// <param name="percentage">Percentage to display</param>
        private void ShowNegativePercentage(int percentage)
        {
            percentageShowPanel.BackgroundImage = Properties.Resources.percentageDOWN;
            arrowPanel.BackgroundImage = Properties.Resources.Polygon_2;
            percentageNumberLabel.Text = percentage.ToString() + "%";
        }

        /// <summary>
        /// Display a positive percentage in the dashboard.
        /// </summary>
        /// <param name="percentage">Percentage to display</param>
        private void ShowPositivePercentage(int percentage)
        {
            percentageShowPanel.BackgroundImage = Properties.Resources.percentageUP;
            arrowPanel.BackgroundImage = Properties.Resources.Polygon_1;
            percentageNumberLabel.Text = percentage.ToString() + "%";
        }

        /// <summary>
        /// Changes the color of Gain/Loss value.
        /// </summary>
        private void CheckGainLoss()
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
