
namespace Inventory_Managment_System.LogIn_Management
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.LogInLabel = new Telerik.WinControls.UI.RadLabel();
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.emailTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.passwordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.signupButton = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Location = new System.Drawing.Point(631, 222);
            pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(773, 541);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // LogInLabel
            // 
            this.LogInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInLabel.AutoSize = false;
            this.LogInLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LogInLabel.Location = new System.Drawing.Point(137, 100);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(10);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(163, 41);
            this.LogInLabel.TabIndex = 5;
            this.LogInLabel.Text = "WELCOME BACK";
            this.LogInLabel.ThemeName = "Windows11Dark";
            // 
            // emailTextBox
            // 
            this.emailTextBox.AutoSize = false;
            this.emailTextBox.Location = new System.Drawing.Point(137, 207);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(276, 32);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.Text = "t@gmail.com";
            this.emailTextBox.ThemeName = "Windows11Dark";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoSize = false;
            this.passwordTextBox.Location = new System.Drawing.Point(137, 294);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(276, 32);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "123456";
            this.passwordTextBox.ThemeName = "Windows11Dark";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(210, 479);
            this.loginButton.Margin = new System.Windows.Forms.Padding(10);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 43);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "LOG IN";
            this.loginButton.ThemeName = "Windows11Dark";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(58, 595);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(180, 22);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Dont have an account yet ?";
            this.radLabel1.ThemeName = "Windows11Dark";
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(244, 593);
            this.signupButton.Margin = new System.Windows.Forms.Padding(10);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(86, 34);
            this.signupButton.TabIndex = 11;
            this.signupButton.Text = "SIGN UP";
            this.signupButton.ThemeName = "Windows11Dark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(631, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.LogInLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1540, 845);
       
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel LogInLabel;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadTextBox emailTextBox;
        private Telerik.WinControls.UI.RadTextBox passwordTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Telerik.WinControls.UI.RadButton loginButton;
        private Telerik.WinControls.UI.RadButton signupButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
