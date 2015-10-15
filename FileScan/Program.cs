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

            DirectoryInfo d = new DirectoryInfo(args[0]);
            FileInformation.Scan(d, SearchOption.AllDirectories, "*");

            Console.WriteLine("TotalSize = {0}", FileInformation.totalsize);
        }

        public static void Syntax()
        {
            Console.WriteLine("Syntax:  FileScan <full directory path>");
        }
    }
}
