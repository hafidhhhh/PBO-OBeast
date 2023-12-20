namespace BMI_Calculator
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.label8 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.checkRememberMe = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Logo = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.SignInTxt = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(137, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Username";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Montserrat Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(109, 172);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(288, 22);
            this.usernameTxtBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(142, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Montserrat Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(109, 256);
            this.passwordTxtBox.Multiline = true;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(288, 22);
            this.passwordTxtBox.TabIndex = 7;
            // 
            // checkRememberMe
            // 
            this.checkRememberMe.AutoSize = true;
            this.checkRememberMe.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRememberMe.Location = new System.Drawing.Point(126, 300);
            this.checkRememberMe.Name = "checkRememberMe";
            this.checkRememberMe.Size = new System.Drawing.Size(106, 18);
            this.checkRememberMe.TabIndex = 9;
            this.checkRememberMe.Text = "Remember Me";
            this.checkRememberMe.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Font = new System.Drawing.Font("Montserrat Medium", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(109, 362);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 26);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(337, 362);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 26);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.White;
            this.signUpButton.Font = new System.Drawing.Font("Montserrat Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(247, 362);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(84, 26);
            this.signUpButton.TabIndex = 15;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.Logo);
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradient2Panel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1281, 720);
            this.gunaGradient2Panel1.TabIndex = 19;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Purple;
            this.gunaLabel1.Location = new System.Drawing.Point(114, 383);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(378, 98);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Turn Obese into\r\nA BEAST.";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Logo.Location = new System.Drawing.Point(287, 253);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(293, 91);
            this.Logo.TabIndex = 8;
            this.Logo.Text = "Beast.";
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.signUpButton);
            this.gunaGradient2Panel2.Controls.Add(this.SignInTxt);
            this.gunaGradient2Panel2.Controls.Add(this.clearButton);
            this.gunaGradient2Panel2.Controls.Add(this.loginButton);
            this.gunaGradient2Panel2.Controls.Add(this.checkRememberMe);
            this.gunaGradient2Panel2.Controls.Add(this.pictureBox4);
            this.gunaGradient2Panel2.Controls.Add(this.passwordTxtBox);
            this.gunaGradient2Panel2.Controls.Add(this.label9);
            this.gunaGradient2Panel2.Controls.Add(this.usernameTxtBox);
            this.gunaGradient2Panel2.Controls.Add(this.label8);
            this.gunaGradient2Panel2.Controls.Add(this.pictureBox3);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Snow;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.MistyRose;
            this.gunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(651, 138);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 40;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(530, 461);
            this.gunaGradient2Panel2.TabIndex = 1;
            // 
            // SignInTxt
            // 
            this.SignInTxt.AutoSize = true;
            this.SignInTxt.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInTxt.ForeColor = System.Drawing.Color.Purple;
            this.SignInTxt.Location = new System.Drawing.Point(154, 32);
            this.SignInTxt.Name = "SignInTxt";
            this.SignInTxt.Size = new System.Drawing.Size(224, 54);
            this.SignInTxt.TabIndex = 0;
            this.SignInTxt.Text = "SIGN IN";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::BMI_Calculator.Properties.Resources.password_icon;
            this.pictureBox4.Location = new System.Drawing.Point(114, 224);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BMI_Calculator.Properties.Resources.Profile;
            this.pictureBox3.Location = new System.Drawing.Point(114, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(26, 115);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(332, 301);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkRememberMe;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signUpButton;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel Logo;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaLabel SignInTxt;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}