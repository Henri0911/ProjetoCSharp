internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }
}