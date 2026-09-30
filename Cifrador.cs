namespace Cifrador_Cesar
{
    public class Cifrador
    {
        public int Clave { get; set; }
        protected string _Mensaje;
        public string Mensaje
        {
            get 
            { 
                return _Mensaje; 
            }
            set
            {
                if (value is null)
                {
                    throw new Exception("No puede estar vacio");
                }
                _Mensaje = value;
            }
        }
        protected char[] Letras = {
        'A','B','C','D','E','F','G','H','I','J',
        'K','L','M','N','O','P','Q','R','S','T',
        'U','V','W','X','Y','Z',' ',
        '0','1','2','3','4','5','6','7','8','9',
        '!','?','.',',',';','-','+','*','/','='
        };

        protected List<char> listaMensaje = new List<char>();
        public void ProcesarMensaje()
        {
            listaMensaje.Clear();
            this.Mensaje = this.Mensaje.ToUpper();
            for (int i = 0; i < Mensaje.Length; i++)
            {
                char letra = this.Mensaje[i];
                listaMensaje.Add(letra);
            }
        }

        private void CifrarMensaje()
        {
            ProcesarMensaje();
            for (int i = 0; i < listaMensaje.Count; i++)
            {
                for (int j = 0; j < Letras.Length; j++)
                {
                    if (listaMensaje[i].Equals(Letras[j]))
                    {
                        int nuevoIndice = (j + Clave) % Letras.Length; // para que comience denuvo el abecedario si se supera el largo
                        listaMensaje[i] = Letras[nuevoIndice];
                        break;
                    }
                }

            }

        }


        public string MostrarMensaje()
        {

            CifrarMensaje();
            string mensajeCifrado = new string(listaMensaje.ToArray());
            return mensajeCifrado;

        }
    }
}