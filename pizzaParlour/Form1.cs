using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaParlour
{
    public partial class background : Form
    {
        double basePrice = 7.00;
        double eachTopping = 1.25;
        double toppingAmount;
        double totalPrice;

        public background()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                toppingAmount = Convert.ToDouble(inputLabel.Text);
                totalPrice = basePrice + toppingAmount * eachTopping;
                totalLabel.Text = $"The price of a pizza with {toppingAmount} is: {totalPrice.ToString("C")}";
            }
            catch
            {
                totalLabel.Text = "Please insert the amount of toppings as a number";
            }

        }
    }
}
