using CryptoPortfolio.Client;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        private int TIMER; //in seconds

        private readonly string CURRENT_VERSION = "Current Version 2.0.0.0";
        private int CURRENT_PAGE;

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
            XmlHandler.saveChartInfo(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX]);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //Set Version Label
            versionLabel.Text = CURRENT_VERSION;

            //Load Components ----s            
            //Read Existant Portfolios
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);
            TIMER = -1;
            CURRENT_PAGE = 1;
            if(SESSION_PORTFOLIO.Count == 0)
            {
                CreateNewPortfolio();
            }
            else 
            {
                CURRENT_PORTFOLIO_INDEX = 0;

                await GetFromAPI();
                ChangePage(CURRENT_PAGE);
            }
        }

        private void ResetUpdateTimer()
        {
            timeToUpdate.Visible = false;
            updateTimer.Stop();
            TIMER = Properties.Settings.Default.TimeToUpdate;
            updateTimer.Start();
        }

        private async Task GetFromAPI() //Optimized :)
        {
            if (SESSION_PORTFOLIO.Count != 0)
            {
                SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCost = await SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].GetTotalCost();

                var totalCoins = from transactions in SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].Transactions select transactions.Coin; //IEnumerable of all possesive coins taken from each transaction (here will get repeated coins)
                                                                                                                                                  //Go through the coins
                foreach (Coin coin in totalCoins)
                {
                    try
                    {
                        SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCostOf.Add(coin, await SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].GetTotalCostOf(coin));
                    }
                    catch //In case a coin is repeated
                    {
                        //do nothing
                    }
                }

                SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ClearTempMarketValues();
            }
        }

        public void ResetAndUpdatePortfolio() //just to be sure that everything act right when a new transaction is made
        {            
            //Update Portfolio Global
            SESSION_PORTFOLIO.Clear();
            SESSION_PORTFOLIO = XmlHandler.readPortfolio(SESSION.ID);
            HardUpdate(); //to update right away (and update the temp vars in object since it was cleaned)
        }

        /// <summary>
        /// Shows and updates the Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        public void UpdateDashboard(int portfolio_index)
        {
            ResetUpdateTimer();

            mainDashboardPanel.BringToFront();
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
            portfolioNameLabel.Text = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].PorfolioName;
            settingsPanel.Visible = false;
            showPortfoliosPanel.Visible = false;
            //Update Sub Panels
            UpdateSubHistoryPanel();
            UpdateSubChartPanel();
            UpdateSubAssetsPanel(false);

            float totalInvested = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalInvested();
            totalInvestedLabel.Text = totalInvested.ToString("0.00" + Properties.Settings.Default.Currency);

            float currentValue = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCost;
            currentValueLabel.Text = currentValue.ToString("0.00" + Properties.Settings.Default.Currency);

            float gainLoss = currentValue - totalInvested;
            gainLossLabel.Text = gainLoss.ToString("0.00" + Properties.Settings.Default.Currency);

            CheckGainLoss(currentValue, totalInvested, gainLoss); //Set the color of Gains/Losses Label
        }

        // SUB PANELS IN DASHBOARD ------------------------------------------
        /// <summary>
        /// Updates the sub History Panel in Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        private void UpdateSubHistoryPanel()
        {
            transactionsPanel.Controls.Clear(); //reset to update
            int y_location = 0;
            //int limit = 5; not used

            List<Transaction> orderedTransactions = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].Transactions;
            //to display the new transactions first
            foreach (Transaction transaction in orderedTransactions.OrderByDescending(e => e.Date)) //Go throught all existant transactions
            {
                Panel tempPanel = new Panel();
                Button tempButton = new Button();

                //Creates the panel associated with each transaction
                tempPanel.SetBounds(0, y_location, 450, 30);
                tempPanel.BackgroundImage = Properties.Resources.historyPanelSample;
                tempPanel.BackgroundImageLayout = ImageLayout.None;

                //Add the child components 
                Label dateLabel = new Label();
                dateLabel.AutoSize = true;
                _ = transaction.Date.ToShortDateString() == DateTime.Today.ToShortDateString() ? dateLabel.Text = "Today" : dateLabel.Text = transaction.Date.ToShortDateString().Substring(0, 5); 
                dateLabel.Font = new Font("Inter", 9.75f, FontStyle.Bold);
                dateLabel.ForeColor = Color.FromArgb(68, 113, 153);
                dateLabel.Location = new Point(4, 6);
                tempPanel.Controls.Add(dateLabel);

                Label coinLabel = new Label();
                coinLabel.AutoSize = true;
                _ = (transaction.Coin.Name.Length <= 10) ? coinLabel.Text = transaction.Coin.Name : coinLabel.Text = transaction.Coin.Symbol;
                coinLabel.Font = new Font("Inter", 9.75f, FontStyle.Bold);
                coinLabel.ForeColor = Color.FromArgb(68, 113, 153);
                coinLabel.Location = new Point(64, 6);
                tempPanel.Controls.Add(coinLabel);

                Label amountLabel = new Label();
                amountLabel.AutoSize = true;
                amountLabel.Text = "+ " + transaction.Amount.ToString("0.00");
                amountLabel.Font = new Font("Inter", 9.75f, FontStyle.Bold);
                amountLabel.ForeColor = Color.FromArgb(135, 156, 179);
                amountLabel.Location = new Point(152, 6);
                tempPanel.Controls.Add(amountLabel);

                Label typeLabel = new Label();
                typeLabel.AutoSize = true;
                _ = (transaction.TransactionType == Transaction.Type.Buy) ? typeLabel.Text = "Buy" : typeLabel.Text = "Sell";
                typeLabel.Font = new Font("Inter", 9.75f, FontStyle.Bold);
                _ = (transaction.TransactionType == Transaction.Type.Buy) ? typeLabel.ForeColor = Color.FromArgb(120, 188, 97) : typeLabel.ForeColor = Color.FromArgb(194, 118, 112);
                typeLabel.Location = new Point(265, 6);
                tempPanel.Controls.Add(typeLabel);

                Label totalCostLabel = new Label();
                totalCostLabel.AutoSize = true;
                totalCostLabel.Text = "- " + transaction.TotalCost.ToString("0.00" + Properties.Settings.Default.Currency); //if the type is sell, it should be the symbol of the coin instead of €
                totalCostLabel.Font = new Font("Inter Black", 9.75f, FontStyle.Bold);
                totalCostLabel.ForeColor = Color.FromArgb(135, 156, 179);
                totalCostLabel.Location = new Point(330, 6);
                tempPanel.Controls.Add(totalCostLabel);

                //Creates the button associated with each transaction
                tempButton.Tag = transaction.ID.ToString();
                //Design attributes
                tempButton.SetBounds(421, 3, 24, 24);
                tempButton.BackgroundImage = Properties.Resources.historyButtonSample;
                tempButton.BackgroundImageLayout = ImageLayout.None;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.Cursor = Cursors.Hand;
                //add the event listener to the button
                tempButton.MouseClick += (s,e) => {
                    TransactionDetails newTransactionD = new TransactionDetails();
                    newTransactionD.SetPortfolio(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX],transaction.ID);
                    newTransactionD.ShowDialog(this);
                };
                //add it to the tempPanel (panel of each transaction)
                tempPanel.Controls.Add(tempButton);

                transactionsPanel.Controls.Add(tempPanel);
                y_location += 36;
            }
        }

        /// <summary>
        /// Updates the sub Assets Panel in Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="switchButton">Is comming from the switch view button ? Yes = True / No = False.</param>
        private void UpdateSubAssetsPanel(bool switchButton)
        {
            //Modify top 3 coins percentage Labels ----------------
            //Calculate the percentages
            Dictionary<string, float> percentageOfEachCoin = new Dictionary<string, float>(); //This dict will temporary hold the coins percentage
            
            var totalCoins = from transactions in SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].Transactions select transactions.Coin; //IEnumerable of all possesive coins taken from each transaction (here will get repeated coins)
            
            float totalCostCoins = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCost; //Total value of all coins of the portfolio
            
            //Go through the coins and calculate the total percetage for each one.
            foreach (Coin coin in totalCoins)
            {
                try
                {
                    percentageOfEachCoin.Add(coin.Symbol, (SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCostOf[coin] / totalCostCoins ));
                }
                catch //In case a coin is repeated
                {
                    //do nothing
                }
            }

            //Top 3
            if (!switchButton)
            {
                int topCoins = 3; //the top <3> coins will be shown in labels 
                // TOP 3 LABELS ------------------------
                //Reset top 3 labels
                coinNameN1Label.Visible = false;
                coinPercentageN1Label.Visible = false;

                coinNameN2Label.Visible = false;
                coinPercentageN2Label.Visible = false;

                coinNameN3Label.Visible = false;
                coinPercentageN3Label.Visible = false;

                coinNameN4Label.Visible = false;
                coinPercentageN4Label.Visible = false;
                //Populate top 3 labels
                float[] percentageToChart = new float[4];
                float accum = 0; 
                foreach (var x in percentageOfEachCoin.OrderByDescending(e => e.Value))
                {
                    switch (topCoins)
                    {
                        case 3:
                            coinNameN1Label.Visible = true;
                            coinPercentageN1Label.Visible = true;
                            coinNameN1Label.Text = x.Key;
                            coinPercentageN1Label.Text = x.Value.ToString("0%");
                            percentageToChart[0] = x.Value * 100;
                            topCoins--;
                            break;
                        case 2:
                            coinNameN2Label.Visible = true;
                            coinPercentageN2Label.Visible = true;
                            coinNameN2Label.Text = x.Key;
                            coinPercentageN2Label.Text = x.Value.ToString("0%");
                            percentageToChart[1] = x.Value * 100;
                            topCoins--;
                            break;
                        case 1:
                            coinNameN3Label.Visible = true;
                            coinPercentageN3Label.Visible = true;
                            coinNameN3Label.Text = x.Key;
                            coinPercentageN3Label.Text = x.Value.ToString("0%");
                            percentageToChart[2] = x.Value * 100;
                            topCoins--;
                            break;
                        case 0:
                            accum += x.Value;
                            coinNameN4Label.Visible = true;
                            coinPercentageN4Label.Visible = true;
                            coinPercentageN4Label.Text = accum.ToString("0%");
                            percentageToChart[3] = x.Value * 100;
                            break;
                    }
                }

                // Create and poupulate the CHART ---------------
                assetsChart.Series[0].Points.DataBindY(percentageToChart);
            }

            //ASSETS ALLOCATION PANEL -------------------
            assetsAllocationPanel.Controls.Clear(); //reset to update
            int y_location = 0;

            foreach (var x in percentageOfEachCoin.OrderByDescending(e => e.Value))
            {
                Panel tempPanel = new Panel();

                tempPanel.SetBounds(5, y_location, 247, 30);
                tempPanel.BackgroundImage = Properties.Resources.assetAllocationPanelSample;
                tempPanel.BackgroundImageLayout = ImageLayout.None;
                //Create childs
                Label coinName = new Label();
                coinName.AutoSize = true;
                coinName.Text = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].GetCoinFromSymbol(x.Key).Name;
                coinName.Font = new Font("Inter", 9.75f, FontStyle.Bold);
                coinName.ForeColor = Color.FromArgb(68, 113, 153);
                coinName.Location = new Point(4, 2);
                tempPanel.Controls.Add(coinName);

                Label coinAmount = new Label();
                coinAmount.AutoSize = true;
                coinAmount.Text = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalAmountOf(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].GetCoinFromSymbol(x.Key)).ToString() + " " + x.Key;
                coinAmount.Font = new Font("Inter Medium", 8f);
                coinAmount.ForeColor = Color.FromArgb(135, 156, 179);
                coinAmount.Location = new Point(4, 15);
                tempPanel.Controls.Add(coinAmount);

                Label display = new Label();

                if (switchAllocationViewButton.Tag.ToString() == "0")
                    display.Text = x.Value.ToString("0.00%");
                else if (switchAllocationViewButton.Tag.ToString() == "1")
                {
                    float totalCostOf = SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCostOf[SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].GetCoinFromSymbol(x.Key)];
                    display.Text = totalCostOf.ToString("0.00" + Properties.Settings.Default.Currency);
                }

                display.Font = new Font("Inter", 8f, FontStyle.Bold);
                display.ForeColor = Color.FromArgb(68, 113, 153);
                display.SetBounds(100, 2, 135, 26);
                display.TextAlign = ContentAlignment.MiddleRight;
                tempPanel.Controls.Add(display);

                assetsAllocationPanel.Controls.Add(tempPanel);
                y_location += 36;
            }
        }
        private void switchAllocationViewButton_Click(object sender, EventArgs e)
        {
            if(switchAllocationViewButton.Tag.ToString() == "0")
            {
                switchAllocationViewButton.Tag = "1";
                switchAllocationViewButton.Text = "percentage %";
                UpdateSubAssetsPanel(true);
            }
            else if(switchAllocationViewButton.Tag.ToString() == "1")
            {
                switchAllocationViewButton.Tag = "0";
                switchAllocationViewButton.Text = "money " + Properties.Settings.Default.Currency;
                UpdateSubAssetsPanel(true);
            }
        }

        /// <summary>
        /// Updates the sub Chart Panel in Dashboard Panel with the data of the selected portfolio.
        /// </summary>
        private void UpdateSubChartPanel()
        {
            if (SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ToDisplayChart.Count == 50)
            {
                SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ToDisplayChart.RemoveAt(0);
            }

            if(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCost != 0 || SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ToDisplayChart.Count == 0)
                SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ToDisplayChart.Add(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].TotalCost);

            portfolioChart.Series[0].Points.DataBindY(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ToDisplayChart);

            XmlHandler.saveChartInfo(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX]);
        }
        // -------------------------------------------------------------------

        /// <summary>
        /// Shows and updates the Insight Panel with the data of the selected portfolio.
        /// </summary>
        /// <param name="portfolio_index">Update to this portfolio index</param>
        public void UpdateInsights(int portfolio_index)
        {
            ResetUpdateTimer();
            mainInsightPanel.BringToFront();
            settingsPanel.Visible = false;
            showPortfoliosPanel.Visible = false;
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
            ResetUpdateTimer();

            mainAssetsPanel.BringToFront();
            settingsPanel.Visible = false;
            showPortfoliosPanel.Visible = false;
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
            ResetUpdateTimer();

            mainHistoryPanel.BringToFront();
            settingsPanel.Visible = false;
            showPortfoliosPanel.Visible = false;
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
                XmlHandler.saveSettings(portfolio);
                SESSION_PORTFOLIO.Add(portfolio);               

                //Update the dashboard with the just created portfolio
                CURRENT_PORTFOLIO_INDEX = SESSION_PORTFOLIO.Count - 1;
                ChangePage(1);
                HardUpdate();

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
            else if(CURRENT_PORTFOLIO_INDEX.ToString() == currButton.Tag.ToString())
            {
                //do nothing
            }
            else
            {
                CURRENT_PORTFOLIO_INDEX = int.Parse(currButton.Tag.ToString()); //change the current portfolio index to the selected
                ChangePage(1);
                HardUpdate();
            }
        }

        private void showPortfoliosButton_Click(object sender, EventArgs e) //display all portfolios of the current user
        {
            settingsPanel.Visible = false;
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
        private void ShowNegativePercentage(float percentage)
        {
            percentage = percentage * 100;
            percentageShowPanel.Visible = true; arrowPanel.Visible = true;
            percentageShowPanel.BackgroundImage = Properties.Resources.percentageDOWN;
            arrowPanel.BackgroundImage = Properties.Resources.Polygon_2;
            percentageNumberLabel.Text = percentage.ToString("0.00") + "%";
        }

        /// <summary>
        /// Display a positive percentage in the dashboard.
        /// </summary>
        /// <param name="percentage">Percentage to display</param>
        private void ShowPositivePercentage(float percentage)
        {
            percentage = percentage * 100;
            percentageShowPanel.Visible = true; arrowPanel.Visible = true;
            percentageShowPanel.BackgroundImage = Properties.Resources.percentageUP;
            arrowPanel.BackgroundImage = Properties.Resources.Polygon_1;
            percentageNumberLabel.Text = percentage.ToString("0.00") + "%";
        }

        /// <summary>
        /// Changes the color of Gain/Loss value.
        /// </summary>
        private void CheckGainLoss(float currentValue, float totalInvested, float gainLoss)
        {
            if(gainLoss == 0f)
            {
                percentageShowPanel.Visible = false; arrowPanel.Visible = false;
                gainLossLabel.ForeColor = Color.FromArgb(87, 116, 149); 
            }
            else if (gainLoss > 0f)
            {
                gainLossLabel.ForeColor = Color.FromArgb(120, 188, 97);
                ShowPositivePercentage((currentValue - totalInvested) / currentValue);

            }
            else if (gainLoss < 0f)
            {
                gainLossLabel.ForeColor = Color.FromArgb(194, 118, 112);
                ShowNegativePercentage((currentValue - totalInvested) / currentValue);
            }
        }

        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm newTransaction = new TransactionForm();
            newTransaction.SetPortfolio(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX], CURRENT_PORTFOLIO_INDEX);
            newTransaction.ShowDialog(this);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            HardUpdate();           
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            showPortfoliosPanel.Visible = false;
            switch (Properties.Settings.Default.Currency)
            {
                case "€": currencyComboBox.SelectedIndex = 1; break;
                case "$": currencyComboBox.SelectedIndex = 0; break;
            }

            switch (Properties.Settings.Default.TimeToUpdate)
            {
                case 10: updateTimeComboBox.SelectedIndex = 0; break;
                case 20: updateTimeComboBox.SelectedIndex = 1; break;
                case 30: updateTimeComboBox.SelectedIndex = 2; break;
                case 60: updateTimeComboBox.SelectedIndex = 3; break;
                case 120: updateTimeComboBox.SelectedIndex = 4; break;
                default: updateTimeComboBox.SelectedIndex = 5; break;
            }

            if (settingsPanel.Visible == true)
                settingsPanel.Visible = false;
            else
            {
                settingsPanel.BringToFront();
                settingsPanel.Visible = true;
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Currency != currencyComboBox.Text)
                SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX].ToDisplayChart.Clear();

            Properties.Settings.Default.Currency = currencyComboBox.Text;

            Properties.Settings.Default.TimeToUpdate = int.Parse(updateTimeComboBox.Text);

            MessageBox.Show("Settings changed!","Settings",MessageBoxButtons.OK,MessageBoxIcon.Information);
            settingsPanel.Visible = false;

            XmlHandler.saveSettings(SESSION_PORTFOLIO.ToArray()[CURRENT_PORTFOLIO_INDEX]);
            HardUpdate();
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
            UpdateDashboard(CURRENT_PORTFOLIO_INDEX);
        }
        private void insightButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 2;
            UpdateInsights(CURRENT_PORTFOLIO_INDEX);
        }
        private void assetsButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 3;
            UpdateAssets(CURRENT_PORTFOLIO_INDEX);
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            CURRENT_PAGE = 4;
            UpdateHistory(CURRENT_PORTFOLIO_INDEX);
        }

        private void ChangePage(int pageNumber)
        {
            switch (pageNumber)
            {
                case 1: UpdateDashboard(CURRENT_PORTFOLIO_INDEX);   break;
                case 2: UpdateInsights(CURRENT_PORTFOLIO_INDEX);    break;
                case 3: UpdateAssets(CURRENT_PORTFOLIO_INDEX);      break;
                case 4: UpdateHistory(CURRENT_PORTFOLIO_INDEX);     break;
            }
        }
        
        private void HardUpdate()
        {
            TIMER = 0;
            //this.Enabled = false;
        }

        private async void updateTimer_Tick(object sender, EventArgs e)
        {
            if(timeToUpdate.Visible == false)
                timeToUpdate.Visible = true;
            if(TIMER > 0)
            {
                //this.Enabled = true; //when updating is completed

                timeToUpdate.Text = TIMER.ToString();
                TIMER--;
            }
            else if(TIMER == 0)
            {
                TIMER--;
                timeToUpdate.Text = "Updating";
                //this.Enabled = false;
                await GetFromAPI();
                ChangePage(CURRENT_PAGE);
            }
            else if(TIMER < 0)
            {
                timeToUpdate.Text += '.';
            }
        }

        private void signInOutButton_Click(object sender, EventArgs e)
        {
            
            DialogResult option = MessageBox.Show("You sure you want to sign out ?","Are you sure?", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (option == DialogResult.Yes)
            {
                //Create new MainForm Object
                loginForm login = new loginForm();

                login.Show();
                this.Dispose();
            }
        }

        private void currencyComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Note that changing the currency will reset your chart information.", "Be Carefull", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
