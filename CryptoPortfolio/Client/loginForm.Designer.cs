
namespace CryptoPortfolio
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.mouseGrab = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nothinErrorLabel = new System.Windows.Forms.TextBox();
            this.passwordErrorLabel = new System.Windows.Forms.TextBox();
            this.emailErrorLabel = new System.Windows.Forms.TextBox();
            this.signinButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLineLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailLineLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.mouseGrab.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mouseGrab
            // 
            this.mouseGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.mouseGrab.Controls.Add(this.minimizeButton);
            this.mouseGrab.Controls.Add(this.closeButton);
            this.mouseGrab.Location = new System.Drawing.Point(0, 0);
            this.mouseGrab.Margin = new System.Windows.Forms.Padding(4);
            this.mouseGrab.Name = "mouseGrab";
            this.mouseGrab.Size = new System.Drawing.Size(512, 60);
            this.mouseGrab.TabIndex = 0;
            this.mouseGrab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseGrab_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Inter SemiBold", 12F);
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(156)))), ((int)(((byte)(179)))));
            this.minimizeButton.Location = new System.Drawing.Point(432, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(45, 25);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.Text = "___";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.closeButton_2;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(478, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 22);
            this.closeButton.TabIndex = 8;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.nothinErrorLabel);
            this.topPanel.Controls.Add(this.passwordErrorLabel);
            this.topPanel.Controls.Add(this.emailErrorLabel);
            this.topPanel.Controls.Add(this.signinButton);
            this.topPanel.Controls.Add(this.passwordTextBox);
            this.topPanel.Controls.Add(this.passwordLineLabel);
            this.topPanel.Controls.Add(this.emailAddressTextBox);
            this.topPanel.Controls.Add(this.emailLineLabel);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.mouseGrab);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(512, 553);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Inter Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(200, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sign in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(188, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "____________________________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nothinErrorLabel
            // 
            this.nothinErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.nothinErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nothinErrorLabel.Font = new System.Drawing.Font("Inter SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothinErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.nothinErrorLabel.Location = new System.Drawing.Point(156, 179);
            this.nothinErrorLabel.Name = "nothinErrorLabel";
            this.nothinErrorLabel.Size = new System.Drawing.Size(208, 16);
            this.nothinErrorLabel.TabIndex = 17;
            this.nothinErrorLabel.Text = "Please, complete all the spaces.";
            this.nothinErrorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nothinErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.passwordErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Inter SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.passwordErrorLabel.Location = new System.Drawing.Point(156, 315);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(208, 16);
            this.passwordErrorLabel.TabIndex = 16;
            this.passwordErrorLabel.Text = "Password doesn\'t match.";
            this.passwordErrorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.emailErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailErrorLabel.Font = new System.Drawing.Font("Inter SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.emailErrorLabel.Location = new System.Drawing.Point(126, 245);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(270, 16);
            this.emailErrorLabel.TabIndex = 14;
            this.emailErrorLabel.Text = "This e-mail is not registred. Please sign up.";
            this.emailErrorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailErrorLabel.Visible = false;
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signinButton.BackgroundImage = global::CryptoPortfolio.Properties.Resources.signinButton;
            this.signinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signinButton.FlatAppearance.BorderSize = 0;
            this.signinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinButton.Location = new System.Drawing.Point(100, 396);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(300, 50);
            this.signinButton.TabIndex = 12;
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            this.signinButton.MouseEnter += new System.EventHandler(this.signinButton_MouseEnter);
            this.signinButton.MouseLeave += new System.EventHandler(this.signinButton_MouseLeave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Inter Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.passwordTextBox.Location = new System.Drawing.Point(41, 283);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(434, 26);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTextBox_MouseClick);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.MouseLeave += new System.EventHandler(this.passwordTextBox_MouseLeave);
            // 
            // passwordLineLabel
            // 
            this.passwordLineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.passwordLineLabel.Location = new System.Drawing.Point(37, 294);
            this.passwordLineLabel.Name = "passwordLineLabel";
            this.passwordLineLabel.Size = new System.Drawing.Size(440, 21);
            this.passwordLineLabel.TabIndex = 9;
            this.passwordLineLabel.Text = "____________________________________________________________";
            this.passwordLineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.emailAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailAddressTextBox.Font = new System.Drawing.Font("Inter Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.emailAddressTextBox.Location = new System.Drawing.Point(41, 213);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(434, 26);
            this.emailAddressTextBox.TabIndex = 6;
            this.emailAddressTextBox.Text = "E-mail address";
            this.emailAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailAddressTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mailAddressTextBox_MouseClick);
            this.emailAddressTextBox.MouseLeave += new System.EventHandler(this.mailAddressTextBox_MouseLeave);
            // 
            // emailLineLabel
            // 
            this.emailLineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailLineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.emailLineLabel.Location = new System.Drawing.Point(37, 224);
            this.emailLineLabel.Name = "emailLineLabel";
            this.emailLineLabel.Size = new System.Drawing.Size(440, 21);
            this.emailLineLabel.TabIndex = 7;
            this.emailLineLabel.Text = "____________________________________________________________";
            this.emailLineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = global::CryptoPortfolio.Properties.Resources.Logo_login;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(119)))));
            this.label5.Location = new System.Drawing.Point(106, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Don\'t have an account yet?";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Inter SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.signupButton.Location = new System.Drawing.Point(315, 569);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(91, 30);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "Sign up";
            this.signupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(512, 614);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginForm";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.mouseGrab.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mouseGrab;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailLineLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLineLabel;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox passwordErrorLabel;
        private System.Windows.Forms.TextBox emailErrorLabel;
        private System.Windows.Forms.TextBox nothinErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}