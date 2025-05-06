namespace Ejercicio08.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de compra de divisas");
            Console.Write("Ingrese la cantidad de pesos que desea invertir:");
            int pesosArgentinos=int.Parse(Console.ReadLine()!);

            double dolares =Math.Truncate(pesosArgentinos / 845.50);
            double euros = Math.Truncate(pesosArgentinos / 923.46);
            double yuanes = Math.Truncate(pesosArgentinos / 118.19);

            Console.WriteLine($"Con {pesosArgentinos} ARS puedo comprar:");
            Console.WriteLine($"    {dolares} USD");
            Console.WriteLine($"    {euros} EUR");
            Console.WriteLine($"    {yuanes} CNY");
            Console.ReadKey();

        }
    }
}
