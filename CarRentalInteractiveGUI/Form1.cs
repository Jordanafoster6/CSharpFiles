using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double RENTAL = 20;
            const double GAS = 0.25;
            double days = 
            double this.days =
        }
    }
}
double rentalFee = days * RENTAL;
double gasFee = miles * GAS;
Console.WriteLine("Your total car rental fee is " + (rentalFee + gasFee).ToString("c"));
           // double total = (days * RENTAL) + (miles * GAS);
           // double amount = ToString(total);