namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el radio del cilindro:");
                double radio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del cilindro: ");
                double altura = double.Parse(Console.ReadLine());

                if (radio > 0 || altura > 0)
                {
                    double volumen = Math.PI * Math.Pow(radio, 2) * altura;
                    double superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;

                    Console.WriteLine("Datos del cilindro:");
                    Console.WriteLine($"Radio: {radio}");
                    Console.WriteLine($"Altura: {altura}");
                    Console.WriteLine($"Volumen: {volumen}");
                    Console.WriteLine($"Superficie: {superficie}");
                }
                else
                {
                    Console.WriteLine("Los valores de radio y altura deben ser MAYORES que cero!!!");
                }
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Algo se ingreso mal!!!");
            }
        }

    }
}