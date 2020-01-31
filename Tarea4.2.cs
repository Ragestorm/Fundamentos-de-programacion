using System;

namespace Tarea_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario ");
            double Salario = double.Parse(Console.ReadLine());
            double Tarifa = (Salario * 4 / 100);
            

            if (Salario < 1961314)
            {
                Console.WriteLine("TarifaA: " + Tarifa);
            }
            else if (1961314 <= Salario && Salario <= 3922628)
            {
                Console.WriteLine("TarifaB: " + Tarifa);
            }
            else
            {
                Console.WriteLine("TarifaC: " + Tarifa);
            }
        }
    }
}
