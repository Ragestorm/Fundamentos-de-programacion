using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace captcha
{
    class Program
    {
        static void Main(string[] args)
        {

            int dado = 0, contadorT = 3, total = 0, contadorV = 0, intentos = 3;
            int a = 0; int b = 0;
            Random aleatorio = new Random();
            int respuesta = 0;
            a = aleatorio.Next(1, 7);
            b = aleatorio.Next(1, 7);
            int operacion = (a + b);
            string continuar = "s";
            Console.WriteLine("eres humano? pruebalo: " + a + "+" + b);
            respuesta = int.Parse(Console.ReadLine());
            while (respuesta != operacion && intentos > 0)
            {
                intentos--;
                Console.WriteLine("intentalo de nuevo");
                a = aleatorio.Next(1, 7);
                b = aleatorio.Next(1, 7);
                operacion = a + b;
                Console.WriteLine("eres humano? pruebalo: " + a + "+" + b);
                respuesta = int.Parse(Console.ReadLine());

                if (intentos == 0)
                {
                    Console.WriteLine("Alerta roja Skynet ataca, activar protocolo de autodestruccion");
                }
                if (intentos != 0)
                {
                    Console.WriteLine("inicia el juego");

                    while (continuar == "s")
                    {
                        dado = aleatorio.Next(1, 13);
                        total += dado;
                        contadorT -= 1;
                        if (contadorT <= 0)
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
    }
}
    