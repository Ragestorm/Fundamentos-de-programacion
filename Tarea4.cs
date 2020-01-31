using System;

namespace tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario ");
            double Salario = double.Parse(Console.ReadLine());
            double Tarifa1 = (Salario * 2 / 100);
            double Tarifa2 = (Salario * 4 / 100);
            double Tarifa3 = (Salario * 6 / 100);

            if (Salario < 1961314)
            {
                Console.WriteLine("Tarifa1: " + Tarifa1);
            }
            else if(1961314 <= Salario && Salario <= 3922628) 
            {
                Console.WriteLine("Tarifa2: " + Tarifa2); 
            }
            else 
            {
                Console.WriteLine("Tarifa3: "+ Tarifa3);           
            }
        }
    }
}
