
namespace Inventory_Managment_System.ProductManagement
{
    partial class ProductManagementView
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
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.supplierBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.productListView = new System.Windows.Forms.ListView();
            this.ProductCostLabel = new System.Windows.Forms.Label();
            this.procutCostTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(34, 81);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(97, 25);
            this.ProductsLabel.TabIndex = 0;
            this.ProductsLabel.Text = "Products";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(335, 28);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(54, 19);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "search";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Gray;
            this.SearchBox.Location = new System.Drawing.Point(409, 25);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(180, 25);
            this.SearchBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(607, 23);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gray;
            this.backButton.Location = new System.Drawing.Point(763, 733);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 27);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(163, 344);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 19);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(150, 392);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 19);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(150, 443);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(66, 19);
            this.supplierLabel.TabIndex = 9;
            this.supplierLabel.Text = "Supplier";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(93, 575);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(146, 19);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Product Retail Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(150, 611);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(70, 19);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Gray;
            this.nameBox.Location = new System.Drawing.Point(252, 344);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 25);
            this.nameBox.TabIndex = 12;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.Gray;
            this.descriptionBox.Location = new System.Drawing.Point(252, 386);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(200, 25);
            this.descriptionBox.TabIndex = 13;
            // 
            // supplierBox
            // 
            this.supplierBox.BackColor = System.Drawing.Color.Gray;
            this.supplierBox.Location = new System.Drawing.Point(252, 437);
            this.supplierBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(200, 25);
            this.supplierBox.TabIndex = 14;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.Gray;
            this.priceBox.Location = new System.Drawing.Point(252, 565);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(163, 25);
            this.priceBox.TabIndex = 15;
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.Color.Gray;
            this.quantityBox.Location = new System.Drawing.Point(252, 605);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 25);
            this.quantityBox.TabIndex = 16;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.Location = new System.Drawing.Point(353, 649);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 27);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.Location = new System.Drawing.Point(472, 649);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 27);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(590, 649);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 27);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(148, 484);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(66, 19);
            this.barcodeLabel.TabIndex = 22;
            this.barcodeLabel.Text = "Barcode";
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(252, 481);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(200, 25);
            this.barcodeBox.TabIndex = 23;
            // 
            // productListView
            // 
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(39, 109);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(825, 185);
            this.productListView.TabIndex = 24;
            this.productListView.UseCompatibleStateImageBehavior = false;
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.AutoSize = true;
            this.ProductCostLabel.Location = new System.Drawing.Point(131, 539);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(99, 19);
            this.ProductCostLabel.TabIndex = 25;
            this.ProductCostLabel.Text = "Product Cost";
            // 
            // procutCostTextBox
            // 
            this.procutCostTextBox.Location = new System.Drawing.Point(252, 533);
            this.procutCostTextBox.Name = "procutCostTextBox";
            this.procutCostTextBox.Size = new System.Drawing.Size(200, 25);
            this.procutCostTextBox.TabIndex = 26;
            // 
            // ProductManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.procutCostTextBox);
            this.Controls.Add(this.ProductCostLabel);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.barcodeBox);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.supplierBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductManagementView";
            this.Size = new System.Drawing.Size(897, 794);
            this.Load += new System.EventHandler(this.ProductManagementView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox supplierBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Label ProductCostLabel;
        private System.Windows.Forms.TextBox procutCostTextBox;
    }
}
