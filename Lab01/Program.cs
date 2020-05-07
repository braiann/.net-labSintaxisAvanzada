using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] provincias = { "Ciudad Autónoma de Buenos Aires", "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Paraná", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán" };

            var resultados = from p in provincias
                             where p[0].Equals('S') || p[0].Equals('T')
                             select p;

            foreach (string r in resultados)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }
}
