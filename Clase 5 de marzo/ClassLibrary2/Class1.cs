using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class area
    {
        public double bases;
        public double altura;

        public void Setbases(double valor)
        {
            bases = valor;
        }

        public double Getbases()
        {
            return bases;
        }

        public void Setaltura(double valor)
        {
            altura = valor;
        }

        public double GetNombre()
        {
            return altura;
        }

        public void imprime(){
            Console.WriteLine("El area es: "+(bases*altura));
        }
        }

    
public class area 
{
}
}
}
