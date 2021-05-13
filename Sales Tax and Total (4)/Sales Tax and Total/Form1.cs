using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Tax_and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double purchaseAmount;          // To hold the user's input of the purchase amount.
            const double STATE_TAX = 0.04;  // The state tax percent as a decimal.
            double amountStateTax;          // The dollar amount of state tax being added to the total.
            const double COUNTY_TAX = 0.02; // The county tax percent as a decimal.
            double amountCountyTax;         // The dollar amount of county tax being added to the total.
            double totalSalesTax;           // The total of both sales taxes together (state and county).
            double totalSaleCost;           // The total of the purchase price and the two tax amounts.

            // To bring in the user's input into the variable purchaseAmount.
            purchaseAmount = double.Parse(amountOfPurchaseTextBox.Text);

            // To calculate the state tax being applied to the purchase amount.
            amountStateTax = purchaseAmount * STATE_TAX;

            // To output the state tax amount.
            calculatedStateTaxLabel.Text = amountStateTax.ToString("c");

            // To calculate the county tax being applied to the purchase amount.
            amountCountyTax = purchaseAmount * COUNTY_TAX;

            // To output the county tax amount.
            calculatedCountyTaxLabel.Text = amountCountyTax.ToString("c");

            // To calculate the total of the two tax amounts together.
            totalSalesTax = amountStateTax + amountCountyTax;

            // To display the total of the two tax amounts.
            calculatedTotalSalesTaxLabel.Text = totalSalesTax.ToString("c");
             
            // To calculate the total cost (purchase price and two taxes added together).
            totalSaleCost = totalSalesTax + purchaseAmount;

            // To display the total cost.
            calculatedTotalOfSalesLabel.Text = totalSaleCost.ToString("c");

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // To clear all input and output text boxes and labels.
            amountOfPurchaseTextBox.Text = "";
            calculatedCountyTaxLabel.Text = "";
            calculatedStateTaxLabel.Text = "";
            calculatedTotalOfSalesLabel.Text = "";
            calculatedTotalSalesTaxLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // To close the form.
            this.Close();
        }
    }
}
