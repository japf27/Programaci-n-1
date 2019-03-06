using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int edad;
        private double tamanio;

        public double Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }

        public void imprimir()
        {
            Console.WriteLine(edad);
        }
    }

   
}
