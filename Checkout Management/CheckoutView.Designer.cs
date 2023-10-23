
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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.payWithCashButton = new System.Windows.Forms.Button();
            this.payWithCardButton = new System.Windows.Forms.Button();
            this.AmountHolderLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.basketListView = new System.Windows.Forms.ListView();
            this.removeFromBasketButtom = new System.Windows.Forms.Button();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(883, 560);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(48, 17);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total: ";
            // 
            // payWithCashButton
            // 
            this.payWithCashButton.Location = new System.Drawing.Point(31, 554);
            this.payWithCashButton.Name = "payWithCashButton";
            this.payWithCashButton.Size = new System.Drawing.Size(123, 23);
            this.payWithCashButton.TabIndex = 2;
            this.payWithCashButton.Text = "Pay with Cash";
            this.payWithCashButton.UseVisualStyleBackColor = true;
            // 
            // payWithCardButton
            // 
            this.payWithCardButton.Location = new System.Drawing.Point(179, 554);
            this.payWithCardButton.Name = "payWithCardButton";
            this.payWithCardButton.Size = new System.Drawing.Size(142, 23);
            this.payWithCardButton.TabIndex = 3;
            this.payWithCardButton.Text = "Pay with Card";
            this.payWithCardButton.UseVisualStyleBackColor = true;
            // 
            // AmountHolderLabel
            // 
            this.AmountHolderLabel.AutoSize = true;
            this.AmountHolderLabel.Location = new System.Drawing.Point(948, 560);
            this.AmountHolderLabel.Name = "AmountHolderLabel";
            this.AmountHolderLabel.Size = new System.Drawing.Size(28, 17);
            this.AmountHolderLabel.TabIndex = 4;
            this.AmountHolderLabel.Text = "0.0";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(583, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(468, 38);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(61, 17);
            this.barcodeLabel.TabIndex = 6;
            this.barcodeLabel.Text = "Barcode";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(803, 38);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(150, 23);
            this.addItemButton.TabIndex = 7;
            this.addItemButton.Text = "Add to basket";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // basketListView
            // 
            this.basketListView.HideSelection = false;
            this.basketListView.Location = new System.Drawing.Point(107, 140);
            this.basketListView.Name = "basketListView";
            this.basketListView.Size = new System.Drawing.Size(981, 274);
            this.basketListView.TabIndex = 8;
            this.basketListView.UseCompatibleStateImageBehavior = false;
            this.basketListView.View = System.Windows.Forms.View.List;
            // 
            // removeFromBasketButtom
            // 
            this.removeFromBasketButtom.Location = new System.Drawing.Point(969, 433);
            this.removeFromBasketButtom.Name = "removeFromBasketButtom";
            this.removeFromBasketButtom.Size = new System.Drawing.Size(179, 23);
            this.removeFromBasketButtom.TabIndex = 9;
            this.removeFromBasketButtom.Text = "Remove from basket";
            this.removeFromBasketButtom.UseVisualStyleBackColor = true;
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Location = new System.Drawing.Point(926, 560);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(16, 17);
            this.DollarLabel.TabIndex = 10;
            this.DollarLabel.Text = "$";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(31, 32);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.removeFromBasketButtom);
            this.Controls.Add(this.basketListView);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.AmountHolderLabel);
            this.Controls.Add(this.payWithCardButton);
            this.Controls.Add(this.payWithCashButton);
            this.Controls.Add(this.TotalLabel);
            this.Name = "CheckoutView";
            this.Size = new System.Drawing.Size(1193, 605);
            this.Load += new System.EventHandler(this.CheckoutView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button payWithCashButton;
        private System.Windows.Forms.Button payWithCardButton;
        private System.Windows.Forms.Label AmountHolderLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListView basketListView;
        private System.Windows.Forms.Button removeFromBasketButtom;
        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Button exitButton;
    }
}
