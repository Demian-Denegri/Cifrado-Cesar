namespace Cifrador_Cesar
{
    public class Decifrador : Cifrador
    {
        private void Descifrar()
        {
            ProcesarMensaje();//almaceno el mensaje en chars dentro de una list
            for (int i = 0; i < listaMensaje.Count; i++)
            {
                for (int j = 0; j < Letras.Length; j++)
                {
                    if (listaMensaje[i].Equals(Letras[j]))
                    {
                        int nuevoIndice = (j - Clave + Letras.Length) % Letras.Length; // para que comience denuvo el abecedario si se supera el largo
                        listaMensaje[i] = Letras[nuevoIndice];
                        break;
                    }
                }

            }
        }
        public string MostrarMensaje()
        {

            Descifrar();
            string mensajeDecifrado = new string(listaMensaje.ToArray());
            return mensajeDecifrado;

        }
    }
}
