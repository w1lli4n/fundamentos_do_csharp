using System;
using System.IO;

namespace TextEditor
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

            Console.WriteLine("[a]brir arquivo   [c]riar arquivo   [s]air");

            char? data = char.Parse(Console.ReadLine().Substring(0, 1).ToLower());

            if (data == null)
            {
                Console.WriteLine("Insira um opção válida!");
                Menu();
            }

            switch (data)
            {
                case 'a':
                    Abrir();
                    break;
                case 'c':
                    Editar();
                    break;
                case 's':
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Insira um opção válida!");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.Write("Insira o caminho do arquivo: ");
            string path = Console.ReadLine();

            using (var FILE = new StreamReader(path))
            {
                Console.Clear();
                string text = FILE.ReadToEnd();
                Console.WriteLine(text);
                Console.ReadKey();
            }

            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Esc (sair)");
            Console.WriteLine(">");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.Write("Caminho para salvar: ");
            var path = Console.ReadLine();

            using (var FILE = new StreamWriter(path))
            {
                FILE.Write(text);
            }

            Menu();
        }
    }
}