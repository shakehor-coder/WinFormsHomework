namespace WinFormsHomework
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnValidation;

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
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnValidation = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnCalculator.Location = new System.Drawing.Point(50, 30);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(200, 40);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.Text = "Открыть калькулятор";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);

            this.btnValidation.Location = new System.Drawing.Point(50, 90);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(200, 40);
            this.btnValidation.TabIndex = 1;
            this.btnValidation.Text = "Открыть форму валидации";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.btnCalculator);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
        }
    }
}