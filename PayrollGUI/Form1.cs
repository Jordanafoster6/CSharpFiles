using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            double ssn = double.Parse(sscBox.Text);
            double rate = double.Parse(rateBox.Text);
            double hours = double.Parse(hoursBox.Text);
            double gross = rate * hours;
            double fed = gross * .15;
            double state = (gross * .05);
            double net = gross - (fed + state);
            lblName.Text = name;
            lblSsn.Text = ssn.ToString();
            lblGross.Text = gross.ToString("C");
            lblFed.Text = fed.ToString("C");
            lblState.Text = state.ToString("C");
            lblNet.Text = net.ToString("C");


             
        }
    }
}
