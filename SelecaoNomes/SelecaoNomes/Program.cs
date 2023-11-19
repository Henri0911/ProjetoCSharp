internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite nome 1");
        string nome1 = Console.ReadLine();

        Console.WriteLine("Digite nome 2");
        string nome2 = Console.ReadLine();

        Console.WriteLine("Digite nome 3");
        string nome3 = Console.ReadLine();

        Console.WriteLine("Escolha um numero de 1 á 3 :");

        int selecao = int.Parse(Console.ReadLine());

        switch (selecao)
        {
            case 1:
                Console.WriteLine("Salve " + nome1);
                break;
            case 2:
                Console.WriteLine("Opa " + nome2);
                break;
            case 3:
                Console.WriteLine("Eae " + nome3);
                break;
            default:
                Console.WriteLine("Erro");
                break;
        }
    }
}