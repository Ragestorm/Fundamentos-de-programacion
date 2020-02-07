using System;

namespace Tarea_programacion_s4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Votos por el partido A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Votos por el partido B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Votos en blanco");
            double blanco = double.Parse(Console.ReadLine());
            Console.WriteLine("Votos nulos");
            double nulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Poblacion total");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Mayores de edad");
            double p = double.Parse(Console.ReadLine());

            double P = p / 100;
            double Totalv = a + b + blanco + nulo;
            double j = Totalv * 10 / 100;
            double r = Totalv * 30 / 100;

            if (Totalv > t)
            {
                Console.WriteLine("La votacion debe repetirse");
            }
            else if (a+b < j)
            {
                if (p < r)
                {
                    Console.WriteLine("La votacion debe repetirse");
                }
            }
            else if (a > b)
            {
                Console.WriteLine("El partido gana dor es el partido A");
            }
            else if (b > a)
            {
                Console.WriteLine("El partido gana dor es el partido B");
            }
        }
    }
}
