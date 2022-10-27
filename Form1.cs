namespace funyuns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += '0';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += '.';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            label3.Text = label1.Text;
            label1.ResetText();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            label3.Text = label1.Text;
            label1.ResetText();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            label3.Text = label1.Text;
            label1.ResetText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            decimal equation;
            switch (label2.Text)
            {
                
                case "*":
                    equation = Convert.ToDecimal(label3.Text) * Convert.ToDecimal(label1.Text);
                    label3.Text = label1.Text + '*' + label3.Text;
                    label2.ResetText();
                    label1.Text = equation.ToString();
                    break;
                case "+":
                    equation = Convert.ToDecimal(label3.Text) + Convert.ToDecimal(label1.Text);
                    label3.Text = label1.Text + '+' + label3.Text;
                    label2.ResetText();
                    label1.Text = equation.ToString();
                    break;
                case "-":
                    equation = Convert.ToDecimal(label3.Text) - Convert.ToDecimal(label1.Text);
                    label3.Text = label1.Text + '-' + label3.Text;
                    label2.ResetText();
                    label1.Text = equation.ToString();
                    break;
                case "%":
                    equation = Convert.ToDecimal(label3.Text) % Convert.ToDecimal(label1.Text);
                    label3.Text = label1.Text + '%' + label3.Text;
                    label2.ResetText();
                    label1.Text = equation.ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "%";
            label3.Text = label1.Text;
            label1.ResetText();
        }
    }
}