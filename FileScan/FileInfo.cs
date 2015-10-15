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

        public enum    printLevel
        {
            none,
            directories,
            files,
            all
        }


        public Int64 Scan(DirectoryInfo dir, SearchOption option, string searchPattern, printLevel printlvl=printLevel.all)
        {
            if (printlvl == printLevel.all | printlvl == printLevel.files) Console.WriteLine(dir.FullName);

            for (int i = 0; i < searchPattern.Length; i++)
            {
                FileInfo[] fiArray = dir.GetFiles(searchPattern, option);

                foreach (FileInfo f in fiArray)
                {
                    if (printlvl == printLevel.all | printlvl == printLevel.files){
                        Console.WriteLine("     {0}              {1} bytes", f.Name, f.Length);}
                    dirSize += f.Length;
                }
            }

            string units = "bytes";
            if (dirSize >= 1048576)
            {
                dirSize /= 1048576; units = "MB";
            }
            else if (dirSize >= 1024)
            {
                dirSize /= 1024; units = "K";
            }

            if (printlvl == printLevel.all | printlvl == printLevel.directories) Console.WriteLine("{0} directory size {1}{2}", dir.FullName, dirSize, units);

            // Scan subdirectories (recursively)
            if (option == SearchOption.AllDirectories)
            {
                foreach (string element in Directory.GetDirectories(dir.FullName))
                {
                    DirectoryInfo d = new DirectoryInfo(element);
                    subdirSize += Scan (d, option, searchPattern, printlvl);
                }
            }

            units = "bytes";
            if (subdirSize >= 1048576)
            {
                subdirSize /= 1048576; units = "MB";
            }
            else if (subdirSize >= 1024)
            {
                subdirSize /= 1024; units = "K";
            }
            if (printlvl == printLevel.all | printlvl == printLevel.directories) Console.WriteLine("{0} subdirectory size {1}{2}", dir.FullName, subdirSize, units);

            return dirSize + subdirSize;
        }
    }
}
