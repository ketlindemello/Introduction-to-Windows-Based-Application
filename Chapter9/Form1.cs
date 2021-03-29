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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedObject = selectionDropdown.SelectedItem;

            if (selectedObject == null || string.IsNullOrEmpty((string)selectedObject))
            {
                return;
            }

            if (selectedObject.ToString() == "Name Retrieval App")
            {
                Exercise1Form exercise1Form = new Exercise1Form((String)selectedObject);
                exercise1Form.Show();

            }
            else if (selectedObject.ToString() == "Window Reposition")
            {
                Exercise2Form exercise2Form = new Exercise2Form((String)selectedObject);
                exercise2Form.Show();
            }

            else if (selectedObject.ToString() == "Trip Calculator")
            {
                Exercise3Form exercise3Form = new Exercise3Form((String)selectedObject);
                exercise3Form.Show();
            }

            else if (selectedObject.ToString() == "Numeric Check")
            {
                Exercise4Form exercise4Form = new Exercise4Form((String)selectedObject);
                exercise4Form.Show();
            }

            else if (selectedObject.ToString() == "Employee")
            {
                Exercise5Form exercise5Form = new Exercise5Form((String)selectedObject);
                exercise5Form.Show();
            }
        }
    }
}
