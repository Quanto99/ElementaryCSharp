using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileScan
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Syntax();
                return;
            }

            bool print = (args.Length > 1 && args[1] == "-p") ? true : false;

            DirectoryInfo d = new DirectoryInfo(args[0]);
            FileInformation f = new FileInformation();
            f.Scan(d, SearchOption.AllDirectories, "*", print);

            Console.WriteLine("TotalSize = {0} MB", f.dirSize/1000000);
        }

        public static void Syntax()
        {
            Console.WriteLine("Syntax:  FileScan <full directory path> -p");
        }
    }
}
