namespace FactorialCalculator
{
    partial class frmFactorialCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(93, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(86, 65);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(52, 15);
            this.lblFactorial.TabIndex = 1;
            this.lblFactorial.Text = "Factorial";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(144, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 23);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtFactorial
            // 
            this.txtFactorial.Enabled = false;
            this.txtFactorial.Location = new System.Drawing.Point(144, 65);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.ReadOnly = true;
            this.txtFactorial.Size = new System.Drawing.Size(165, 23);
            this.txtFactorial.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 109);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 36);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(234, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFactorialCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 157);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmFactorialCalculator";
            this.Text = "Factorial Calculator";
            this.Click += new System.EventHandler(this.frmFactorialCalculator_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumber;
        private Label lblFactorial;
        private TextBox txtNumber;
        private TextBox txtFactorial;
        private Button btnCalculate;
        private Button btnExit;
    }
}