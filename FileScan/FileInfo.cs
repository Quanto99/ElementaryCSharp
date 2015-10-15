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
        public Int64 dirSize = 0;
        private Int64 subdirSize = 0;

        public Int64 Scan(DirectoryInfo dir, SearchOption option, string searchPattern, bool print=true)
        {
            Console.WriteLine(dir.FullName);

            for (int i = 0; i < searchPattern.Length; i++)
            {
                FileInfo[] fiArray = dir.GetFiles(searchPattern, option);

                foreach (FileInfo f in fiArray)
                {
                    if (print)  Console.WriteLine("     {0}              {1} bytes", f.Name, f.Length);
                    dirSize += f.Length;
                }
            }

            if (print) Console.WriteLine("{0} directory size {1} bytes", dir.FullName, dirSize);

            // Scan subdirectories (recursively)
            if (option == SearchOption.AllDirectories)
            {
                foreach (string element in Directory.GetDirectories(dir.FullName))
                {
                    DirectoryInfo d = new DirectoryInfo(element);
                    subdirSize += Scan (d, option, searchPattern, print);
                }
            }

            if (print) Console.WriteLine("{0} subdirectory size {1} bytes", dir.FullName, subdirSize);

            return dirSize + subdirSize;
        }
    }
}
