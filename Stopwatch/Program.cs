using System;
using System.Threading;

namespace Stopwatch
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

            Console.WriteLine("Insira o tempo: ");
            Console.WriteLine(" (n)[s]egundos - (n)[m]inutos - (n)[h]oras - [f]inalizar");
            string data = Console.ReadLine();

            char grandeza = char.Parse(data.Substring(data.Length - 1, 1).ToLower());

            int time = 0;

            try
            {
                time = int.Parse(data.Substring(0, data.Length - 1));
            }
            catch
            {
                time = 0;
            }

            switch (grandeza)
            {
                case 'f':
                    Environment.Exit(0);
                    break;
                case 's':
                    break;
                case 'm':
                    Start(time * 60);
                    break;
                case 'h':
                    Start(time * 3600);
                    break;
                default:
                    Console.WriteLine("Insira uma opção válida!");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"{currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Finalizado...");
            Thread.Sleep(2000);

            Menu();
        }
    }
}
