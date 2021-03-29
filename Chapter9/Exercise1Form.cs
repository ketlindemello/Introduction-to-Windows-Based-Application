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
    public partial class Exercise1Form : Form
    {
        private string _selectionString;

        public Exercise1Form(String selectionString)
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this._selectionString = selectionString;
            //this.SelectionStringLabel.Text = _selectionString.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameInput;
            nameInput = txtName.Text;

            result.Text = "Congratualations, " + nameInput + ", you retrieved the data!";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            result.Text = String.Empty;
        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
