namespace BMI_Calculator
{
    partial class UserDataInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataInput));
            this.weight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.Logo = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTxtBox = new System.Windows.Forms.TextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(32, 134);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(109, 27);
            this.weight.TabIndex = 7;
            this.weight.Text = "Birthdate";
            this.weight.Click += new System.EventHandler(this.weight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(365, 307);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(123, 33);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // radbtnMale
            // 
            this.radbtnMale.AutoSize = true;
            this.radbtnMale.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMale.Location = new System.Drawing.Point(37, 252);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(61, 22);
            this.radbtnMale.TabIndex = 19;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.UseVisualStyleBackColor = true;
            this.radbtnMale.CheckedChanged += new System.EventHandler(this.radbtnMale_CheckedChanged);
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnFemale.Location = new System.Drawing.Point(104, 252);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(79, 22);
            this.radbtnFemale.TabIndex = 20;
            this.radbtnFemale.TabStop = true;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.UseVisualStyleBackColor = true;
            this.radbtnFemale.CheckedChanged += new System.EventHandler(this.radbtnFemale_CheckedChanged);
            // 
            // birthDate
            // 
            this.birthDate.CalendarFont = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Location = new System.Drawing.Point(37, 169);
            this.birthDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.birthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(229, 23);
            this.birthDate.TabIndex = 21;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradient2Panel1.AutoSize = true;
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.Logo);
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradient2Panel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1272, 720);
            this.gunaGradient2Panel1.TabIndex = 22;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Logo.Location = new System.Drawing.Point(594, 96);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(147, 46);
            this.Logo.TabIndex = 8;
            this.Logo.Text = "Beast.";
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.label4);
            this.gunaGradient2Panel2.Controls.Add(this.fullNameTxtBox);
            this.gunaGradient2Panel2.Controls.Add(this.btnSaveChanges);
            this.gunaGradient2Panel2.Controls.Add(this.birthDate);
            this.gunaGradient2Panel2.Controls.Add(this.radbtnFemale);
            this.gunaGradient2Panel2.Controls.Add(this.radbtnMale);
            this.gunaGradient2Panel2.Controls.Add(this.weight);
            this.gunaGradient2Panel2.Controls.Add(this.label3);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Snow;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.MistyRose;
            this.gunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(374, 201);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 40;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(512, 380);
            this.gunaGradient2Panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Full Name";
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTxtBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fullNameTxtBox.Location = new System.Drawing.Point(37, 82);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.Size = new System.Drawing.Size(229, 23);
            this.fullNameTxtBox.TabIndex = 22;
            this.fullNameTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(509, 57);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(107, 103);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // UserDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1271, 720);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDataInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Data Input";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.RadioButton radbtnMale;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.DateTimePicker birthDate;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel Logo;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTxtBox;
    }
}