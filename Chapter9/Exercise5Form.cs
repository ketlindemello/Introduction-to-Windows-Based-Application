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
    public partial class Exercise5Form : Form
    {
        private string _selectionString;
        public Exercise5Form(String selectionString)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this._selectionString = selectionString;


        }



        private void submitButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Fullname = txtName.Text;
            employee.Address = txtAddress.Text;
            employee.City = txtCity.Text;
            employee.State = txtState.Text;
            employee.Zip = txtZip.Text;
            employee.Hours = Program.CheckInputDouble(txtHours);

            MessageBox.Show(employee.ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
             foreach(Control control in this.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    control.Text = String.Empty;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
