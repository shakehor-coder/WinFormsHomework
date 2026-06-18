using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsHomework
{
    public partial class ValidationForm : Form
    {
        private ErrorProvider errorProvider;

        public ValidationForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "имя не может быть пустым");
                isValid = false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 18)
            {
                errorProvider.SetError(txtAge, "возраст должен быть числом 18 или больше");
                isValid = false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                errorProvider.SetError(txtEmail, "введите корректный адрес электронной почты");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("форма успешно отправлена", "успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}