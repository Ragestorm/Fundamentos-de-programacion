using System;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario ");
            double Salario = double.Parse(Console.ReadLine());

            if (Salario < 1961314)
            {
                Console.WriteLine("Tarifa1");
            }
            else if (1961314 <= Salario && Salario <= 3922628)
            {
                Console.WriteLine("Tarifa2");
            }
            else
            {
                Console.WriteLine("Tarifa3");
            }
        }
    }
}
