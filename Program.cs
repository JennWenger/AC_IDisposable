using System;
using System.Collections.Generic;
// using System.Linq;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LearningLine.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp";
            using (var watcher = new FolderWatcher(path))
            {
                Console.WriteLine("Create, rename, and delete files in {0}.", path);
                Console.ReadKey(true);
            }
        }
    }
}
