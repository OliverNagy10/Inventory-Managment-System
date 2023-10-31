
namespace Inventory_Managment_System.Checkout_Management
{
    partial class CheckoutView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.basketListView = new System.Windows.Forms.ListView();
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.exitButton = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.nameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.addItemButton = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.AmountHolderLabel = new Telerik.WinControls.UI.RadLabel();
            this.removeFromBasketButtom = new Telerik.WinControls.UI.RadButtonTextBox();
            this.payWithCashButton = new Telerik.WinControls.UI.RadButtonTextBox();
            this.payWithCardButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountHolderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeFromBasketButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCashButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCardButton)).BeginInit();
            this.SuspendLayout();
            // 
            // basketListView
            // 
            this.basketListView.HideSelection = false;
            this.basketListView.Location = new System.Drawing.Point(80, 114);
            this.basketListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basketListView.Name = "basketListView";
            this.basketListView.Size = new System.Drawing.Size(737, 223);
            this.basketListView.TabIndex = 8;
            this.basketListView.UseCompatibleStateImageBehavior = false;
            this.basketListView.View = System.Windows.Forms.View.List;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(23, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 32);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "BACK";
            this.exitButton.ThemeName = "Windows11Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(223, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 22);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "BARCODE";
            this.radLabel1.ThemeName = "Windows11Dark";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(317, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(358, 32);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.ThemeName = "Windows11Dark";
            // 
            // addItemButton
            // 
            this.addItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addItemButton.Location = new System.Drawing.Point(714, 12);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(128, 32);
            this.addItemButton.TabIndex = 15;
            this.addItemButton.Text = "ADD TO BASKET";
            this.addItemButton.ThemeName = "Windows11Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(570, 459);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(105, 22);
            this.radLabel2.TabIndex = 16;
            this.radLabel2.Text = "BASKET TOTAL:";
            this.radLabel2.ThemeName = "Windows11Dark";
            // 
            // AmountHolderLabel
            // 
            this.AmountHolderLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.AmountHolderLabel.Location = new System.Drawing.Point(714, 459);
            this.AmountHolderLabel.Name = "AmountHolderLabel";
            this.AmountHolderLabel.Size = new System.Drawing.Size(28, 22);
            this.AmountHolderLabel.TabIndex = 17;
            this.AmountHolderLabel.Text = "0.0";
            this.AmountHolderLabel.ThemeName = "Windows11Dark";
            // 
            // removeFromBasketButtom
            // 
            this.removeFromBasketButtom.ForeColor = System.Drawing.Color.Red;
            this.removeFromBasketButtom.Location = new System.Drawing.Point(647, 355);
            this.removeFromBasketButtom.Name = "removeFromBasketButtom";
            this.removeFromBasketButtom.Size = new System.Drawing.Size(170, 32);
            this.removeFromBasketButtom.TabIndex = 18;
            this.removeFromBasketButtom.Text = "REMOVE FROM BASKET";
            this.removeFromBasketButtom.ThemeName = "Windows11Dark";
            // 
            // payWithCashButton
            // 
            this.payWithCashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.payWithCashButton.Location = new System.Drawing.Point(23, 449);
            this.payWithCashButton.Name = "payWithCashButton";
            this.payWithCashButton.Size = new System.Drawing.Size(124, 32);
            this.payWithCashButton.TabIndex = 19;
            this.payWithCashButton.Text = "PAY WITH CASH";
            this.payWithCashButton.ThemeName = "Windows11Dark";
            // 
            // payWithCardButton
            // 
            this.payWithCardButton.ForeColor = System.Drawing.Color.Yellow;
            this.payWithCardButton.Location = new System.Drawing.Point(165, 449);
            this.payWithCardButton.Name = "payWithCardButton";
            this.payWithCardButton.Size = new System.Drawing.Size(141, 32);
            this.payWithCardButton.TabIndex = 20;
            this.payWithCardButton.Text = "PAY WITH CARD";
            this.payWithCardButton.ThemeName = "Windows11Dark";
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.Controls.Add(this.payWithCardButton);
            this.Controls.Add(this.payWithCashButton);
            this.Controls.Add(this.removeFromBasketButtom);
            this.Controls.Add(this.AmountHolderLabel);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.basketListView);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckoutView";
            this.Size = new System.Drawing.Size(1540, 845);
            this.Load += new System.EventHandler(this.CheckoutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountHolderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeFromBasketButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCashButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCardButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView basketListView;
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadButtonTextBox exitButton;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox nameTextBox;
        private Telerik.WinControls.UI.RadButtonTextBox addItemButton;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel AmountHolderLabel;
        private Telerik.WinControls.UI.RadButtonTextBox removeFromBasketButtom;
        private Telerik.WinControls.UI.RadButtonTextBox payWithCashButton;
        private Telerik.WinControls.UI.RadButton payWithCardButton;
    }
}
