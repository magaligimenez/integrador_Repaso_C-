using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class EmpleadoNoEncotradoException : Exception
    {
        Empleado empleadoExcepcion;
        public EmpleadoNoEncotradoException(string mensaje, Empleado empleadito):base(mensaje)
        {
            empleadoExcepcion = empleadito;
        }
        public EmpleadoNoEncotradoException(string mensaje) : base(mensaje) 
        {
        }

        public void LogExcepcion()
        {
            string filePath = "log.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{DateTime.Now}: se intento guardar: {empleadoExcepcion.MostrarInformacion("Corto")}");
            }
        }
    }
}
