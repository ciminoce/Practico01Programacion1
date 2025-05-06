namespace Ejercicio06.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Explicar asignación de resultados
            double ladoMayor;
            double ladoMenor;

            Console.Write("Ingrese la longitud del lado mayor del rectángulo: ");
            ladoMayor = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la longitud del lado menor del rectángulo: ");
            ladoMenor = double.Parse(Console.ReadLine());
            //TODO:Verificar lados

            // Calculos

            double perimetro = 2 * ladoMayor + 2 * ladoMenor;
            double superficie = ladoMayor * ladoMenor;
            double diagonal = Math.Sqrt(Math.Pow(ladoMayor, 2) + Math.Pow(ladoMenor, 2));
            Console.WriteLine($"El perímetro del rectángulo es: {perimetro:F2}");
            Console.WriteLine($"La superficie del rectángulo es: {superficie:F2}");
            Console.WriteLine($"La diagonal del rectángulo es: {diagonal:F2}");
            Console.ReadKey();
        }
    }
}
