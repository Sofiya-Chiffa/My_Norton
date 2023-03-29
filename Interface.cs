using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Norton
{
    internal class Interface
    {
        public static void Print(int x, int y, string s, ConsoleColor fg = ConsoleColor.Black)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = fg;
            Console.Write(s);
        }

        public static void MainWindow()
        {
            Console.WindowWidth = 80;
            Console.WindowHeight = 28;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int j = 1; j < 25; j++)
            {
                Print(0, j, "║");
                Print(13, j, "│");
                Print(26, j, "│");
                Print(39, j, "║");
                Print(40, j, "║");
                Print(53, j, "│");
                Print(66, j, "│");
                Print(79, j, "║");

            }
            for (int i = 1; i < 79; i++)
            {
                Print(i, 0, "═");
                Print(i, 25, "═");
                Print(i, 23, "─");
            }

            Print(5, 1, "Name");
            Print(18, 1, "Name");
            Print(31, 1, "Name");

            Print(45, 1, "Name");
            Print(58, 1, "Name");
            Print(71, 1, "Name");

            Print(79, 0, "╗");
            Print(39, 0, "╗");

            Print(0, 23, "╟");
            Print(13, 23, "┼");
            Print(26, 23, "┼");
            Print(39, 23, "╢");

            Print(40, 23, "╟");
            Print(53, 23, "┼");
            Print(66, 23, "┼");
            Print(79, 23, "╢");


            Print(13, 0, "╤");
            Print(26, 0, "╤");
            Print(53, 0, "╤");
            Print(66, 0, "╤");
            Print(13, 25, "╧");
            Print(26, 25, "╧");
            Print(53, 25, "╧");
            Print(66, 25, "╧");

            Print(0, 0, "╔");
            Print(40, 0, "╔");

            Print(0, 25, "╚");
            Print(40, 25, "╚");
            Print(39, 25, "╝");
            Print(79, 25, "╝");

            DateTime localDate = DateTime.Now;
            String l = localDate.ToString();
            String d = "";
            Print(76, 0, l);
            Console.ReadKey();
        }
    }
}
