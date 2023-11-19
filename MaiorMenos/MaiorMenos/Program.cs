internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Primeiro número digitado é Maior " + num1);
        }
        else
        {
            Console.WriteLine("Segundo número digitado é Maior " + num2);
        }
    }
}