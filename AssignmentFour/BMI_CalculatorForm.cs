using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFour
{
    public partial class BMI_CalculatorForm : Form
    {
        // PUBLIC PROPERTIES
        public static bool _feetInputTextBoxSelected = false;
        public static bool _inchesInputTextBoxSelected = false;
        public static bool _weightInputTextBoxSelected = false;
        
        public BMI_CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event handler will set different  values for different properties based on user choice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightInputTypeLabel.Text = "Height";
            HeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 11.0f);
            WeightInputTypeLabel.Text = "Weight in Pounds";
            WeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 13.0f);
            FeetLabel.Text = "ft.";
            FeetLabel.Font = new Font("Microsoft Sans Serif", 11.0f);
            InchesLabel.Enabled = true;
            InchesInputTextBox.Enabled = true;
            InchesLabel.Text = "in.";
            InchesLabel.Font = new Font("Microsoft Sans Serif", 11.0f);
        }

        /// <summary>
        /// This event handler will set different  values for different properties based on user choice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightInputTypeLabel.Text = "Height";
            HeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 11.0f);
            WeightInputTypeLabel.Text = "Weight in Kilogram";
            WeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 13.0f);
            FeetLabel.Text = "cm.";
            FeetLabel.Font = new Font("Microsoft Sans Serif", 11.0f);
            InchesLabel.Enabled = false;
            InchesInputTextBox.Enabled = false;
        }

        /// <summary>
        /// This event handler will ensure the focus will be on single text box each time based on user choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FeetInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _feetInputTextBoxSelected = true;
            _inchesInputTextBoxSelected = false;
            _weightInputTextBoxSelected = false;
            //Debug.WriteLine("feet select fired");
        }

        /// <summary>
        /// This event handler will ensure the focus will be on single text box each time based on user choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InchesInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _inchesInputTextBoxSelected = true;
            _feetInputTextBoxSelected = false;
            _weightInputTextBoxSelected = false;
            //Debug.WriteLine("inches select fired");
        }

        /// <summary>
        /// This event handler will ensure the focus will be on single text box each time based on user choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _weightInputTextBoxSelected = true;
            _inchesInputTextBoxSelected = false;
            _feetInputTextBoxSelected = false;
            //Debug.WriteLine("weight select fired");
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button numberButton = sender as Button;

            if (_inchesInputTextBoxSelected == true)
            {
                InchesInputTextBox.Text += numberButton.Text;
            }

            if (_feetInputTextBoxSelected == true)
            {
                FeetInputTextBox.Text += numberButton.Text;
            }

            if (_weightInputTextBoxSelected == true)
            {
                WeightInputTextBox.Text += numberButton.Text;
            }
        }

        /// <summary>
        /// This evemt handler will allow clear button all text field will be clared and public properties will return to the default value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            InchesInputTextBox.Clear();
            FeetInputTextBox.Clear();
            WeightInputTextBox.Clear();
            _feetInputTextBoxSelected = false;
            _inchesInputTextBoxSelected = false;
            _weightInputTextBoxSelected = false;

    }
    }
}
