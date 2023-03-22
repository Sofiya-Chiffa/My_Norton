using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Norton
{
    public class Commands
    {
        public static void makeDir(Directories D, string NameDir)
        {
            var st = D.curdir + "\\" + NameDir;
            if (Directory.Exists(st))
            {
                Console.WriteLine("Already exist");
            }
            else if (NameDir == "")
            {
                Console.WriteLine("Wrong Name");
            }
            else
            {
                Directory.CreateDirectory(st);
            }
        }

        public static void makeFile(Directories D, string NameFile)
        {
            var fn = D.curdir + "\\" + NameFile;
            if (NameFile == "")
            {
                Console.WriteLine("Wrong Name");
            }
            else if (Directory.Exists(fn))
            {
                Console.WriteLine("Already exist");
            }
            else
            {
                var newFile = File.Create(fn);
                newFile.Close();
            }
        }
    }
}
