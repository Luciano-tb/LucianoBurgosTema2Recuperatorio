namespace ConsoleApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Radio: ");
                    double radio = ;

                    Console.Write("Altura: ");
                    double altura = ;

                    if (radio > 0 || altura > 0)
                    {
                        double volumen = Math.PI * radio * radio * altura;
                        double superficie = 2 * Math.PI * radio * (radio + altura);

                        Console.WriteLine($"Volumen: {volumen}");
                        Console.WriteLine($"Superficie: {superficie}");
                    }
                    else
                    {
                        Console.WriteLine("Los valores de radio y altura deben ser MAYORES que cero!!!");
                    }
                    Console.Write("¿Otro cilindro? : ");

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Algo se ingreso mal!!!");
            }
        }
        }
    }
}
