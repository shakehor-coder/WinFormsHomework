namespace WinFormsHomework
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstHistory;

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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.txtInput1.Location = new System.Drawing.Point(20, 20);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 23);

            this.txtInput2.Location = new System.Drawing.Point(130, 20);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 23);

            this.btnAdd.Location = new System.Drawing.Point(20, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSub.Location = new System.Drawing.Point(60, 60);
            this.btnSub.Name = "btnSub";
            this.btnSub.Text = "-";
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);

            this.btnMul.Location = new System.Drawing.Point(100, 60);
            this.btnMul.Name = "btnMul";
            this.btnMul.Text = "*";
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);

            this.btnDiv.Location = new System.Drawing.Point(140, 60);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Text = "/";
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);

            this.lblResult.Location = new System.Drawing.Point(20, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 23);
            this.lblResult.Text = "Результат: ожидание ввода";

            this.lstHistory.Location = new System.Drawing.Point(20, 140);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(210, 100);

            this.ClientSize = new System.Drawing.Size(250, 260);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lstHistory);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}