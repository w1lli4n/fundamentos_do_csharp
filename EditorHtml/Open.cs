using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Open
    {
        public static void Show()
        {

            Console.Clear();
            Console.Write("Insira o caminho do arquivo: ");
            string path = Console.ReadLine();

            using (var FILE = new StreamReader(path))
            {
                Console.Clear();
                string text = FILE.ReadToEnd();
                ReplaceHTML(text);
                Console.ReadKey();
            }

            Menu.Show();
        }

        static void ReplaceHTML(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (short i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(words[i].Substring(
                            words[i].IndexOf('>') + 1, 
                            Math.Abs((words[i].IndexOf('>') - words[i].LastIndexOf('<') + 1))   // O codigo dele não funcionou nesta parte, então fiz a minha lógica
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}