using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros = CargarNumeros();

            var numsMayores = from n in numeros
                              where n > 20
                              select n;

            Console.WriteLine("Números Mayores a 20:");
            foreach (int num in numsMayores)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }

        static List<int> CargarNumeros()
        {
            List<int> lista = new List<int>();
            int n = 0;
            Console.WriteLine("Cargar números mayores a 0:");
            while (n >= 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= 0)
                {
                    lista.Add(n);
                }
            }
            return lista;
        }
    }
}
