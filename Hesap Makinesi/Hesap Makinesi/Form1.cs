namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            if (comboBox1.Text == "sum")
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                result = num1 + num2;
                label4.Text = result.ToString();
            }
            else if (comboBox1.Text == "multiple")
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                result = num1 * num2;
                label4.Text = result.ToString();
            }
            else if (comboBox1.Text == "minus")
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                result = num1 - num2;
                if (result < 0)
                {
                    MessageBox.Show("Result is negative ");
                }
                label4.Text = result.ToString();
            }



        }
    }
}