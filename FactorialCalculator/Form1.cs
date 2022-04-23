namespace FactorialCalculator
{
    public partial class frmFactorialCalculator : Form
    {
        public frmFactorialCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long factorial = 1;
            byte number = Convert.ToByte(txtNumber.Text);
            if (number > 0 && number < 21) 
            {
                for (int i = 1; i <= number; i++) 
                { 
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString("N0");
            }
            else 
            {
                MessageBox.Show("Please enter a number between 1 and 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFactorialCalculator_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtFactorial.Clear();
        }
    }
}