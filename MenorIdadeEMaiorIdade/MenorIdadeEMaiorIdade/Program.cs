internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 18)
        {
            Console.WriteLine("Menor de idade");
        }
        else
        {
            Console.WriteLine("Maior de idade");
        }
    }
}