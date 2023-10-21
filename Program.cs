﻿using Inventory_Management_System;
using System;
using System.Windows.Forms;

namespace Inventory_Managment_System
{

   
    static class Program
    {
        private static MainForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the GOOGLE_APPLICATION_CREDENTIALS environment variable
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"C:\Users\ocsio\Desktop\Inventory Management System\Inventory Managment System\inventory-management-sys-df9e8-firebase-adminsdk-bjow6-42ab060a6b.json");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();

            // Call the InitiateLogin method on the existing MainForm instance
            mainForm.InitiateLogin();

            Application.Run(mainForm);

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", null);
        }
    }
    }

