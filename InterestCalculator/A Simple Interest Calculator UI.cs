using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InterestCalculator
{
    public partial class InterestCalculatorUI : Form
    {
        public InterestCalculatorUI()
        {
            InitializeComponent();
        }
        AmountAndOthersInformation amountInformation=new AmountAndOthersInformation();
        public void TakeInput()
        {
            amountInformation.principalAmount = Convert.ToDouble(principalAmountTextBox.Text);
            amountInformation.interestRate = Convert.ToDouble(interestTextBox.Text);
            amountInformation.time = Convert.ToDouble(timePeriodTextBox.Text);
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            TakeInput();
            int count = 0;
            while (count<amountInformation.time)
            {
                amountInformation.principalAmount += (amountInformation.principalAmount / 100) * amountInformation.interestRate;
                                                    
                count++;
            }
            totalAmountTextBox.Text = amountInformation.principalAmount.ToString();
        }
    }
}
