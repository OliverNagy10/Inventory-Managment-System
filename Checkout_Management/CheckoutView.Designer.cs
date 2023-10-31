
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Description");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Quantity");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Price");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Barcode");
            this.windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            this.exitButton = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.nameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.addItemButton = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.removeFromBasketButtom = new Telerik.WinControls.UI.RadButtonTextBox();
            this.payWithCashButton = new Telerik.WinControls.UI.RadButtonTextBox();
            this.payWithCardButton = new Telerik.WinControls.UI.RadButton();
            this.basketListView = new Telerik.WinControls.UI.RadListView();
            this.AmountHolderLabel = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeFromBasketButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCashButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountHolderLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(288, 727);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 32);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "BACK";
            this.exitButton.ThemeName = "Windows11Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(415, 54);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 22);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "BARCODE";
            this.radLabel1.ThemeName = "Windows11Dark";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(522, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(514, 32);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.ThemeName = "Windows11Dark";
            // 
            // addItemButton
            // 
            this.addItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addItemButton.Location = new System.Drawing.Point(1164, 44);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(121, 32);
            this.addItemButton.TabIndex = 15;
            this.addItemButton.Text = "ADD TO BASKET";
            this.addItemButton.ThemeName = "Windows11Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(1019, 615);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 22);
            this.radLabel2.TabIndex = 16;
            this.radLabel2.Text = "TOTAL";
            this.radLabel2.ThemeName = "Windows11Dark";
            // 
            // removeFromBasketButtom
            // 
            this.removeFromBasketButtom.ForeColor = System.Drawing.Color.Red;
            this.removeFromBasketButtom.Location = new System.Drawing.Point(1115, 507);
            this.removeFromBasketButtom.Name = "removeFromBasketButtom";
            this.removeFromBasketButtom.Size = new System.Drawing.Size(170, 32);
            this.removeFromBasketButtom.TabIndex = 18;
            this.removeFromBasketButtom.Text = "REMOVE FROM BASKET";
            this.removeFromBasketButtom.ThemeName = "Windows11Dark";
            // 
            // payWithCashButton
            // 
            this.payWithCashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.payWithCashButton.Location = new System.Drawing.Point(1147, 736);
            this.payWithCashButton.Name = "payWithCashButton";
            this.payWithCashButton.Size = new System.Drawing.Size(138, 32);
            this.payWithCashButton.TabIndex = 19;
            this.payWithCashButton.Text = "PAY WITH CASH";
            this.payWithCashButton.ThemeName = "Windows11Dark";
            // 
            // payWithCardButton
            // 
            this.payWithCardButton.ForeColor = System.Drawing.Color.Yellow;
            this.payWithCardButton.Location = new System.Drawing.Point(942, 736);
            this.payWithCardButton.Name = "payWithCardButton";
            this.payWithCardButton.Size = new System.Drawing.Size(141, 32);
            this.payWithCardButton.TabIndex = 20;
            this.payWithCardButton.Text = "PAY WITH CARD";
            this.payWithCardButton.ThemeName = "Windows11Dark";
            // 
            // basketListView
            // 
            listViewDetailColumn6.HeaderText = "Name";
            listViewDetailColumn7.HeaderText = "Description";
            listViewDetailColumn8.HeaderText = "Quantity";
            listViewDetailColumn9.HeaderText = "Price";
            listViewDetailColumn10.HeaderText = "Barcode";
            this.basketListView.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn6,
            listViewDetailColumn7,
            listViewDetailColumn8,
            listViewDetailColumn9,
            listViewDetailColumn10});
            this.basketListView.GroupItemSize = new System.Drawing.Size(200, 40);
            this.basketListView.ItemSize = new System.Drawing.Size(200, 36);
            this.basketListView.ItemSpacing = -1;
            this.basketListView.Location = new System.Drawing.Point(288, 130);
            this.basketListView.Name = "basketListView";
            this.basketListView.Size = new System.Drawing.Size(997, 341);
            this.basketListView.TabIndex = 21;
            this.basketListView.ThemeName = "Windows11Dark";
            this.basketListView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // AmountHolderLabel
            // 
            this.AmountHolderLabel.Location = new System.Drawing.Point(1115, 605);
            this.AmountHolderLabel.Name = "AmountHolderLabel";
            this.AmountHolderLabel.ReadOnly = true;
            this.AmountHolderLabel.Size = new System.Drawing.Size(170, 32);
            this.AmountHolderLabel.TabIndex = 22;
            this.AmountHolderLabel.ThemeName = "Windows11Dark";
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.Controls.Add(this.AmountHolderLabel);
            this.Controls.Add(this.basketListView);
            this.Controls.Add(this.payWithCardButton);
            this.Controls.Add(this.payWithCashButton);
            this.Controls.Add(this.removeFromBasketButtom);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.exitButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckoutView";
            this.Size = new System.Drawing.Size(1540, 845);
            this.Load += new System.EventHandler(this.CheckoutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeFromBasketButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCashButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payWithCardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountHolderLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadButtonTextBox exitButton;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox nameTextBox;
        private Telerik.WinControls.UI.RadButtonTextBox addItemButton;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButtonTextBox removeFromBasketButtom;
        private Telerik.WinControls.UI.RadButtonTextBox payWithCashButton;
        private Telerik.WinControls.UI.RadButton payWithCardButton;
        private Telerik.WinControls.UI.RadListView basketListView;
        private Telerik.WinControls.UI.RadTextBox AmountHolderLabel;
    }
}
