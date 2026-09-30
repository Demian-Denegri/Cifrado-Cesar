namespace Cifrador_Cesar
{
    public partial class Form1 : Form
    {
        Cifrador cifrador = new Cifrador();

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
            label1.Text = cifrador.MostrarMensajeCifrado();


        }


    }
}
