using Google.Cloud.Firestore;
using Inventory_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Inventory_Managment_System
{
    public partial class Dashboard : Form
    {
        string IDToken;
        public Dashboard(string idtoken)
        {
            IDToken = idtoken;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockTrackingButton_Click(object sender, EventArgs e)
        {

        }

        private void productMangementButton_Click(object sender, EventArgs e)
        {
            FirestoreDb firestoreDb = FirestoreDb.Create("inventory-management-sys-df9e8");
            ProductManagementView pm = new ProductManagementView();
            ProductController controller = new ProductController(firestoreDb, IDToken, pm);
            pm.Show();
            this.Hide();
        }
    }
}
