using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static double CheckInputDouble(TextBox txtLocation)
        {
            double retVal;
            while (double.TryParse(txtLocation.Text, out retVal) == false)
            {
                MessageBox.Show("For Hours only numeric values are accepted");
                txtLocation.Text = "0";
                txtLocation.Focus();
            }

            return retVal;
        }
    }
}
