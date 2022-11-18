using CryptoPortfolio;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class loginForm : Form
    {
        //Lets the mouse move the form withou border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // -------------------
        public loginForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.loginForm_FormClosed);
        }
        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //can be closed here
        }

        private void mouseGrab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mailAddressTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (emailAddressTextBox.Text == "E-mail address")
                emailAddressTextBox.Text = "";
        }

        private void mailAddressTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (emailAddressTextBox.Text == "")
                emailAddressTextBox.Text = "E-mail address";
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.PasswordChar = '*';
                passwordTextBox.Text = "";
            }
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(passwordTextBox.Text == "Password"))
                passwordTextBox.PasswordChar = '*';
        }
        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.PasswordChar = (char)0;
                passwordTextBox.Text = "Password";
            }
        }

        private void signinButton_MouseLeave(object sender, EventArgs e)
        {
            signinButton.BackgroundImage = Properties.Resources.signinButton;
        }

        private void signinButton_MouseEnter(object sender, EventArgs e)
        {
            validateRegister();
            signinButton.BackgroundImage = Properties.Resources.signinButton_hover;
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if (validateRegister())
            {
                User validatedUser = XmlHandler.readUser(emailAddressTextBox.Text);
                MessageBox.Show("Welcome " + validatedUser.FirstName + " " + validatedUser.LastName);

                //Create new MainForm Object
                MainForm mainForm = new MainForm();

                //Get the user
                mainForm.setSession(validatedUser);

                mainForm.Show();
                this.Close();
            }
        }

        private bool validateRegister()
        {
            //Reset error labels
            nothinErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;
            emailLineLabel.ForeColor = Color.FromArgb(231, 236, 239);
            passwordLineLabel.ForeColor = Color.FromArgb(231, 236, 239);

            Regex email_regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"); //Email format
            if (emailAddressTextBox.Text == "E-mail address" || passwordTextBox.Text == "Password")
            {
                buttonRun();
                nothinErrorLabel.Visible = true;
                if (emailAddressTextBox.Text == "E-mail address")
                    emailLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                if (passwordTextBox.Text == "Password")
                    passwordLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if (XmlHandler.readUser(emailAddressTextBox.Text) == null) //The email don't exists
            {
                buttonRun();
                emailErrorLabel.Visible = true;
                emailLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if (XmlHandler.readUser(emailAddressTextBox.Text).Password != passwordTextBox.Text) //check if the password is correct
            {
                buttonRun();
                passwordErrorLabel.Visible = true;
                passwordLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRun()
        {
            if (signinButton.Location.Y == 400) //default localization
            {
                signinButton.Location = new Point(signinButton.Location.X + new Random().Next(-40, 40), signinButton.Location.Y + new Random().Next(50, 80));
            }
            else if (signinButton.Location.Y > 450)
            {
                signinButton.Location = new Point(signinButton.Location.X + new Random().Next(-40, 40), signinButton.Location.Y - new Random().Next(50, 80));
            }
            else if (signinButton.Location.X < 450)
            {
                signinButton.Location = new Point(signinButton.Location.X + new Random().Next(-40, 40), signinButton.Location.Y + new Random().Next(50, 80));
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            new registerForm().Show(); 
            this.Close();
        }
    }
}
