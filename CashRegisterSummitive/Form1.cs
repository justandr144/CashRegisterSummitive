using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegisterSummitive
{
    public partial class Form1 : Form
    {
        //Global Variables
        double burgerAmount = 0;
        double drinkAmount = 0;
        double friesAmount = 0;
        double burgerCost = 3.99;
        double drinkCost = 1.99;
        double friesCost = 2.50;
        double taxBase = 0.13;
        double burgerTotal = 0;
        double drinkTotal = 0;
        double friesTotal = 0;
        double subTotal = 0;
        double taxAmount = 0;
        double totalCost = 0;
        double tenderedAmount = 0;
        double changeAmount = 0;
        int orderNumber = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void CostButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            try
            {
                burgerAmount = Convert.ToInt32(burgerText.Text);
                drinkAmount = Convert.ToInt32(drinkText.Text);
                friesAmount = Convert.ToInt32(friesText.Text);
            }
            catch
            {
                errorLabel.Text = "Please enter whole values into the three food boxes.";
            }
            burgerTotal = burgerAmount * burgerCost;
            drinkTotal = drinkAmount * drinkCost;
            friesTotal = friesAmount * friesCost;

            subTotal = burgerTotal + drinkTotal + friesTotal;
            subTotalCostLabel.Text = $"{subTotal.ToString("C")}";

            taxAmount = subTotal * taxBase;
            taxCostLabel.Text = $"{taxAmount.ToString("C")}";

            totalCost = subTotal + taxAmount;
            totalCostLabel.Text = $"{totalCost.ToString("C")}";
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            try
            {
                tenderedAmount = Convert.ToDouble(tenderedText.Text);
            }
            catch
            {
                errorLabel.Text = "Please enter whole values into the three food boxes.";
                errorLabel.Text += $"\nAlso press the calculate totals before this one";
            }

            if (tenderedAmount >= totalCost)
            {
                changeAmount = tenderedAmount - totalCost;
                changeLabel.Text = "Change:";
                changeValueLabel.Text = $"{changeAmount.ToString("C")}";
            }
            else
            {
                changeAmount = totalCost - tenderedAmount;
                changeLabel.Text = "Owed";
                changeValueLabel.Text = $"{changeAmount.ToString("C")}";
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            titleLabel.ForeColor = Color.Black;
            Refresh();
            Thread.Sleep(500);

            orderNumberLabel.Text = $"Order Number: {orderNumber}";
            Refresh();
            Thread.Sleep(500);

            dateLabel.ForeColor = Color.Black;
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text = $"Burgers x {burgerAmount}";
            rightReceiptLabel.Text = $"{burgerTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\nDrinks x {drinkAmount}";
            rightReceiptLabel.Text += $"\n{drinkTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\nFries x {friesAmount}";
            rightReceiptLabel.Text += $"\n{friesTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\n\nSub Total:";
            rightReceiptLabel.Text += $"\n\n{subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\nTax:";
            rightReceiptLabel.Text += $"\n{taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\nTotal:";
            rightReceiptLabel.Text += $"\n{totalCost.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\n\nTendered:";
            rightReceiptLabel.Text += $"\n\n{tenderedAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += $"\nChange:";
            rightReceiptLabel.Text += $"\n{changeAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            leftReceiptLabel.Text += "\n\nHave a nice day!";
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            orderNumber++;
            titleLabel.ForeColor = Color.White;
            orderNumberLabel.Text = "";
            dateLabel.ForeColor = Color.White;
            leftReceiptLabel.Text = "";
            rightReceiptLabel.Text = "";

            subTotalCostLabel.Text = "";
            taxCostLabel.Text = "";
            totalCostLabel.Text = "";
            changeValueLabel.Text = "";

            burgerTotal = 0;
            drinkTotal = 0;
            friesTotal = 0;
            subTotal = 0;
            taxAmount = 0;
            totalCost = 0;
            changeAmount = 0;
        }

    }
}
