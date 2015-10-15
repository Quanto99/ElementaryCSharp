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

            FileInformation.printLevel printlvl = FileInformation.printLevel.directories;   // default is to print at the directory level

            if (args.Length > 2 && args[1] == "-p")
            {
                switch (args[2])
                {
                    case "all": 
                        printlvl = FileInformation.printLevel.all;
                        break;

                    case "files":
                        printlvl = FileInformation.printLevel.files;
                        break;

                    case "directories":
                        printlvl = FileInformation.printLevel.directories;
                        break;

                    default:
                        printlvl = FileInformation.printLevel.directories;  // default
                        break;
                }
            }
            else
            {
                printlvl = FileInformation.printLevel.directories;  // default
            }

            DirectoryInfo d = new DirectoryInfo(args[0]);
            FileInformation f = new FileInformation();
            f.Scan(d, SearchOption.AllDirectories, "*", printlvl);

            Console.WriteLine("TotalSize = {0} MB", f.dirSize/1000000);
        }

        public static void Syntax()
        {
            Console.WriteLine("Syntax:  FileScan <full directory path> -p [all | files | directories]");
        }
    }
}
