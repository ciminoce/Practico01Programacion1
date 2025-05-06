namespace Ejercicio09.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;

            Console.Write("Ingrese la temperatura en grados Celsius: ");
            celsius = double.Parse(Console.ReadLine());


            // Realizar las conversiones
            //TODO: Crear funciones para calcular las conversiones
            double reaumur = 0.8 * celsius;
            double fahrenheit = (1.8 * celsius) + 32;
            double kelvin = celsius + 273.15;
            double rankine = (1.8 * celsius) + 491.67;

            // Mostrar los resultados
            Console.WriteLine($"\n{celsius:F2} grados Celsius equivalen a:");
            Console.WriteLine($"{reaumur:F2} grados Reaumur");
            Console.WriteLine($"{fahrenheit:F2} grados Fahrenheit");
            Console.WriteLine($"{kelvin:F2} grados Kelvin");
            Console.WriteLine($"{rankine:F2} grados Rankine");

            Console.ReadKey();
        }
    }
}
