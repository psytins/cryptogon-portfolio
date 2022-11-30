using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class MainForm : Form
    {
        //Lets the mouse move the form without border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // -------------------
        //Global Variables
        private string CURRENT_VERSION = "Current Version 2.0.0.0 - pre-alpha";
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
            valueCurrencyLabel.Text = Properties.Settings.Default.Currency;
            totalInvestedCurrencyLabel.Text = Properties.Settings.Default.Currency;
            gainLossCurrencyLabel.Text = Properties.Settings.Default.Currency;

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
        }

        /// <summary>
        /// Shows and updates the Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        public void UpdateDashboard(int portfolio_index)
        {
            //Update Portfolio Global (Maybe in future change update Potfolio Global when strictly necessary)
            SESSION_PORTFOLIO.Clear();
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);

            mainDashboardPanel.BringToFront();
            CURRENT_PAGE = 1;
            //Change Side buttons --------
            //Normalize other buttons
            insightButton.BackgroundImage = Properties.Resources.Insights;
            assetsButton.BackgroundImage = Properties.Resources.Assets;
            historyButton.BackgroundImage = Properties.Resources.History;
            //Select current
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard_selected;
            //-------------

            CURRENT_PORTFOLIO_INDEX = portfolio_index;
            //Dashboard Update -------------
            accountNameLabel.Text = SESSION.FirstName + " " + SESSION.LastName;
            portfolioNameLabel.Text = SESSION_PORTFOLIO.ToArray()[portfolio_index].PorfolioName;
            showPortfoliosPanel.Visible = false;
            //Update Sub Panels
            UpdateSubHistoryPanel();
            UpdateSubChartPanel();  
            UpdateSubAssetsPanel();

            //It will change when I implement true values depending on crypto values
            totalInvestedLabel.Text = SESSION_PORTFOLIO.ToArray()[portfolio_index].CalculateTotalInvested().ToString();
            currentValueLabel.Text = totalInvestedLabel.Text; //in the future this values changes depending crypto values
            gainLossLabel.Text = (float.Parse(currentValueLabel.Text) - float.Parse(totalInvestedLabel.Text)).ToString(); //it will be always zero for now 
            CheckGainLoss(); //Set the color of Gains/Losses Label
        }

        /// <summary>
        /// Updates the sub History Panel in Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        private void UpdateSubHistoryPanel()
        {
            //int y_location = 0;

            //foreach (Transaction transaction in SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].Transactions) //Go throught all existant transactions
            //{
            //    Panel tempPanel = new Panel();
            //    Button tempButton = new Button();

            //    tempButton.Text = coin.Name;
            //    tempButton.Tag = coin;
            //    //Design attributes
            //    tempButton.SetBounds(5, y_location, 329, 32);

            //    tempButton.BackgroundImage = Properties.Resources.coinButton;
            //    tempButton.BackgroundImageLayout = ImageLayout.None;
            //    tempButton.FlatAppearance.BorderSize = 0;
            //    tempButton.FlatStyle = FlatStyle.Flat;
            //    tempButton.ForeColor = Color.FromArgb(39, 76, 119);
            //    tempButton.TextAlign = ContentAlignment.MiddleLeft;

            //    //add the event listener
            //    tempButton.MouseClick += new MouseEventHandler(CoinSelected);
            //    //add it to the coin panel
            //    coinPanel.Controls.Add(tempButton);

            //    y_location += 35;
            //}

        }

        /// <summary>
        /// Updates the sub Chart Panel in Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        private void UpdateSubChartPanel()
        {

        }

        /// <summary>
        /// Updates the sub Assets Panel in Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        private void UpdateSubAssetsPanel()
        {

        }

        /// <summary>
        /// Shows and updates the Insight Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        public void UpdateInsights(int portfolio_index)
        {
            SESSION_PORTFOLIO.Clear();
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);

            mainInsightPanel.BringToFront();
            CURRENT_PAGE = 2;
            //Change Side buttons --------
            //Normalize other buttons
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            assetsButton.BackgroundImage = Properties.Resources.Assets;
            historyButton.BackgroundImage = Properties.Resources.History;
            //Select current
            insightButton.BackgroundImage = Properties.Resources.Insights_selected;
            //-------------

            CURRENT_PORTFOLIO_INDEX = portfolio_index;
        }

        /// <summary>
        /// Show and updates the Assets Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        public void UpdateAssets(int portfolio_index)
        {
            SESSION_PORTFOLIO.Clear();
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);

            mainAssetsPanel.BringToFront();
            CURRENT_PAGE = 3;
            //Change Side buttons --------
            //Normalize other buttons
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            insightButton.BackgroundImage = Properties.Resources.Insights;
            historyButton.BackgroundImage = Properties.Resources.History;
            //Select current
            assetsButton.BackgroundImage = Properties.Resources.Assets_selected;
            //-------------

            CURRENT_PORTFOLIO_INDEX = portfolio_index;
        }

        /// <summary>
        /// Shows and updates the History Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        public void UpdateHistory(int portfolio_index)
        {
            SESSION_PORTFOLIO.Clear();
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);

            mainHistoryPanel.BringToFront();
            CURRENT_PAGE = 4;
            //Change Side buttons --------
            //Normalize other buttons
            dashboardButton.BackgroundImage = Properties.Resources.Dashboard;
            insightButton.BackgroundImage = Properties.Resources.Insights;
            assetsButton.BackgroundImage = Properties.Resources.Assets;
            //Select current
            historyButton.BackgroundImage = Properties.Resources.History_selected;
            //-------------

            CURRENT_PORTFOLIO_INDEX = portfolio_index;
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
                Portfolio portfolio = new Portfolio(SESSION.ID, portfolioName);
                XmlHandler.writePortfolio(portfolio);

                UpdateDashboard(SESSION_PORTFOLIO.Count); //Update the dashboard with the just created portfolio
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
                //Check where the user is (future) (use if with CURRENT_PAGE)
                UpdateDashboard(int.Parse(currButton.Tag.ToString()));
            }


        }

        private void showPortfoliosButton_Click(object sender, EventArgs e) //display all portfolios of the current user
        {

            //Show panel
            if (showPortfoliosPanel.Visible == false)
            {
                showPortfoliosPanel.BringToFront();
                showPortfoliosPanel.Visible = true;
            }
            else if (showPortfoliosPanel.Visible == true)
                showPortfoliosPanel.Visible = false;

            for(int i = 0; i < SESSION_PORTFOLIO.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        openPortfolio0Button.Text = SESSION_PORTFOLIO.ToArray()[i].PorfolioName; 
                        openPortfolio0Button.ForeColor = Color.FromArgb(230, 235, 238);
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
                        openPortfolio1Button.ForeColor = Color.FromArgb(230, 235, 238);
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
                        openPortfolio2Button.ForeColor = Color.FromArgb(230, 235, 238);
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

        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm newTransaction = new TransactionForm();
            newTransaction.SetPortfolio(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX], CURRENT_PORTFOLIO_INDEX);
            newTransaction.ShowDialog(this);
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
            UpdateDashboard(CURRENT_PORTFOLIO_INDEX);
        }
        private void insightButton_Click(object sender, EventArgs e)
        {
            UpdateInsights(CURRENT_PORTFOLIO_INDEX);
        }
        private void assetsButton_Click(object sender, EventArgs e)
        {
            UpdateAssets(CURRENT_PORTFOLIO_INDEX);
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            UpdateHistory(CURRENT_PORTFOLIO_INDEX);
        }
    }
}
