namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Información de un Cuadrado");
                double lado, perimetro, superficie, diagonal;
                Console.Write("Ingrese la medida del lado del cuadrado:");
                lado = double.Parse(Console.ReadLine()!);

                perimetro = lado * 4;
                superficie = Math.Pow(lado, 2);
                diagonal = Math.Sqrt(2) * lado;
                Console.WriteLine($"Cuadrado de lado:{lado}");
                Console.WriteLine($"Perímetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
                Console.WriteLine($"Diagonal..:{diagonal}");

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Número mal ingresado!!!");
            }
            catch (Exception)
            {

                Console.WriteLine("Excepción no manejada...");
            }   
        }
    }
}
