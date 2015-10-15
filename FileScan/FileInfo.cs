using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileScan
{
    class FileInformation
    {
        public static Int64 totalsize = 0;

        public static void Scan(DirectoryInfo dir, SearchOption option, string searchPattern)
        {
            Console.WriteLine(dir.FullName);

            for (int i = 0; i < searchPattern.Length; i++)
            {
                FileInfo[] fiArray = dir.GetFiles(searchPattern, option);

                foreach (FileInfo f in fiArray)
                {
                    Console.WriteLine("     {0}              {1} bytes", f.Name, f.Length);
                    totalsize += f.Length;
                }
            }

            // Scan subdirectories (recursively)
            if (option == SearchOption.AllDirectories)
            {
                foreach (string element in Directory.GetDirectories(dir.FullName))
                {
                    DirectoryInfo d = new DirectoryInfo(element);
                    Scan (d, option, searchPattern);
                    Console.WriteLine("{0} bytes", totalsize);
                }
            }
        }
    }
}
