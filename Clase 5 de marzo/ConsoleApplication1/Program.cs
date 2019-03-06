using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Capsula obj = new Capsula();
            Class1 obj2 = new Class1();
            obj.Nombre="Jorge";
            obj.Apellido= "Parada";
            obj.imprimir();
            obj.SetNombre("Alirio");
            Console.WriteLine(obj.GetNombre());
            obj2.edad = 18;
            obj2.imprimir();
            area obj3 = new area();
            obj3.bases = 7.5;
            obj3.altura = 12;
            obj3.imprime();
            
            Console.ReadKey();


        }
    }
}
