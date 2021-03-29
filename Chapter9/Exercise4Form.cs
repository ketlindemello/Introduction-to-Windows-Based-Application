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
    public partial class Exercise4Form : Form
    {
        private string _selectionString;
        public Exercise4Form(String selectionString)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this._selectionString = selectionString;



        }


        private int inputCheck(TextBox txt)
        {
            int testValue = 0;
            while (int.TryParse(txt.Text, out testValue) == false)
            {
                
                txt.Text = "0";
                txt.Focus();
                //result.Text = "'Value must be numeric and > 0'";
            }
            return testValue; 
        }
        



        private void addButton_Click(object sender, EventArgs e)
        {
            double value1 = inputCheck(txtValue1);
            double value2 = inputCheck(txtValeu2);
            if(value1 <= 0 || value2 <= 0)
            {
                result.Text = "'Value must be numeric and > 0'";
                result.ForeColor = Color.Red;
            }
            else
            {
                result.Text = (value1 + value2).ToString();
                result.ForeColor = Color.Yellow;
            }
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            double value1 = inputCheck(txtValue1);
            double value2 = inputCheck(txtValeu2);
            if (value1 <= 0 || value2 <= 0)
            {
                result.Text = "'Value must be numeric and > 0'";
                result.ForeColor = Color.Red;
            }
            else
            {
                result.Text = (value1 * value2).ToString();
                result.ForeColor = Color.Yellow;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValeu2.Text = String.Empty;
            txtValue1.Text = String.Empty;
            result.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
