using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(@"
██████╗░░█████╗░██████╗░░██████╗██╗░░██╗  ██╗░░░░░░█████╗░░█████╗░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔════╝██║░░██║  ██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░██║███████║██████╔╝╚█████╗░███████║  ██║░░░░░██║░░██║██║░░╚═╝███████║██║░░██║██║░░██║██████╔╝███████║
██║░░██║██╔══██║██╔══██╗░╚═══██╗██╔══██║  ██║░░░░░██║░░██║██║░░██╗██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
██████╔╝██║░░██║██║░░██║██████╔╝██║░░██║  ███████╗╚█████╔╝╚█████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝  ╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");
        Console.WriteLine("Escolha seu filme: ");
        Console.WriteLine("1 - Gigolô Por Acidente código: 691124");
        Console.WriteLine("2 - American pie Código: 778745");
        Console.WriteLine("3 - A hora do rango: 123112");
        Console.WriteLine();

        Console.WriteLine("Digete seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Filme escolhido: 1,2,3");
        int filme = int.Parse(Console.ReadLine());
        Console.WriteLine();

        DateTime dataAgora = DateTime.Now;
        DateTime data = DateTime.Parse("7");

        switch (filme)
        {
            case 1:
                Console.WriteLine("Cliente: " + nome);
                Console.WriteLine("Filme Gigolô Por Acidente");
                Console.WriteLine("Data do empréstimo do filme " + dataAgora);
                Console.WriteLine("Data da devolução: " + data);
                break;
            case 2:
                Console.WriteLine("Cliente: " + nome);
                Console.WriteLine("Filme American Pie");
                Console.WriteLine("Data do empréstimo do filme " + dataAgora);
                Console.WriteLine("Data da devolução: " + data);
                break;
            case 3:
                Console.WriteLine("Cliente: " + nome);
                Console.WriteLine("Filme A hora do rango");
                Console.WriteLine("Data do empréstimo do filme " + dataAgora);
                Console.WriteLine("Data da devolução: " + data);
                break;
            default:
                Console.WriteLine("Erro na escolha do Filme");
                Console.WriteLine("Até mais...");
                break;
        }
    }
}