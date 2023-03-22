using System;

namespace My_Norton
{
    class Programm
    {
        static void Main(string[] args)
        {
            Directories D = new Directories();
            Console.WriteLine(Directories.ShortDir(D.GetDir()));
            string s = Console.ReadLine();
            D.SetDir(s);
            Console.WriteLine(Directories.ShortDir(D.GetDir()));
            D.PrintDir(D);
            Commands.makeDir(D, "Mouse");
        }
    }
}
