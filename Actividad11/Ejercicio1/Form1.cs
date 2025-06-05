namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        double acumulador = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(textBox2.Text);

            acumulador += valor;
            contador += 1;
            valor = Convert.ToDouble(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            lbResultado.Text = $"{promedio,10:f2}";

            tbResultado.Text = $"{promedio,10:f2}";
        }

    }
}
