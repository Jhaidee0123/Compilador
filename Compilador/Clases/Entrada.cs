using System.Collections.Generic;
using System.Linq;

namespace Compilador.Clases
{
    public class Entrada
    {
        private readonly static Entrada Instancia = new Entrada();
        private readonly List<Linea> Lineas = new List<Linea>();
        public string Tipo;


        private Entrada()
        {
        }

        public static Entrada obtenerInstancia()
        {
            return Instancia;
        }

        public void agregarLinea(Linea linea)
        {
            if (linea != null)
            {
                Lineas.Add(linea);
            }
        }

        public Linea obtenerLinea(int numero) 
        {
            return Lineas.FirstOrDefault(linea => linea.Numero == numero);
        }

        public List<Linea> obtenerLineas()
        {
            return Lineas;
        }

        public void reiniciarEntrada()
        {
            throw new System.NotImplementedException();
        }
    }
}
