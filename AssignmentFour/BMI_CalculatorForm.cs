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
    public partial class BMI_CalculatorForm : Form
    {
        public BMI_CalculatorForm()
        {
            InitializeComponent();
        }

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
    }
}
