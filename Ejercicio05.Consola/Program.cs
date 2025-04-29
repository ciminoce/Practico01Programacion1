
namespace Ejercicio05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Distancia entre Puntos");
            try
            {
                int X1, Y1, X2, Y2;
                double distancia;
                Console.Write("Ingrese la coord X. del primer punto:");
                X1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord Y. del primer punto:");
                Y1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la coord X. del segundo punto:");
                X2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord Y. del segundo punto:");
                Y2 = int.Parse(Console.ReadLine());
                distancia = CalcularDistanciaEntrePuntos(X1, Y1, X2, Y2);
                Console.WriteLine($"La distancia entre ({X1},{Y1}) y ({X2},{Y2}) es {distancia}");

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
