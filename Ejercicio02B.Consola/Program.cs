namespace Ejercicio02B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Operaciones Básicas");
                Console.Write("Ingrese el primer número:");
                int nro1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número:");
                int nro2 = int.Parse(Console.ReadLine());
                int suma = nro1 + nro2;
                int resta = nro1 - nro2;
                int multiplicacion = nro1 * nro2;
                Console.WriteLine($"La suma es {suma}");
                Console.WriteLine($"La resta es {resta}");
                Console.WriteLine($"La multiplicación es {multiplicacion}");
                if (nro2!=0)
                {
                    int division = nro1 / nro2;
                    Console.WriteLine($"La división es {division}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero");
                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine("Formato de número no válido"); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion no manejada");
            }
        }
    }
}

