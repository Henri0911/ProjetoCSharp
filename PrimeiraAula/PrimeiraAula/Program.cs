using System;   //chama sistema

namespace PrimeiraAula   //nome do programa PrimeiraAula
{
    class Program   //trago minha classe
    {
        static void Main(string[] args) //meu metodo static void main
        {
            Console.WriteLine("Hello World!"); //imprimir hello world
            void nomeIdade()
            {
                Console.WriteLine("Digite seu nome: ");
                String nome;
                nome = Console.ReadLine(); //Entrada de dados em String

                Console.WriteLine("Digite sua idade: ");
                int idade;
                idade = int.Parse(Console.ReadLine()); // Entrada de dados Int

                Console.WriteLine("Seu nome é: " + nome);
                Console.WriteLine("Sua idade é: " + idade);
            }

            nomeIdade(); 
            
        }
    }
}