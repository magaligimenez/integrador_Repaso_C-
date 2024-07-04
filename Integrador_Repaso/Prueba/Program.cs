using Clases.Excepciones;
using Clases;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Empresa miempresa = new Empresa("globand");
                Console.WriteLine(Empresa.InicioActividades);

                Desarrollador desarrolador1 = new Desarrollador(1, "pepe", "gomez", 25, "sistemas", 1500, 30);
                Gerente gerente1 = new Gerente(5, "maria", "ruiz", 30, "finanzas", 2500, 10);
                Desarrollador desarrolador2 = new Desarrollador(2, "rosa", "martinez", 35, "sistemas", 1500, 30);
                Desarrollador desarrolador3 = new Desarrollador(1, "pepe", "gomez", 25, "sistemas", 1800, 30);

                Console.WriteLine(miempresa.AñadirEmpleado(desarrolador1));
                Console.WriteLine(miempresa.AñadirEmpleado(desarrolador2));
                Console.WriteLine(miempresa.AñadirEmpleado(desarrolador3));
                Console.WriteLine(miempresa.AñadirEmpleado(gerente1));

                Console.WriteLine(miempresa.MostrarEmpleados());

                Console.WriteLine(miempresa.BuscarPorId(1).MostrarInformacion());

                Console.WriteLine(miempresa.MostrarUltimoEmpleado());

                desarrolador1.SalarioBase = -256;
            }
            catch (DatoInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (EmpleadoNoEncotradoException ex)
            {
                Console.WriteLine(ex.Message);
                ex.LogExcepcion();
            }
            catch(Exception ex)
            {
                Console.WriteLine("error no contemplado...");
            }
            

        }
    }
}