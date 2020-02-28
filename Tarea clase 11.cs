using System;

class Program
{
    static void Main()
    {
        double dmax = 0;
        double[] CoordX = { 0, 2, 3, 7 };
        double[] CoordY = { 0, 1, 5, 6 };

        double[] pendientes = new double[6];
        pendientes[0] = (CoordY[1] - CoordY[0]) / (CoordX[1] - CoordX[0]);
        pendientes[1] = (CoordY[2] - CoordY[0]) / (CoordX[2] - CoordX[0]);
        pendientes[2] = (CoordY[3] - CoordY[0]) / (CoordX[3] - CoordX[0]);
        pendientes[3] = (CoordY[2] - CoordY[1]) / (CoordX[2] - CoordX[1]);
        pendientes[4] = (CoordY[3] - CoordY[1]) / (CoordX[3] - CoordX[1]);
        pendientes[5] = (CoordY[3] - CoordY[2]) / (CoordX[3] - CoordX[2]);

        double[] distancias = new double[6];
        distancias[0] = Math.Sqrt(Math.Pow(CoordY[0] - CoordY[1], 2)) + Math.Pow(CoordX[0] - CoordX[1], 2);
        distancias[1] = Math.Sqrt(Math.Pow(CoordY[0] - CoordY[2], 2)) + Math.Pow(CoordX[0] - CoordX[2], 2);
        distancias[2] = Math.Sqrt(Math.Pow(CoordY[0] - CoordY[3], 2)) + Math.Pow(CoordX[0] - CoordX[3], 2);
        distancias[3] = Math.Sqrt(Math.Pow(CoordY[1] - CoordY[2], 2)) + Math.Pow(CoordX[1] - CoordX[2], 2);
        distancias[4] = Math.Sqrt(Math.Pow(CoordY[1] - CoordY[3], 2)) + Math.Pow(CoordX[1] - CoordX[3], 2);
        distancias[5] = Math.Sqrt(Math.Pow(CoordY[2] - CoordY[3], 2)) + Math.Pow(CoordX[2] - CoordX[3], 2);

        for (int i = 0; i < distancias.Length; i++)
        {
            if (distancias[i] > dmax) dmax = distancias[i];
        }

        Console.WriteLine("Distancia (0,0) a (2,1): " + distancias[0] + " Pendiente: " + pendientes[0]);
        Console.WriteLine("Distancia (0,0) a (3,5): " + distancias[1] + " Pendiente: " + pendientes[1]);
        Console.WriteLine("Distancia (0,0) a (7,6): " + distancias[2] + " Pendiente: " + pendientes[2]);
        Console.WriteLine("Distancia (2,1) a (3,5): " + distancias[3] + " Pendiente: " + pendientes[3]);
        Console.WriteLine("Distancia (2,1) a (7,6): " + distancias[4] + " Pendiente: " + pendientes[4]);
        Console.WriteLine("Distancia (3,5) a (7,6): " + distancias[5] + " Pendiente: " + pendientes[5]);
        Console.WriteLine("Distancia máxima: " + dmax);
    }
}

