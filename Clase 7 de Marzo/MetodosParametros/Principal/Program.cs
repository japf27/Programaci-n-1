using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio1;
using Biblio2;
using Biblio3;





namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 valores = new Class1();
            /*Console.WriteLine(valores.invertirDosNumeros("52"));
            Console.WriteLine(valores.invertirTresNumeros("532"));*/
            /*Class2 valores1 = new Class2();

            valores.imprimir();
            valores.imprimir(3);
            valores.imprimir(2, 2);*/

            Class3 sobcarga = new Class3();
            sobcarga.Semaforo();
            sobcarga.Semaforo("Carlos");
            sobcarga.Semaforo("Carlos", "Maria");
            sobcarga.Semaforo("Carlos", "Maria", "Luis");
            sobcarga.Semaforo("Carlos", "Maria", "Luis", "Fernando");

            Console.ReadKey();
        }
    }
}
