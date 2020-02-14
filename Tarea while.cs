using System;

namespace tarea_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 0;
            int total = 2;
            Random aleatorio = new Random;
            string continuar = "s ";
            while (continuar== "s"&& total > 21)
            {
                carta = aleatorio.Next(1, 11);
                if (total > 21)
                {
                    Console.WriteLine("eliminado");
                }
                else
                {
                    total += carta;
                    Console.WriteLine("total " + total);
                    Console.WriteLine("desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                }
            }
            Console.WriteLine("su total fue " + total + "puntos");
            Console.WriteLine("gracias por jugar");
        }
    }
}
