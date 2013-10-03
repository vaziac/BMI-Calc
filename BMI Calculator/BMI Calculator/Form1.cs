using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        Boolean isValid = true;
        string output = "There were errors in your input:";
        double weight = 0;
        double heightf = 0;
        double heighti = 0;
        double heighttotal = 0;
        double bmi = 0;
        
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
// Calculate button        
        private void calcButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(weightBox.Text, out weight))
            {
                output += "\nPlease enter weight as a number.";
                isValid = false;
            }

            if (!double.TryParse(heightFeetBox.Text, out heightf))
            {
                output += "\nPlease enter height in feet.";
                isValid = false;
            }

            if (!double.TryParse(heightInchesBox.Text, out heighti))
            {
                output += "\nPlease enter height in inches.";
                isValid = false;
            }

            if (heighti > 11)
            {
                output += "\nPlease enter inches less than 12.";
                isValid = false;
            }

            if (isValid == true)
            {
                heighttotal = (heightf * 12) + heighti;
                bmi = (weight / (heighttotal * heighttotal)) * 703;
                MessageBox.Show("You have entered the input in the correct form.");
                bmi = Math.Round(bmi, 1);
                bmiLabel.Text = "" + bmi;
                isValid = true;
            }

            if (isValid == false)
            {
                MessageBox.Show("" + output);
                output = "There were errors in your input:";
                isValid = true;
            }    
        }
// Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            bmiLabel.Text = "0.0";
            Boolean isValid = true;
            heightFeetBox.Text = "";
            heightInchesBox.Text = "";
            weightBox.Text = "";
            output = "There were errors in your input:";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
