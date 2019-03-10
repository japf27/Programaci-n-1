using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio1
{
    public class Class1
    {
        int val1 = 5,val2 = 5,suma;
    
    public void imprimir ()
    {
        suma=val1+val2;
        Console.WriteLine("resultado"+suma);
    }
    public void imprimir (int valor1)
    {
        suma=valor1+val2;
        Console.WriteLine("resultado"+suma);
    }

    public void imprimir (int valor1, int valor2)
    {
        suma=valor1+val2;
        Console.WriteLine("resultado"+suma);
    }
    }
}

