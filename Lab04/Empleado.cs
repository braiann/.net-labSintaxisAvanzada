using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Empleado
    {
        private int id;
        private string nombre;
        private float sueldo;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public float Sueldo
        {
            get => sueldo;
            set => sueldo = value;
        }
        
        public Empleado(int id)
        {
            Id = id;
        }

        public void MostrarEmpleado()
        {
            Console.WriteLine("{0}\t${1}\t\t{2}", Id, Sueldo, Nombre);
        }
    }
}
