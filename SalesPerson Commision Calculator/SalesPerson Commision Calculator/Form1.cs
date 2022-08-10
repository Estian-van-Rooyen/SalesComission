using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalesPerson_Commision_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        double revenue;
        double percentage;
        double commision;
        private void CalculateCommision()
        {
            commision = revenue * percentage / 100;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            revenue = Convert.ToDouble(txtRevenue.Text);
            percentage = Convert.ToDouble(txtCommision.Text);

            CalculateCommision();
            lblOutput.Text = commision.ToString("C2");
        }
    }
}
