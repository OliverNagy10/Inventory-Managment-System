﻿
namespace Inventory_Managment_System.SignUp_Management
{
    partial class SignUpView
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
            Telerik.WinControls.ThemeSource themeSource2 = new Telerik.WinControls.ThemeSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpView));
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.LoginButton = new Telerik.WinControls.UI.RadButton();
            this.loginLabel = new Telerik.WinControls.UI.RadLabel();
            this.Logo = new Telerik.WinControls.UI.RadButton();
            this.companyNameBox = new Telerik.WinControls.UI.RadTextBox();
            this.emailTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.passwordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.SignUp = new Telerik.WinControls.UI.RadLabel();
            this.image = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radThemeManager1
            // 
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource2});
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(237, 594);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(8);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(78, 32);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "LOG IN";
            this.LoginButton.ThemeName = "Windows11Dark";
            this.LoginButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(58, 595);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(8);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(175, 22);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Already Have an account ?";
            this.loginLabel.ThemeName = "Windows11Dark";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.Location = new System.Drawing.Point(210, 479);
            this.Logo.Margin = new System.Windows.Forms.Padding(6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(120, 43);
            this.Logo.TabIndex = 11;
            this.Logo.Text = "SIGN UP";
            this.Logo.ThemeName = "Windows11Dark";
            this.Logo.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // companyNameBox
            // 
            this.companyNameBox.Location = new System.Drawing.Point(137, 207);
            this.companyNameBox.Margin = new System.Windows.Forms.Padding(6);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.Size = new System.Drawing.Size(276, 32);
            this.companyNameBox.TabIndex = 12;
            this.companyNameBox.Text = "Company Name";
            this.companyNameBox.ThemeName = "Windows11Dark";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(137, 294);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(276, 32);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Text = "Company Email";
            this.emailTextBox.ThemeName = "Windows11Dark";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(137, 383);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(276, 32);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.ThemeName = "Windows11Dark";
            // 
            // SignUp
            // 
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SignUp.Location = new System.Drawing.Point(137, 100);
            this.SignUp.Margin = new System.Windows.Forms.Padding(6);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(96, 31);
            this.SignUp.TabIndex = 15;
            this.SignUp.Text = "REGISTER";
            this.SignUp.ThemeName = "Windows11Dark";
            // 
            // image
            // 
            this.image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image.BackgroundImage")));
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image.Location = new System.Drawing.Point(631, 223);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(670, 538);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.image.TabIndex = 17;
            this.image.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(631, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(621, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // SignUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.image);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.companyNameBox);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SignUpView";
            this.Size = new System.Drawing.Size(1540, 845);
            this.Load += new System.EventHandler(this.SignUpView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadButton LoginButton;
        private Telerik.WinControls.UI.RadLabel loginLabel;
        private Telerik.WinControls.UI.RadButton Logo;
        private Telerik.WinControls.UI.RadTextBox companyNameBox;
        private Telerik.WinControls.UI.RadTextBox emailTextBox;
        private Telerik.WinControls.UI.RadTextBox passwordTextBox;
        private Telerik.WinControls.UI.RadLabel SignUp;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.PictureBox pictureBox2;
    }

   
}
