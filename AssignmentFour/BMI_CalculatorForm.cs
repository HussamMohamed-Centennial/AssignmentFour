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
            HeightInputTypeLabel.Text = "My Height in Inches";
            HeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 12.0f);
            WeightInputTypeLabel.Text = "My Weight in Pounds";
            WeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 12.0f);
            ReturnToDefault();
        }

        /// <summary>
        /// This event handler will set different  values for different properties based on user choice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightInputTypeLabel.Text = "My Height in Meters";
            HeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 12.0f);
            WeightInputTypeLabel.Text = "My Weight in KG";
            WeightInputTypeLabel.Font = new Font("Microsoft Sans Serif", 12.0f);
            ReturnToDefault();
        }


        /// <summary>
        /// This event handler will ensure the focus will be on single text box each time based on user choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InchesInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _inchesInputTextBoxSelected = true;
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
            //Debug.WriteLine("weight select fired");
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button numberButton = sender as Button;

            if (_inchesInputTextBoxSelected == true)
            {
                if (numberButton.Text == ".")
                {
                    if (!HeightInputTextBox.Text.Contains("."))
                    {
                        HeightInputTextBox.Text += numberButton.Text;
                    }
                }
                else
                {
                    HeightInputTextBox.Text += numberButton.Text;
                }
            }
            
            if (_weightInputTextBoxSelected == true)
            {
                if (numberButton.Text == ".")
                {
                    if (!WeightInputTextBox.Text.Contains("."))
                    {
                        WeightInputTextBox.Text += numberButton.Text;
                    }
                }
                else
                {
                    WeightInputTextBox.Text += numberButton.Text;
                }


            }
        }

        /// <summary>
        /// This event handler will call return to default method to allow clear button to clear
        /// all user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
         ReturnToDefault();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (ImperialRadioButton.Checked)
            {
                
                double weightValue = Convert.ToDouble(WeightInputTextBox.Text);
                Debug.WriteLine(weightValue);
                double heightVlaue = Convert.ToDouble(HeightInputTextBox.Text);
                Debug.WriteLine(heightVlaue);
                double result = ((weightValue * 703) / (heightVlaue * heightVlaue));
                double finalResult = Math.Round(result,2);
                BMI_ResultTextBox.Text = Convert.ToString(finalResult);
                DisplayTheComment(finalResult);
            }

            if (MetricRadioButton.Checked)
            {
                double weightValue = Convert.ToDouble(WeightInputTextBox.Text);
                Debug.WriteLine(weightValue);
                double heightVlaue = Convert.ToDouble(HeightInputTextBox.Text);
                Debug.WriteLine(heightVlaue);
                double result = (weightValue / (heightVlaue * heightVlaue));
                double finalResult = Math.Round(result, 2);
                BMI_ResultTextBox.Text = Convert.ToString(finalResult);
                DisplayTheComment(finalResult);
            }
        }

        /// <summary>
        /// This method will clear all user input and selections
        /// </summary>
        private void ReturnToDefault()
        {
            HeightInputTextBox.Clear();
            WeightInputTextBox.Clear();
            BMI_ResultTextBox.Clear();
            ResultMeaningTextBox.Clear();
            _inchesInputTextBoxSelected = false;
            _weightInputTextBoxSelected = false;
        }

        private void DisplayTheComment(double result)
        {
            if (result < 18.5)
            {
                ResultMeaningTextBox.Text = "Underweight";
            }
            if((result>=18.5) && (result <24.9))
            {
                ResultMeaningTextBox.Text = "Normal";
            }

            if ((result > 25) && (result < 29.9))
            {
                ResultMeaningTextBox.Text = "Overweight";
            }

            if (result >= 30)
            {
                ResultMeaningTextBox.Text = "Obese";
            }
        }


        /// <summary>
        /// This event handler will validate the text box input which it should be numbers only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightInputTextBox_Leave(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(HeightInputTextBox.Text, "[^0-9]"))
            {
                HeightInputTextBox.Focus();
                MessageBox.Show("Height should be number Only!");
            }
            
        }

        private void WeightInputTextBox_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(WeightInputTextBox.Text, "[^0-9-(.)]"))
            {
                WeightInputTextBox.Focus();
                MessageBox.Show("Weight should be number Only!");
            }
        }

        /// <summary>
        /// This event handler will implement  back space function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (_weightInputTextBoxSelected == true)
            {
                if (WeightInputTextBox.Text != String.Empty)
                {
                    WeightInputTextBox.Text = WeightInputTextBox.Text.Remove(WeightInputTextBox.Text.Length - 1);
                }
            }
            if (_inchesInputTextBoxSelected == true)
            {
                if (HeightInputTextBox.Text != String.Empty)
                {
                    HeightInputTextBox.Text = HeightInputTextBox.Text.Remove(HeightInputTextBox.Text.Length - 1);
                }
            }

        }
    }
}
