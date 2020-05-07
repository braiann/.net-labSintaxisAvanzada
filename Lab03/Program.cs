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
            while (continuar)
            {
                Ciudad c = new Ciudad();
                Console.Write("Ingresar código postal" + (ciudades.Count >= 5 ? "(-1 para salir): ": ": "));
                c.codigoPostal = int.Parse(Console.ReadLine());
                if (c.codigoPostal != -1)
                {
                    Console.Write("Ingresar nombre de la ciudad: ");
                    c.nombre = Console.ReadLine();
                    ciudades.Add(c);
                }    
                else if (ciudades.Count >= 5)
                {
                    continuar = false;
                }


            }

            foreach (Ciudad c in ciudades)
            {
                Console.WriteLine("nombre: " + c.nombre);
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
