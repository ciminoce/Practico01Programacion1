namespace Ejercicio03B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Información de un Cuadrado");
                
                Console.Write("Ingrese la medida del lado del cuadrado:");
                double lado = double.Parse(Console.ReadLine()!);

                if (lado>0)
                {
                    double perimetro = CalcularPerimetro(lado);
                    double superficie = CalcularSuperficie(lado);
                    double diagonal =CalcularDiagonal(lado);
                    Console.WriteLine($"Cuadrado de lado:{lado}");
                    Console.WriteLine($"Perímetro: {perimetro:F2}");
                    Console.WriteLine($"Superficie: {superficie:F2}");
                    Console.WriteLine($"Diagonal..:{diagonal:F2}");

                }
                else
                {
                    Console.WriteLine("El lado debe ser positivo");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Número mal ingresado!!!");
            }
            catch (Exception)
            {

                Console.WriteLine("Excepción no manejada...");
            }
        }

        static double CalcularDiagonal(double lado)
        {
            return Math.Sqrt(2) * lado;
        }

        static double CalcularPerimetro(double lado)
        {
            return lado * 4;
        }
        static double CalcularSuperficie(double lado)
        {
            return Math.Pow(lado, 2);
        }
    }
}
