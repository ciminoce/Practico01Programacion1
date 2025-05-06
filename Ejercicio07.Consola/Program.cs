namespace Ejercicio07.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Usar constantes
            double kilometros;

            Console.Write("Ingrese la distancia en kilómetros: ");
            kilometros = double.Parse(Console.ReadLine());


            // Realizar las conversiones
            double millas = kilometros * 0.621371192;
            double yardas = kilometros * 1093.6133;
            double metros = kilometros * 1000;

            // Mostrar los resultados
            Console.WriteLine($"{kilometros:F2} kilómetros equivalen a:");
            Console.WriteLine($"{millas:F4} millas");
            Console.WriteLine($"{yardas:F2} yardas");
            Console.WriteLine($"{metros:F2} metros");

            Console.ReadKey();
        }
    }
}
