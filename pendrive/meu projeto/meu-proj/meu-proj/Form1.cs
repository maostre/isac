
namespace meu_proj

{
    public partial class Form1 : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }
       

        private Operacao selecionada { get; set; }
        private enum Operacao
        {
            soma,
            sub,
            div,
            mult
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Tb.Text = "";
            label2.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Tb.Text += "1";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Tb.Text += "2";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Tb.Text += "3";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Tb.Text += "4";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Tb.Text += "5";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Tb.Text += "6";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Tb.Text += "7";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Tb.Text += "8";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Tb.Text += "9";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            selecionada = Operacao.soma;
            valor = Convert.ToDecimal(Tb.Text);
            Tb.Text = "";
            label2.Text = "+";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            selecionada = Operacao.sub;
            valor = Convert.ToDecimal(Tb.Text);
            Tb.Text = "";
            label2.Text = "-";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            selecionada = Operacao.mult;
            valor = Convert.ToDecimal(Tb.Text);
            Tb.Text = "";
            label2.Text = "x";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            selecionada = Operacao.div;
            valor = Convert.ToDecimal(Tb.Text);
            Tb.Text = "";
            label2.Text = "x";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            switch (selecionada)
            {
                case Operacao.soma:
                    resultado = valor + Convert.ToDecimal(Tb.Text);
                    break;
                case Operacao.sub:
                    resultado = valor - Convert.ToDecimal(Tb.Text);
                    break;
                case Operacao.mult:
                    resultado = valor * Convert.ToDecimal(Tb.Text);
                    break;
                case Operacao.div:
                    resultado = valor / Convert.ToDecimal(Tb.Text);
                    break;
            }
            Tb.Text = Convert.ToString(resultado);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Tb.Text += "0";
        }
    }
}