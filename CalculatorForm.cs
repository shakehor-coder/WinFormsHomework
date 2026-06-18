using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsHomework
{
    public partial class CalculatorForm : Form
    {
        private List<string> _history = new List<string>();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculate(string operation)
        {
            if (!double.TryParse(txtInput1.Text, out double val1) || !double.TryParse(txtInput2.Text, out double val2))
            {
                MessageBox.Show("Ошибка: введите корректные числовые значения.");
                return;
            }

            double result = 0;
            bool success = true;

            switch (operation)
            {
                case "+":
                    result = val1 + val2;
                    break;
                case "-":
                    result = val1 - val2;
                    break;
                case "*":
                    result = val1 * val2;
                    break;
                case "/":
                    if (val2 == 0)
                    {
                        MessageBox.Show("Ошибка: деление на ноль невозможно.");
                        success = false;
                    }
                    else
                    {
                        result = val1 / val2;
                    }
                    break;
            }

            if (success)
            {
                string entry = $"{val1} {operation} {val2} = {result}";
                lblResult.Text = $"Результат: {result}";
                _history.Add(entry);
                lstHistory.Items.Add(entry);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => Calculate("+");
        private void btnSub_Click(object sender, EventArgs e) => Calculate("-");
        private void btnMul_Click(object sender, EventArgs e) => Calculate("*");
        private void btnDiv_Click(object sender, EventArgs e) => Calculate("/");
    }
}