namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajo con Circunferencias");
            double radio;
            Console.Write("Ingrese el valor del radio de la circunferencia:");

            radio = double.Parse(Console.ReadLine());

            // Calcular el perímetro
            double perimetro = 2 * Math.PI * radio;
            double superficie = Math.PI * Math.Pow(radio, 2);
            double diametro = 2 * radio;
            double longitudArco = Math.PI * diametro;
            Console.WriteLine($"El perímetro de la circunferencia es: {perimetro:F2}");
            Console.WriteLine($"La superficie de la circunferencia es: {superficie:F2}");
            Console.WriteLine($"El diámetro de la circunferencia es: {diametro:F2}");
            Console.WriteLine($"La longitud de media circunferencia es: {longitudArco:F2}");
            Console.ReadKey();
        }
    }
}
