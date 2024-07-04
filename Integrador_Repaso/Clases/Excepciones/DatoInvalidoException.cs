using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class DatoInvalidoException : Exception
    {
        string valor;

        public DatoInvalidoException(string mensaje, string valor):base (mensaje)
        {
            this.valor = valor;
            LogExcepcion();
        }

        private void LogExcepcion()
        {
            using(StreamWriter sw  = new StreamWriter("log.txt", true)) 
            {
                sw.WriteLine($"{DateTime.Now}: excepcion no controlada: {this.Message}. Valor: {this.valor}");
            }
        }

    }
}
