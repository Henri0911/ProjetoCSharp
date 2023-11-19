internal class Calculadora
{
    private static void Main(string[] args)
    {
        int num1, num2, num3, result, funcao = 0;

        Console.WriteLine("Escolha sua função: ");
        Console.WriteLine("1 Adição");
        Console.WriteLine("2 Subtração");
        Console.WriteLine("3 Multiplicação");
        Console.WriteLine("4 Divisão");

        funcao = int.Parse(Console.ReadLine());

            switch (funcao)
            {
                case 1:
                    Console.WriteLine("Adição");
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo  numero : ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro número: ");
                    num3 = int.Parse(Console.ReadLine());

                    result = (num1 + num2 + num3);
                    Console.WriteLine("Média total: " + result);
                    break;
                case 2:
                    Console.WriteLine("Subtração");
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo  numero : ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro número: ");
                    num3 = int.Parse(Console.ReadLine());

                    result = (num1 - num2 - num3);
                    Console.WriteLine("Média total: " + result);
                    break;
                case 3:
                    Console.WriteLine("Multiplicação");
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo  numero : ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro número: ");
                    num3 = int.Parse(Console.ReadLine());

                    result = (num1 * num2 * num3);
                    Console.WriteLine("Média total: " + result);
                    break;
                case 4:
                    Console.WriteLine("Divisão");
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo  numero : ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro número: ");
                    num3 = int.Parse(Console.ReadLine());

                    result = (num1 / num2 / num3);
                    Console.WriteLine("Média total: " + result);
                    break;
                default: Console.WriteLine("Escolha errada");
                    break;
            
            }
        }
    }
