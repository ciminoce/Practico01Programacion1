namespace Ejercicio10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilogramos;

            Console.Write("Ingrese el peso en kilogramos (kg): ");
            kilogramos =double.Parse( Console.ReadLine());


            // Realizar las conversiones
            double gramos = kilogramos * 1000;
            double onzas = kilogramos * 35.274;
            double libras = kilogramos * 2.2046;

            // Mostrar los resultados con abreviaturas
            Console.WriteLine($"\n{kilogramos:F2} kg equivalen a:");
            Console.WriteLine($"{gramos:F2} g");
            Console.WriteLine($"{onzas:F2} oz");
            Console.WriteLine($"{libras:F2} lb");

            Console.ReadKey();
        }
    }
}
