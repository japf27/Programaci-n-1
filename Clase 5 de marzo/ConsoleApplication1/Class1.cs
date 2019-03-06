using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Capsula
    {
        public string Nombre;
        public string Apellido;

        public void SetNombre(string valor)
        {
            Nombre = valor;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void imprimir()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
        }
    }
}
