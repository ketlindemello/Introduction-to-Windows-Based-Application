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
    public partial class Exercise2Form : Form
    {
        private string _selectionString;

        public Exercise2Form(String selectionString)
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this._selectionString = selectionString;
            //this.SelectionStringLabel.Text = _selectionString;
        }

        private int inputCheck(TextBox txt)
        {
            int testValue = 0;
            while (int.TryParse(txt.Text, out testValue) == false)
            {
                MessageBox.Show("Value for X and Y must be a whole numeric number!");
                txt.Text = "0";
                txt.Focus();
            }
            return testValue;
        }

        private void reposition_Click(object sender, EventArgs e)
        {
            int xValue = inputCheck(xCoordinate);
            int yValue = inputCheck(yCoordinate);
            Location = new Point(xValue, yValue);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            xCoordinate.Text = String.Empty;
            yCoordinate.Text = String.Empty;
            int xLocation = 0;
            int yLocation = 0;
            Location = new Point(xLocation, yLocation);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
