namespace Cifrador_Cesar
{
    public partial class Form1 : Form
    {
        Cifrador cifrador = new Cifrador();
        Decifrador decifrador = new Decifrador();

        public Form1()
        {
            InitializeComponent();

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCifrar_Click(object sender, EventArgs e)
        {
            cifrador.Clave = (int)numericUpDown1.Value;
            cifrador.Mensaje = MensajeACifrar.Text;
            label1.Text = cifrador.MostrarMensaje();


        }

        private void buttonDecifrar_Click(object sender, EventArgs e)
        {
            decifrador.Clave = (int)numericUpDown1.Value;
            decifrador.Mensaje = textBoxDescifar.Text;
            labelTextoDecifrado.Text = decifrador.MostrarMensaje();

        }
    }
}
