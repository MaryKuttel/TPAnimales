using TPAnimales.Entidades;

namespace TPAnimalForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Leon leon = new Leon(5, 40, 50, "Carne", "Oscura");
            Loro loro = new Loro(2, 10, 3, "Semillas", "Amarillo");
            Conejo conejo = new Conejo(3, 20, 12, "Zanahoria", "Marrón");

            MessageBox.Show("Leon: " + leon.ImprimirComida(), leon.Imprimir());
            MessageBox.Show("Loro: " + loro.ImprimirComida(), loro.Imprimir());
            MessageBox.Show("Conejo: " + conejo.ImprimirComida(), conejo.Imprimir());
        }
    }
}