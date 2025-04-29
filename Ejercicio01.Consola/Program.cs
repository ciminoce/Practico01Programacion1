namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Suma de dos números");
                //Definición de variables
                int numero1, numero2;
                int resultadoSuma;
                Console.Write("Ingrese el primer número:");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número:");
                numero2 = int.Parse(Console.ReadLine());
                resultadoSuma = numero1 + numero2;
                Console.WriteLine($"La suma de {numero1} y {numero2} es {resultadoSuma}");

            }
            catch (Exception)
            {

                Console.WriteLine("Número mal ingresado");
            }  
        }
    }
}
