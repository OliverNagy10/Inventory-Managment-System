﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Inventory_Managment_System.ProductManagement;

namespace Inventory_Managment_System
{
    public class ProductController
    {
        private ProductModel productModel;
        private ProductManagementView productView;
        private FirestoreDb db;
        private string IDToken;
        private MainForm mainForm;

        public ProductController(FirestoreDb firestoreDb, string idToken, ProductManagementView view, MainForm mainForm)
        {
            db = firestoreDb;
            IDToken = idToken;
            productModel = new ProductModel(db, IDToken);
            productView = view;
            this.mainForm = mainForm;

            productView.SearchButtonClicked += async (sender, args) => await SearchProductAsync();
            // Attach event handler for the Add button click event in the view
            productView.AddButtonClicked += async (sender, args) => await AddProductAsync();
            productView.SaveButtonClicked += async (sender, args) => await SaveProductAsync();
            productView.DeleteButtonClicked += async (sender, args) => await SaveProductAsync();
            productView.BackButtonClicked += async (sender, args) => Back_Click();

            // Start loading product names as soon as the controller is created
            GetProductNamesAsync();

        }

        public async Task AddProductAsync()
        {
            string productName = productView.GetName();
            string description = productView.GetDescription();
            string supplier = productView.GetSupplier();
            double price = productView.GetPrice();
            int barcode = productView.GetBarcode();
            int quantity = productView.GetQuantity();

            string resultMessage = await productModel.AddProductAsync(productName, description, supplier, price, quantity, barcode);

            if (resultMessage.Contains("Error"))
            {
                productView.ShowError(resultMessage);
            }
            else
            {
                GetProductNamesAsync();
                productView.ShowSuccess(resultMessage);
            }
        }

        public async Task SaveProductAsync()
        {
            string productName = productView.GetSearchQuery();
            string name = productView.GetName();
            string description = productView.GetDescription();
            string supplier = productView.GetSupplier();
            double price = productView.GetPrice();
            int quantity = productView.GetQuantity();
            int barcode = productView.GetBarcode();

            string resultMessage = await productModel.UpdateProductAsync(productName, name, description, supplier, price, quantity, barcode);

            if (resultMessage.Contains("Error"))
            {
                productView.ShowError(resultMessage);
            }
            else
            {
                productView.ShowSuccess(resultMessage);
            }
        }

        public async Task DeleteProductAsync()
        {
            string productName = productView.GetSearchQuery();

            if (!string.IsNullOrEmpty(productName))
            {
                var resultMessage = await productModel.DeleteProductAsync(productName);

                if (resultMessage.Contains("Error"))
                {
                    productView.ShowError(resultMessage);
                }
                else
                {
                    productView.ShowSuccess(resultMessage);
                    GetProductNamesAsync();
                    // Clear the text fields after deletion
                    productView.ClearTextFields();
                }
            }
            else
            {
                productView.ShowError("Please enter a product name to delete.");
            }
        }

        public async Task GetProductNamesAsync()
        {
            var productNames = await productModel.GetAllProductNamesAsync();

            if (productNames.Count > 0)
            {
                productView.PopulateProductListView(productNames);
            }
            else
            {
                productView.ShowError("No products found.");
            }
        }
        private void Back_Click()
        {
            mainForm.InitiateDashboardView(IDToken);
        }

        public async Task SearchProductAsync()
        {
            string productName = productView.GetSearchQuery(); // Add a GetSearchQuery method to your view

            if (!string.IsNullOrEmpty(productName))
            {
                var productDetails = await productModel.SearchProductAsync(productName);

                if (productDetails.Item1 != null)
                {
                    // Populate the textboxes with the product details
                    productView.SetName(productDetails.Item1);
                    productView.SetDescription(productDetails.Item2);
                    productView.SetSupplier(productDetails.Item3);
                    productView.SetBarCode(productDetails.Item4);
                    productView.SetPrice(productDetails.Item5);
                    productView.SetQuantity(productDetails.Item6);
                }
                else
                {
                    productView.ShowError("Product not found.");
                }
            }
            else
            {
                productView.ShowError("Please enter a product name to search.");
            }
        }

    }
}


    

