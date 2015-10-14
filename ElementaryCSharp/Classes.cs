using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ElementaryCSharp
{
    public class Classes
    {
        static Classes()
        {
            Console.WriteLine("Static constructor execution.");
        }

    }

    public static class DirectoryInfoExtension
    {
        public static void CopyTo ( DirectoryInfo sourceDirectory, string target, SearchOption option, string searchPattern)
        {
            if (target[target.Length - 1] != Path.DirectorySeparatorChar)
            {
                target += Path.DirectorySeparatorChar;
            }
            if ( !Directory.Exists(target) )
            {
                Directory.CreateDirectory(target);


                for (int i = 0; i < searchPattern.Length; i++)
                {
                    foreach (string file in Directory.GetFiles(sourceDirectory.FullName, searchPattern))
                    {
                        Console.WriteLine("Copying {0} to {1}", file, target + Path.GetFileName(file));
                        File.Copy(file, target + Path.GetFileName(file), true);
                    }
                }

                // Copy subdirectories (recursively)
                if (option == SearchOption.AllDirectories)
                {
                    foreach (string element in Directory.GetDirectories(sourceDirectory.FullName))
                    {
                        DirectoryInfo d = new DirectoryInfo(element);
                        CopyTo(d, target + Path.GetFileName(element), option, searchPattern);
                    }
                }
            }
        }
    }

}
