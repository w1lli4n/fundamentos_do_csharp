using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            DrawScreen();

            char option = WriteOptions();
            HandleMenuOption(option);
        }

        static void DrawScreen()
        {
            // First row
            DrawLine(27, '+', '-');

            // Body
            DrawLine(27, '|', ' ', 8);

            // Last row
            DrawLine(27, '+', '-');
        }

        static void DrawLine(short lineSize, char lineFrame, char lineFill, short lineRepeat = 1)
        {
            for (short lines = 0; lines < lineRepeat; lines++)
            {
                Console.Write(lineFrame);
                for (short column = 0; column < lineSize; column++)
                    Console.Write(lineFill);

                Console.WriteLine(lineFrame);
            }
        }

        static char WriteOptions()
        {
            // Salving where cursor here
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.CursorTop = Console.WindowTop + Console.WindowHeight - 1;

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(1, 1);
            Console.WriteLine("Selecione uma opção: ");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("[a]brir arquivo");

            Console.SetCursorPosition(1, 4);
            Console.WriteLine("[c]riar arquivo");

            Console.SetCursorPosition(1, 6);
            Console.WriteLine("[s]air");

            Console.SetCursorPosition(1, 8);
            Console.Write("Opção: ");

            Console.SetCursorPosition(8, 8);
            char option = (char)Console.ReadKey(false).Key;

            // Restore cursor
            Console.SetCursorPosition(x, y);

            return option;
        }

        static void HandleMenuOption(char option)
        {
            switch (option)
            {
                case 'A':
                    Open.Show();
                    break;
                case 'C':
                    Editor.Show();
                    break;
                case 'S':
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Insira um opção válida!");
                        Console.ReadKey();
                        Menu.Show();
                        break;
                    }
            }
        }
    }
}