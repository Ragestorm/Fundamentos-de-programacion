using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese b, z, y");
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double b = bGrados * (Math.PI / 180.0);
            double t = Math.Sqrt(z * z + y * y);


            double a = Math.Asin(((Math.Sin(Math.PI / 2)) * y) / t) * (180 / Math.PI);
            double d = 90 - a - b;
            double ab = (a + b) * (Math.PI / 180.0);
            double dr = d * (Math.PI / 180.0);
            double x = ((z / Math.Sin(dr)) * (Math.Sin(ab))) - y;



            Console.WriteLine("x: " + x);
        }
    }
}
