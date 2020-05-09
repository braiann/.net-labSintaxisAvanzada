using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            // Carga
            Console.WriteLine("CARGAR EMPLEADO");
            int id;
            do
            {
                Console.Write("ID (-1 para terminar): ");
                id = int.Parse(Console.ReadLine());
                if (id != -1)
                {
                    Empleado e = new Empleado(id);
                    Console.Write("Nombre: ");
                    e.Nombre = Console.ReadLine();
                    Console.Write("Sueldo: $");
                    e.Sueldo = float.Parse(Console.ReadLine());

                    empleados.Add(e);
                }
            } while (id != -1);

            // Ordena
            var empleadosOrdenados = from e in empleados
                                     orderby e.Sueldo
                                     select e;

            // Muestra
            Console.Clear();
            Console.WriteLine("ID\tSUELDO\t\tNOMBRE");
            foreach (Empleado e in empleadosOrdenados)
            {
                e.MostrarEmpleado();
            }

            Console.ReadKey();
        }
    }
}
