namespace Ejercicio08B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de compra de divisas");
            Console.Write("Ingrese la cantidad de pesos que desea invertir:");
            int pesosArgentinos = int.Parse(Console.ReadLine()!);

            if (pesosArgentinos > 0)
            {
                //Esto es como el ENTONCES del PSeint
                double dolares = ConvertirPesosArgentinos(pesosArgentinos, 845.50);
                double euros = ConvertirPesosArgentinos(pesosArgentinos, 923.46);
                double yuanes = ConvertirPesosArgentinos(pesosArgentinos, 118.19);
                double reales = ConvertirPesosArgentinos(pesosArgentinos, 5.5);

                Console.WriteLine($"Con {pesosArgentinos} ARS puedo comprar:");
                Console.WriteLine($"    {dolares} USD");
                Console.WriteLine($"    {euros} EUR");
                Console.WriteLine($"    {yuanes} CNY");
                Console.WriteLine($"    {reales} RLS");

            }
            else
            {
                Console.WriteLine("Debe ingresar una cantidad mayor a cero");
            }
            Console.ReadKey();
        }
        static double ConvertirPesosArgentinos(int pesos, double cotizacion)
        {
            return Math.Truncate(pesos / cotizacion);
        }
    }
}
