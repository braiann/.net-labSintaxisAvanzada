using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ciudades = new ArrayList();
            bool continuar = true;

            // Carga al menos 10 ciudades
            while (continuar)
            {
                Ciudad c = new Ciudad();
                Console.Write("Ingresar código postal" + (ciudades.Count >= 10 ? "(-1 para salir): ": ": "));
                c.codigoPostal = int.Parse(Console.ReadLine());
                if (c.codigoPostal != -1)
                {
                    Console.Write("Ingresar nombre de la ciudad: ");
                    c.nombre = Console.ReadLine();
                    ciudades.Add(c);
                }    
                else if (ciudades.Count >= 10)
                {
                    continuar = false;
                }
            }

            // Lee 3 caracteres de búsqueda
            string busqueda;
            Console.Clear();
            Console.Write("Escribir tres caracteres para buscar ciudad: ");
            do
            {
                busqueda = Console.ReadLine();
            } while (busqueda.Length != 3);

            // Busca
            var seleccion = from Ciudad c in ciudades
                            where c.nombre.Contains(busqueda)
                            select c;

            // Muestra
            foreach (Ciudad c in seleccion)
            {
                Console.WriteLine("cp: " + c.codigoPostal);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
        struct Ciudad
        {
            public int codigoPostal;
            public string nombre;
        }

    }
}
