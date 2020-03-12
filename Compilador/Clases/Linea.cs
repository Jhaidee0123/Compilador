namespace Compilador.Clases
{
    public class Linea
    {
        public Linea(int numero, string contenido)
        {
            Numero = numero;
            Contenido = contenido;
        }

        public int Numero { get; set; }
        public string Contenido { get; set; }
    }
}
