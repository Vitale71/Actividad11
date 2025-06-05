namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        double[] acumulador = new double[100];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox2.Text);
            acumulador[contador] = valor;
            contador++;
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double acum = 0;
            for (int i = 0; i < contador; i++)
            {
                acum += acumulador[i];
            }

            double promedio = acum / contador;

            lbResultado.Text = $"{promedio,10:f2}";

            tbResultado.Text = $@"Promedio:
                                {promedio,10:f2}";
        }

    }
}
