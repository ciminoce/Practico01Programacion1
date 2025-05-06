namespace Ejercicio04B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajo con Circunferencias");
            Console.Write("Ingrese el valor del radio de la circunferencia:");
            double radio = double.Parse(Console.ReadLine()!);
            if (radio > 0)
            {
                // Calcular el perímetro
                double perimetro = CalcularPerimetro(radio);
                double superficie = CalcularSuperficie(radio);
                double diametro = CalcularDiametro(radio);
                double longitudArco = CalcularLongitudArco(radio);
                Console.WriteLine($"El perímetro de la circunferencia es: {perimetro:F2}");
                Console.WriteLine($"La superficie de la circunferencia es: {superficie:F2}");
                Console.WriteLine($"El diámetro de la circunferencia es: {diametro:F2}");
                Console.WriteLine($"La longitud de media circunferencia es: {longitudArco:F2}");

            }
            else
            {
                Console.WriteLine("El radio de la circunferencia debe ser positivo");
            }
            Console.ReadKey();
        }

        private static double CalcularLongitudArco(double radio)
        {
            return Math.PI * CalcularDiametro(radio);
        }

        static double CalcularPerimetro(double radio)
        {
            return 2 * Math.PI * radio;
        }
        static double CalcularSuperficie(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        static double CalcularDiametro(double radio)
        {
            return 2 * radio;
        }
    }
}
