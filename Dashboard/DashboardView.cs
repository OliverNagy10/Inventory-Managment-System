using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.Dashboard
{
    public partial class DashboardView : UserControl
    {
        string IDToken;
        private MainForm mainForm;
        public DashboardView
            (string idtoken, MainForm mainForm)
        {
            IDToken = idtoken;
            this.mainForm = mainForm;
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

            mainForm.InitiateProductManager(IDToken);
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }
    }
}
