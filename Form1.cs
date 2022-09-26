namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            cboOperation.SelectedIndex = 0;
            txtfirstnum.Focus();
            txtresults.Enabled = false;
        }

        private void cboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOperation = this.cboOperation.GetItemText(this.cboOperation.SelectedItem);  
            if (selectedOperation.Equals("+"))
            {
                lblResults.Text = "Addition";
                btnOperation.Text = "Add";
                
            }
            else if (selectedOperation.Equals("-"))
            {
                lblResults.Text = "Subrtaction";
                btnOperation.Text = "Subtract";
                
            }
            else if (selectedOperation.Equals("x"))
            {
                lblResults.Text = "Multiplication";
                btnOperation.Text = "Multiply";
               
            }
            else if (selectedOperation.Equals("/"))
            {
                lblResults.Text = "Division";
                btnOperation.Text = "Divide";
                
            }
            else
            {
                lblResults.Text = "Modulus";
                btnOperation.Text = "Module";
               
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (txtfirstnum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the first number to be added",
                    "Missing first number", MessageBoxButtons.OK, MessageBoxIcon.Error);      
                txtfirstnum.Focus();         
                return;
            }

                if (txtsecondnum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the second number to be added",
                    "Missing second number", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                txtsecondnum.Focus();               
                return;
            }
            
            try
            {
                string selectedOperation = this.cboOperation.GetItemText(this.cboOperation.SelectedItem);
                double v1 = Convert.ToDouble(txtfirstnum.Text);
                double v2 = Convert.ToDouble(txtsecondnum.Text);
                if (selectedOperation.Equals("+"))
                {
                    double sum = v1 + v2;

                    txtresults.Text = sum.ToString();
                }
                else if (selectedOperation.Equals("-"))
                {
                    double difference = v1 - v2;

                    txtresults.Text = difference.ToString();
                }
                else if (selectedOperation.Equals("x"))
                {
                    double product = v1 * v2;

                    txtresults.Text = product.ToString();
                }
                else if (selectedOperation.Equals("/"))
                {
                    double quotient = v1 / v2;

                    txtresults.Text = quotient.ToString();
                }
                else 
                {
                    double remainder = v1 % v2;

                    txtresults.Text = remainder.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value e.g. \'5\'",
                    "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error " + ex.Message + " occured!",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
        {
            txtfirstnum.Text = "";
            txtsecondnum.Clear();
            txtresults.Clear();
            txtfirstnum.Focus();
        }
    }
    }
}