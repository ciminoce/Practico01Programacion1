﻿
namespace Ejercicio05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Distancia entre Puntos");
            try
            {
                
                Console.Write("Ingrese la coord X. del primer punto:");
                int X1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord Y. del primer punto:");
                int Y1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la coord X. del segundo punto:");
                int X2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord Y. del segundo punto:");
                int Y2 = int.Parse(Console.ReadLine());
                if(X1!=X2 || Y1 != Y2)//|| es la O
                {
                    double distancia = CalcularDistanciaEntrePuntos(X1, Y1, X2, Y2);
                    Console.WriteLine($"La distancia entre ({X1},{Y1}) y ({X2},{Y2}) es {distancia}");
                    if (X1 == X2)
                    {
                        Console.WriteLine("Ambos puntos conforman una recta perpendicular al eje X");
                    }
                    else if (Y1 == Y2)
                    {
                        Console.WriteLine("Ambos puntos conforman una recta horizontal");
                    }
                    else
                    {
                        Console.WriteLine("Ambos puntos conforman una recta oblicua");
                    }


                }
                else
                {
                    Console.WriteLine("Ambos puntos son iguales!!!");
                }


            }
            catch (FormatException ex)
            {

                Console.WriteLine("Número mal ingresado");
            }
        }

        private static double CalcularDistanciaEntrePuntos(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
        }
    }
}
