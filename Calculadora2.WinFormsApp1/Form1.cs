namespace Calculadora2.WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string expressao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            expressao += " " + button11.Text + " ";
            richTextBox2.Text = expressao;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            expressao += " " + button12.Text + " ";
            richTextBox2.Text = expressao;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            expressao += " " + button13.Text + " ";
            richTextBox2.Text = expressao;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            expressao += " " + button14.Text + " ";
            richTextBox2.Text = expressao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expressao += button1.Text;
            richTextBox2.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expressao += button2.Text;
            richTextBox2.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expressao += button3.Text;
            richTextBox2.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expressao += button4.Text;
            richTextBox2.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expressao += button5.Text;
            richTextBox2.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expressao += button6.Text;
            richTextBox2.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expressao += button7.Text;
            richTextBox2.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expressao += button8.Text;
            richTextBox2.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expressao += button9.Text;
            richTextBox2.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            expressao += button10.Text;
            richTextBox2.Text += button10.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] arrayValores = expressao.Split(' ');
            double valor1 = Convert.ToDouble(arrayValores[0]);

            string op = arrayValores[1];

            double valor2 = Convert.ToDouble(arrayValores[2]);

            double resultado = 0;
            
            Calculadora calculadora = new Calculadora();

            switch(op)
            {
                case "+": resultado = calculadora.Somar(valor1, valor2); break;
                case "-": resultado = calculadora.Subtrair(valor1, valor2); break;
                case "*": resultado = calculadora.Multiplicar(valor1, valor2); break;
                case "/": resultado = calculadora.Dividir(valor1, valor2); break;
            }

            richTextBox2.Text = resultado.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            expressao = string.Empty;
        }
    }
}