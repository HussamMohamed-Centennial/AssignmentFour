using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFour
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This the timer event handler for splash form , which will hide the splash form and open BMI form after 3 second 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.BmiCalculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
