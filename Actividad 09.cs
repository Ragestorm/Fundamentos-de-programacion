using System;

namespace dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, vidas = 3,total = 0, contador1 = 0, contador6 = 0;
            Random aleatorio = new Random();
            string continuar = "s";

            while (continuar == "s")
            {
                dado = aleatorio.Next(1, 7);
                total += dado;
                if (dado == 1)
                {
                    contador1 = contador1 - 1;
                    if (contador1 == -2)
                    {
                        vidas -= 1;
                        total = total - 10;
                    }                   
                }
                else if (dado == 6)
                {
                    contador6 = contador6 + 1;

                    if (contador6 == 2)
                    {
                        vidas += 1;
                    }
                }
                if (vidas == 0)
                {
                    Console.WriteLine("perdiste");
                    continuar = "n";
                }
                else if (total >= 100)
                {
                    Console.WriteLine("ganaste");
                    continuar = "n";
                }
            }
        }
    }
}
