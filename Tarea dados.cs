using System;

namespace Tarea_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, contadorT = 3, total = 0, contadorV = 0;            
            Random aleatorio = new Random();
            string continuar = "s";
            while (continuar == "s")
            {
                dado = aleatorio.Next(1,13);
                total += dado;
                contadorT -= 1;
                if(contadorT <= 0)
                {
                    if (total % 2 == 0)
                    {
                        total += dado;
                    }
                    else
                    {
                        Console.WriteLine("perdiste");
                        continuar = "n";
                    }
                }
                if (total >= 100)
                {
                    Console.WriteLine("ganaste");
                    continuar = "n";

                }
                else if (contadorV == 2)
                {
                    Console.WriteLine("ganaste");
                    continuar = "n";
                    if (dado == 10)
                    {
                        contadorV += 1;
                    }
                    else if (dado == 12)
                    {
                        contadorV += 1;
                    }
                }
                else
                {
                    Console.WriteLine("total" + total);
                    Console.WriteLine("desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                }
            }
            Console.WriteLine("su total fue" + total + "puntos");
            Console.WriteLine("gracias por jugar");
        }
    }
}
