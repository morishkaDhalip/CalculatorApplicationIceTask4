namespace CalculatorApplication
{

    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
            calculator.OperationPerformed += (operation, result) =>
            {
                lblResult.Text = $"{operation} result: {result}";
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            calculator.Add(a, b);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            calculator.Subtract(a, b);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            calculator.Multiply(a, b);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNumber1.Text);
            double b = double.Parse(txtNumber2.Text);
            calculator.Divide(a, b);
        }
    }
 }



