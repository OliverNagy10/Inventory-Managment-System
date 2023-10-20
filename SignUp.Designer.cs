
namespace Inventory_Managment_System
{
    partial class SignUp
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
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(136, 101);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(108, 17);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Company Name";
            // 
            // companyEmailLabel
            // 
            this.companyEmailLabel.AutoSize = true;
            this.companyEmailLabel.Location = new System.Drawing.Point(136, 157);
            this.companyEmailLabel.Name = "companyEmailLabel";
            this.companyEmailLabel.Size = new System.Drawing.Size(105, 17);
            this.companyEmailLabel.TabIndex = 1;
            this.companyEmailLabel.Text = "Company Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(136, 207);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // companyNameBox
            // 
            this.companyNameBox.Location = new System.Drawing.Point(298, 95);
            this.companyNameBox.Name = "companyNameBox";
            this.companyNameBox.Size = new System.Drawing.Size(195, 22);
            this.companyNameBox.TabIndex = 3;
            // 
            // companyEmailBox
            // 
            this.companyEmailBox.Location = new System.Drawing.Point(298, 151);
            this.companyEmailBox.Name = "companyEmailBox";
            this.companyEmailBox.Size = new System.Drawing.Size(195, 22);
            this.companyEmailBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(298, 201);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(195, 22);
            this.passwordBox.TabIndex = 5;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(322, 290);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(140, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create An Account ";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.SignUp_Load);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.companyEmailBox);
            this.Controls.Add(this.companyNameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.companyEmailLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label companyEmailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox companyNameBox;
        private System.Windows.Forms.TextBox companyEmailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button createButton;
    }
}