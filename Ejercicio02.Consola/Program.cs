namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Operaciones Básicas");
                int nro1;
                int nro2;
                int suma, resta, multiplicacion, cociente;
                double division;
                Console.Write("Ingrese el primer número:");
                nro1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número:");
                nro2 = int.Parse(Console.ReadLine());
                suma = nro1 + nro2;
                resta = nro1 - nro2;
                multiplicacion = nro1 * nro2;
                division = nro1 / nro2;//casting
                Console.WriteLine($"La suma es {suma}");
                Console.WriteLine($"La resta es {resta}");
                Console.WriteLine($"La multiplicación es {multiplicacion}");
                Console.WriteLine($"La división es {division}");

            }
            catch (FormatException ex)
            {

                Console.WriteLine("Formato de número no válido"); ;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion no manejada");
            }
        }
    }
}
