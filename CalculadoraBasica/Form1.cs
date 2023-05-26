namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "-";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float subtracao = n1 - n2;
            label3.Text = subtracao.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "+";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float soma = n1 + n2;
            label3.Text = soma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float multiplicar = n1 * n2;
            label3.Text = multiplicar.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float divisao = n1 / n2;
            label3.Text = divisao.ToString();
        }
    }
}