using System;

namespace Atividade8
{
    class Caixa
    {
        static double Saldo = 0;

        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();

            double resposta = 0;

            Console.WriteLine("Bem-Vindo ao Caixa Eletrônico!\n");

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Consultar Saldo\n2 - Sacar\n3 - Depositar\n4 - Sair\n");

            resposta = double.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: ConsultarSaldo(); break;
                case 2: Sacar(); break;
                case 3: Depositar(); break;
                case 4: Sair(); break;
                default:
                    break;
            }

        }

        public static void ConsultarSaldo()
        {
            Console.Clear();

            Thread.Sleep(500);
            Console.WriteLine ($"Seu saldo atual é: R${Saldo:F2}");
            Thread.Sleep(3000);

            Menu();
        }

        public static void Sacar()
        {
            Console.Clear();

            Thread.Sleep(500);
            Console.WriteLine("Digite o valor que deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());

            if (saque <= Saldo)
            {
                Saldo = Saldo - saque;

                Thread.Sleep(500);
                Console.WriteLine($"\nSeu saldo atual é de: R${Saldo:F2}");
                Thread.Sleep(3000);
            }

            else
            {
                Thread.Sleep(500);
                Console.WriteLine("Saldo insuficiente!");
                Thread.Sleep(3000);

                return;
            }

            Menu();
        }

        public static void Depositar()
        {
            Console.Clear();
            Thread.Sleep(500);

            Console.WriteLine("Digite o valor que deseja despositar:");
            double deposito = double.Parse (Console.ReadLine());

            Saldo = deposito + Saldo;

            Console.WriteLine($"Deposito realizado com sucesso! Novo Saldo: R${Saldo:F2}");

            Thread.Sleep(2000);

            Menu();

        }

        public static void Sair()
        {
            Console.Clear();

            Thread.Sleep(500);
            Console.WriteLine("Obrigado por usar o Caixa Eletrônico!");
            Thread.Sleep(2000);

            Console.Clear();
        }
    }
}