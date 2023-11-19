using System.Data;

void cadastro()
{
    Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░"
    );
    Console.WriteLine("Digite seu nome: ");//nome
    string nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");//idade
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu cpf: ");//cpf
    string cpf = Console.ReadLine();

    Console.WriteLine("Digite seu cep: ");//cep
    double cep = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu Email: "); //email
    string email = Console.ReadLine();

    Console.WriteLine("Digite sua senha: "); // senha
    string password = Console.ReadLine();

    Console.WriteLine("digite seu local de nascimento"); //nascimento
    string local = Console.ReadLine();

    Console.WriteLine("estado civil");
    string estadoCivil = Console.ReadLine();
    Console.Clear();



    Console.WriteLine("\n************************");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Sua idade: " + idade);
    Console.WriteLine("Seu CPF: " + cpf);
    Console.WriteLine("Seu CEP: " + cep);
    Console.WriteLine("Seu Email: " + email);
    Console.WriteLine("sua senha: ******");
    Console.WriteLine("seu local nascimento: " + local);
    Console.WriteLine("seu estado civil: " + estadoCivil);
    Console.WriteLine("\n************************");
}

cadastro();
//Console.Clear();