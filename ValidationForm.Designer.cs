namespace WinFormsHomework
{
    partial class ValidationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "имя:";
            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Size = new System.Drawing.Size(150, 20);

            this.lblAge.Location = new System.Drawing.Point(20, 50);
            this.lblAge.Text = "возраст:";
            this.txtAge.Location = new System.Drawing.Point(120, 50);
            this.txtAge.Size = new System.Drawing.Size(150, 20);

            this.lblEmail.Location = new System.Drawing.Point(20, 80);
            this.lblEmail.Text = "email:";
            this.txtEmail.Location = new System.Drawing.Point(120, 80);
            this.txtEmail.Size = new System.Drawing.Size(150, 20);

            this.btnSubmit.Location = new System.Drawing.Point(120, 120);
            this.btnSubmit.Text = "отправить";
            this.btnSubmit.Click += new System.EventHandler(this.SubmitButton_Click);

            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSubmit);
            this.Text = "форма валидации";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}