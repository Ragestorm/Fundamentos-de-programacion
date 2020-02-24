using System;

namespace Clase_10__t_en_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, dado2 = 0, total = dado + dado2, suma = 0, i = 1, c = 0, intentos = 2;
            int a = 0; int b = 0;
            Random aleatorio = new Random();
            int respuesta = 0;
            a = aleatorio.Next(1, 7);
            b = aleatorio.Next(1, 7);
            int operacion = (a + b);
            string continuar = "s";
            Console.WriteLine("resuelve esta operacion para poder jugar" + a + "+" + b);
            respuesta = int.Parse(Console.ReadLine());
            while (respuesta != operacion && intentos > 0)
            {
                intentos--;
                Console.WriteLine("intenta otra vez");
                a = aleatorio.Next(1, 7);
                b = aleatorio.Next(1, 7);
                operacion = a + b;
                Console.WriteLine("resuelve esta operacion para poder jugar" + a + "+" + b);

                respuesta = int.Parse(Console.ReadLine());
                if (intentos == 0) Console.WriteLine("Largo de aqui bot");
            }
            if (intentos != 0)
            {
                Console.WriteLine("Empieza el juego");
                while (continuar == "s")
                {
                    i++;
                    dado = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);


                    if (dado == 1 && dado2 == 1)
                    {
                        Console.WriteLine("Perdiste");
                        continuar = null;
                    }

                    else
                    {
                        total += dado + dado2;
                        suma = dado + dado2;
                        if (suma >= 6) c++;
                        if (dado != dado2) dado = 0;
                        else if (dado == dado2 && dado != 1) dado++;
                        if (dado == 3)
                        {
                            continuar = null;
                            Console.WriteLine("Ganaste");
                        }
                        if (total >= 100)
                        {
                            continuar = null;
                            Console.WriteLine("Ganaste");
                        }
                        else
                        {
                            Console.WriteLine("Total: " + total);
                            Console.WriteLine("Desea continuar (s/n): ");
                            continuar = Console.ReadLine();
                        }
                    }


                }
                double porcentaje = (((double)c) / i) * 100;
                Console.WriteLine("Su total fue " + total + "puntos");
                Console.WriteLine("gracias por jugar");
                Console.WriteLine("porcentaje DONDE LA SUMA FUE MAYOR O IGUAL A 6: " + porcentaje);
            }
        }
    }
}
