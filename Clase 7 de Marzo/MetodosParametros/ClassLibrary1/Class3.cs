using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio3
{
    public class Class3
    {
        int color;

        public void Semaforo()
        {
            Console.WriteLine("Rojo = 1");
            Console.WriteLine("Amarillo = 2");
            Console.WriteLine("Verde = 3");
            Console.WriteLine("Ingrese el numero del color del semaforo");
            color = int.Parse(Console.ReadLine());

            if (color == 1)
            {
                Console.WriteLine("Detengase");
            }
            else
            {
                if (color == 2)
                {
                    Console.WriteLine("Precaucion");
                }
                else
                {
                    if (color == 3)
                    {
                        Console.WriteLine("Avance");
                    }
                }
            }

        }

        public void Semaforo(String Carlos)
        {
            Console.WriteLine("Rojo = 1");
            Console.WriteLine("Amarillo = 2");
            Console.WriteLine("Verde = 3");
            color = int.Parse(Console.ReadLine());

            if (color == 1)
            {
                Console.WriteLine("Detengase"+Carlos);
            }
            else
            {
                if (color == 2)
                {
                    Console.WriteLine("Precaucion"+Carlos);
                }
                else
                {
                    if (color == 3)
                    {
                        Console.WriteLine("Avance"+Carlos);
                    }
                }
            }
        }

        public void Semaforo(String Carlos, String Maria)
        {
            Console.WriteLine("Rojo = 1");
            Console.WriteLine("Amarillo = 2");
            Console.WriteLine("Verde = 3");
            color = int.Parse(Console.ReadLine());

            if (color == 1)
            {
                Console.WriteLine("Detengase"+Maria);
            }
            else
            {
                if (color == 2)
                {
                    Console.WriteLine("Precaucion"+Maria);
                }
                else
                {
                    if (color == 3)
                    {
                        Console.WriteLine("Avance"+Maria);
                    }
                }
            }
        }

        public void Semaforo(String Carlos, String Maria, String Luis)
        {
            Console.WriteLine("Rojo = 1");
            Console.WriteLine("Amarillo = 2");
            Console.WriteLine("Verde = 3");
            color = int.Parse(Console.ReadLine());

            if (color == 1)
            {
                Console.WriteLine("Detengase"+Luis);
            }
            else
            {
                if (color == 2)
                {
                    Console.WriteLine("Precaucion"+Luis);
                }
                else
                {
                    if (color == 3)
                    {
                        Console.WriteLine("Avance"+Luis);
                    }
                }
            }
        }

        public void Semaforo(String Carlos, String Maria, String Luis, String Fernando)
        {
            Console.WriteLine("Rojo = 1");
            Console.WriteLine("Amarillo = 2");
            Console.WriteLine("Verde = 3");
            color = int.Parse(Console.ReadLine());

            if (color == 1)
            {
                Console.WriteLine("Detengase"+Fernando);
            }
            else
            {
                if (color == 2)
                {
                    Console.WriteLine("Precaucion"+Fernando);
                }
                else
                {
                    if (color == 3)
                    {
                        Console.WriteLine("Avance"+Fernando);
                    }
                }
            }
        }
    }
}
