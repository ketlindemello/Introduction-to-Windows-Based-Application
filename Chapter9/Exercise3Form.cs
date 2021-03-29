using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9
{
    public partial class Exercise3Form : Form
    {
        private string _selectionString;
        public Exercise3Form(String selectionString)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this._selectionString = selectionString;


        }

        private double inputCheck(TextBox txt)
        {
            double testValue = 0.0;
            while (double.TryParse(txt.Text, out testValue) == false)
            {
                MessageBox.Show("Gas used and Miles driven must be numeric.");
                txt.Text = "0.0";
                txt.Focus();
            }
            return testValue;

        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            double miles = inputCheck(txtMiles);
            double gallons = inputCheck(txtGas);

            if (miles > 0)
            {
                resultDisplay.Text = ("The average MPG for a trip to " + txtDestination.Text + " is " + (gallons / miles).ToString() + " MPG");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtDestination.Text = String.Empty;
            txtGas.Text = String.Empty;
            txtMiles.Text = String.Empty;
            resultDisplay.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
