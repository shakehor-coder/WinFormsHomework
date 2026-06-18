using System;
using System.Windows.Forms;

namespace WinFormsHomework
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            ValidationForm validationForm = new ValidationForm();
            validationForm.Show();
        }
    }
}