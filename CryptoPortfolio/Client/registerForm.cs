using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CryptoPortfolio
{
    public partial class registerForm : Form
    {
        //Lets the mouse move the form withou border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // -------------------
        public registerForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.registerForm_FormClosed);
        }
        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void firstNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstNameTextBox.Text == "First name")
                firstNameTextBox.Text = "";
        }

        private void firstNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
                firstNameTextBox.Text = "First name";
        }

        private void lastNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (lastNameTextBox.Text == "Last name")
                lastNameTextBox.Text = "";
        }

        private void lastNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
                lastNameTextBox.Text = "Last name";
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
        private void confirmPasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (confirmPasswordTextBox.Text == "Confirm password")
            {
                confirmPasswordTextBox.PasswordChar = '*';
                confirmPasswordTextBox.Text = "";
            }

        }
        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(confirmPasswordTextBox.Text == "Confirm password"))
                confirmPasswordTextBox.PasswordChar = '*';
        }

        private void confirmPasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "")
            {
                confirmPasswordTextBox.PasswordChar = (char)0;
                confirmPasswordTextBox.Text = "Confirm password";
            }
        }

        private void signupButton_MouseLeave(object sender, EventArgs e)
        {
            signupButton.BackgroundImage = Properties.Resources.signupButton;
        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            validateRegister();
            signupButton.BackgroundImage = Properties.Resources.signupButton_hover;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (validateRegister())
            {
                //Regist new user information to the data base

                //Create User object
                User user = new User(firstNameTextBox.Text, lastNameTextBox.Text, emailAddressTextBox.Text, passwordTextBox.Text); 
                XmlHandler.writeUser(user); //write user in xml
                
                // ------------

                MessageBox.Show("Thanks! Please Sign in now", "All done!", MessageBoxButtons.OK,MessageBoxIcon.Information);

                new loginForm().Show();
                this.Close();
            }
        }

        private bool validateRegister()
        {
            //Reset error labels and text lines
            nothinErrorLabel.Visible = false;
            nameErrorLabel.Visible = false;
            firstNameLineLabel.ForeColor = Color.FromArgb(231, 236, 239);
            lastNameLineLabel.ForeColor = Color.FromArgb(231, 236, 239);

            emailErrorLabel.Visible = false;
            emailLineLabel.ForeColor = Color.FromArgb(231, 236, 239);

            passwordErrorLabel.Visible = false;
            passwordLineLabel.ForeColor = Color.FromArgb(231, 236, 239);

            confirmPasswordErrorLabel.Visible = false;
            confirmPasswordLineLabel.ForeColor = Color.FromArgb(231, 236, 239);


            Regex name_regex = new Regex(@"^[a-zA-Z\u00C0-\u00FF]*$"); //No spaces and allow alphabets and accented characters
            Regex email_regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"); //Email format
            Regex password_regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");//Minimum eight characters, at least one uppercase letter, one lowercase letter and one number
            if (firstNameTextBox.Text == "First name" || lastNameTextBox.Text == "Last name" || emailAddressTextBox.Text == "E-mail address" || passwordTextBox.Text == "Password"|| confirmPasswordTextBox.Text == "Confirm password")
            {
                buttonRun();
                nothinErrorLabel.Visible = true;
                if(firstNameTextBox.Text == "First name")
                    firstNameLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                if(lastNameTextBox.Text == "Last name")
                    lastNameLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                if(emailAddressTextBox.Text == "E-mail address")
                    emailLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                if(passwordTextBox.Text == "Password")
                    passwordLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                if(confirmPasswordTextBox.Text == "Confirm password")
                    confirmPasswordLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if (!name_regex.IsMatch(firstNameTextBox.Text) || !name_regex.IsMatch(lastNameTextBox.Text))
            {
                buttonRun();
                nameErrorLabel.Visible = true;
                if (!name_regex.IsMatch(firstNameTextBox.Text))
                    firstNameLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                if (!name_regex.IsMatch(lastNameTextBox.Text))
                    lastNameLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if (!email_regex.IsMatch(emailAddressTextBox.Text))
            {
                buttonRun();
                emailErrorLabel.Text = "Email incorrect form.";
                emailErrorLabel.Visible = true;
                emailLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if (XmlHandler.readUser(emailAddressTextBox.Text) != null) //The email already exists
            {
                buttonRun();
                emailErrorLabel.Text = "Email already exists.";
                emailErrorLabel.Visible = true;
                emailLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if (!password_regex.IsMatch(passwordTextBox.Text))
            {
                buttonRun();
                passwordErrorLabel.Visible = true;
                passwordLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else if ( passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                buttonRun();
                confirmPasswordErrorLabel.Visible = true;
                confirmPasswordLineLabel.ForeColor = Color.FromArgb(194, 118, 112);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRun() //allow the button to "run" if register validation returns false
        {
            if(signupButton.Location.Y == 400) //default localization of the button
            {
                signupButton.Location = new Point(signupButton.Location.X + new Random().Next(-40, 40), signupButton.Location.Y + new Random().Next(50,80));
            }
            else if(signupButton.Location.Y > 450)
            {
                signupButton.Location = new Point(signupButton.Location.X + new Random().Next(-40, 40), signupButton.Location.Y - new Random().Next(50, 80));
            }
            else if(signupButton.Location.X < 450)
            {
                signupButton.Location = new Point(signupButton.Location.X + new Random().Next(-40, 40), signupButton.Location.Y + new Random().Next(50, 80));
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            new loginForm().Show(); 
            this.Close();
        }
    }
}
