using System;

namespace entradaUsuario

{
    class Program

    {
        static void Main()

        {
            Console.Clear();
            // Cria um texto informando ao usuário para digitar algo
            Console.WriteLine("Digite seu nome :");

            // cria uma variável do tipo string e atribui ao que o usuário irá digitar
            string userName = Console.ReadLine();

            // dá a saida da variável que o usuário digitou. 
            Console.WriteLine("Seu nome é : " + userName);
            Console.Clear();

            Console.WriteLine("digite sua idade : ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSua idade é " + idade);





        }
    }
}
