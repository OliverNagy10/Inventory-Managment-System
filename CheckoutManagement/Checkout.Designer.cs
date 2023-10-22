
namespace Inventory_Managment_System
{
    partial class Checkout
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
            this.barcodeTexBox = new System.Windows.Forms.TextBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.removeFromBasketButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(899, 560);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total";
            // 
            // payWithCashButton
            // 
            this.payWithCashButton.Location = new System.Drawing.Point(106, 554);
            this.payWithCashButton.Name = "payWithCashButton";
            this.payWithCashButton.Size = new System.Drawing.Size(123, 23);
            this.payWithCashButton.TabIndex = 2;
            this.payWithCashButton.Text = "Pay with Cash";
            this.payWithCashButton.UseVisualStyleBackColor = true;
            // 
            // payWithCardButton
            // 
            this.payWithCardButton.Location = new System.Drawing.Point(267, 554);
            this.payWithCardButton.Name = "payWithCardButton";
            this.payWithCardButton.Size = new System.Drawing.Size(142, 23);
            this.payWithCardButton.TabIndex = 3;
            this.payWithCardButton.Text = "Pay with Card";
            this.payWithCardButton.UseVisualStyleBackColor = true;
            // 
            // AmountHolderLabel
            // 
            this.AmountHolderLabel.AutoSize = true;
            this.AmountHolderLabel.Location = new System.Drawing.Point(1006, 560);
            this.AmountHolderLabel.Name = "AmountHolderLabel";
            this.AmountHolderLabel.Size = new System.Drawing.Size(16, 17);
            this.AmountHolderLabel.TabIndex = 4;
            this.AmountHolderLabel.Text = "£";
            // 
            // barcodeTexBox
            // 
            this.barcodeTexBox.Location = new System.Drawing.Point(583, 38);
            this.barcodeTexBox.Name = "barcodeTexBox";
            this.barcodeTexBox.Size = new System.Drawing.Size(180, 22);
            this.barcodeTexBox.TabIndex = 5;
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(107, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(981, 274);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeFromBasketButtom);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.barcodeTexBox);
            this.Controls.Add(this.AmountHolderLabel);
            this.Controls.Add(this.payWithCardButton);
            this.Controls.Add(this.payWithCashButton);
            this.Controls.Add(this.TotalLabel);
            this.Name = "Checkout";
            this.Size = new System.Drawing.Size(1193, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button payWithCashButton;
        private System.Windows.Forms.Button payWithCardButton;
        private System.Windows.Forms.Label AmountHolderLabel;
        private System.Windows.Forms.TextBox barcodeTexBox;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button removeFromBasketButtom;
    }
}
