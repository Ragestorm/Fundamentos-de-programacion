using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 100;
            double resultado = 0;
            double resultadoA = 0;
            double resultado2 = 0;
            double Anterior = 0;
            double x = int.Parse(Console.ReadLine());
            for (int i=0; i < n; i++)
            {
                double e = Math.Pow(x, i) / Factorial(i);
                resultado += e;
                if (resultadoA == resultado) break;
                Console.WriteLine("e a la x es: "+ resultado);
                resultadoA = resultado;
            }
            double x2 = double.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                double sen = ((Math.Pow(-1, j))/ (Factorial (2 * j + 1))) * (Math.Pow(x2, 2 * j + 1));
                resultado2 += sen;
                if (Anterior == resultado2) break;
                Console.WriteLine("sen es: " + resultado2);
                Anterior = resultado2;
            }
        }
        public static double Factorial(double number)
        {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
