
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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyEmailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.companyNameBox = new System.Windows.Forms.TextBox();
            this.companyEmailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.alreadyHaveLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(36, 23);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(194, 32);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Company Name";
            // 
            // companyEmailLabel
            // 
            this.companyEmailLabel.AutoSize = true;
            this.companyEmailLabel.Location = new System.Drawing.Point(36, 162);
            this.companyEmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.companyEmailLabel.Name = "companyEmailLabel";
            this.companyEmailLabel.Size = new System.Drawing.Size(191, 32);
            this.companyEmailLabel.TabIndex = 1;
            this.companyEmailLabel.Text = "Company Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(36, 302);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 32);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // companyNameBox
            // 
            this.companyNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.companyNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyNameBox.Location = new System.Drawing.Point(289, 23);
            this.companyNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.Size = new System.Drawing.Size(340, 37);
            this.companyNameBox.TabIndex = 3;
            // 
            // companyEmailBox
            // 
            this.companyEmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.companyEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyEmailBox.ForeColor = System.Drawing.Color.Yellow;
            this.companyEmailBox.Location = new System.Drawing.Point(289, 157);
            this.companyEmailBox.Margin = new System.Windows.Forms.Padding(0);
            this.companyEmailBox.Name = "companyEmailBox";
            this.companyEmailBox.Size = new System.Drawing.Size(340, 37);
            this.companyEmailBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Location = new System.Drawing.Point(289, 297);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(340, 37);
            this.passwordBox.TabIndex = 5;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(55)))));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(319, 426);
            this.createButton.Margin = new System.Windows.Forms.Padding(5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(294, 75);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create An Account ";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // alreadyHaveLabel
            // 
            this.alreadyHaveLabel.AutoSize = true;
            this.alreadyHaveLabel.Location = new System.Drawing.Point(36, 549);
            this.alreadyHaveLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.alreadyHaveLabel.Name = "alreadyHaveLabel";
            this.alreadyHaveLabel.Size = new System.Drawing.Size(335, 32);
            this.alreadyHaveLabel.TabIndex = 7;
            this.alreadyHaveLabel.Text = "Already Have an Account ? ";
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(55)))));
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Location = new System.Drawing.Point(410, 539);
            this.logInButton.Margin = new System.Windows.Forms.Padding(5);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(131, 53);
            this.logInButton.TabIndex = 8;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.companyEmailBox);
            this.panel1.Controls.Add(this.logInButton);
            this.panel1.Controls.Add(this.companyNameLabel);
            this.panel1.Controls.Add(this.alreadyHaveLabel);
            this.panel1.Controls.Add(this.companyEmailLabel);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.companyNameBox);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 1272);
            this.panel1.TabIndex = 9;
            // 
            // SignUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(214)))), ((int)(((byte)(172)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SignUpView";
            this.Size = new System.Drawing.Size(1920, 630);
            this.Load += new System.EventHandler(this.SignUpView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label companyEmailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.TextBox companyEmailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label alreadyHaveLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Panel panel1;
    }

   
}
