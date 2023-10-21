
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
            this.logInButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dontHaveLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(319, 316);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(249, 41);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "Login";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 247);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "password";
            // 
            // dontHaveLabel
            // 
            this.dontHaveLabel.AutoSize = true;
            this.dontHaveLabel.Location = new System.Drawing.Point(319, 416);
            this.dontHaveLabel.Name = "dontHaveLabel";
            this.dontHaveLabel.Size = new System.Drawing.Size(167, 17);
            this.dontHaveLabel.TabIndex = 3;
            this.dontHaveLabel.Text = "Dont Have An Account ? ";
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(492, 412);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(76, 25);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Sign Up ";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.dontHaveLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logInButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1182, 1055);
            this.Load += new System.EventHandler(this.LoginView_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label dontHaveLabel;
        private System.Windows.Forms.Button signUpButton;
    }
}
