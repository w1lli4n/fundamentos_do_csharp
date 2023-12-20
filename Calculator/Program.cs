using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Indique a operação desejada: ");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.WriteLine("[5] Sair do programa");

            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Insira uma opção válida!");
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Write("Insira o primeiro valor: ");
            try
            {
                double valorUm = double.Parse(Console.ReadLine());

                Console.Write("Insira o segundo valor: ");

                try
                {
                    double valorDois = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {valorUm + valorDois}");
                }
                catch
                {
                    Console.WriteLine("Por favor, insira um número!");
                }


            }
            catch
            {
                Console.WriteLine("Por favor, insira um número!");
            }
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Write("Insira o primeiro valor: ");
            try
            {
                double valorUm = double.Parse(Console.ReadLine());

                Console.Write("Insira o segundo valor: ");

                try
                {
                    double valorDois = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {valorUm - valorDois}");
                }
                catch
                {
                    Console.WriteLine("Por favor, insira um número!");
                }


            }
            catch
            {
                Console.WriteLine("Por favor, insira um número!");
            }
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Write("Insira o primeiro valor: ");
            try
            {
                double valorUm = double.Parse(Console.ReadLine());

                Console.Write("Insira o segundo valor: ");

                try
                {
                    double valorDois = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {valorUm * valorDois}");
                }
                catch
                {
                    Console.WriteLine("Por favor, insira um número!");
                }


            }
            catch
            {
                Console.WriteLine("Por favor, insira um número!");
            }
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Write("Insira o primeiro valor: ");
            try
            {
                double valorUm = double.Parse(Console.ReadLine());

                Console.Write("Insira o segundo valor: ");

                try
                {
                    double valorDois = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {valorUm / valorDois}");
                }
                catch
                {
                    Console.WriteLine("Por favor, insira um número!");
                }


            }
            catch
            {
                Console.WriteLine("Por favor, insira um número!");
            }
            Console.ReadKey();
            Menu();
        }
    }
}