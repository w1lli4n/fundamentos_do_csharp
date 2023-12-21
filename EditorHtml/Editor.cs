using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("EDITOR");
            Start();

            Menu.Show();
        }

        static void Start()
        {
            Console.WriteLine("Esc (sair)");
            Console.WriteLine(">");

            var text = new StringBuilder(); // interessante

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);   
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            string buffer = text.ToString();

            Console.Clear();
            Console.WriteLine("Deseja salvar o arquivo? [s/n]");
            char option = (char)Console.ReadKey(true).Key;

            if (option == 'N')
            {
                System.Environment.Exit(1);
            }
            else
            {
                Salvar(buffer);
            }

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
        }
    }
}