using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.WorkingFAYL
{
    public class TaskWithFiles
    {
        public TaskWithFiles()
        {
            Run();
        }
        public static string path = @"D:\";
        string x;
        int a;
        public static string[] allFiles = Directory.GetFileSystemEntries(@"D:\");
        public void Run()
        {
            Show(path);
            
            Console.Write("Enter : ");

            a = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            Info();
            

            
        }

        public void Info()
        {
            Console.WriteLine("1. Enter ");
            Console.WriteLine("2. Back ");
            Console.WriteLine("3. Quit ");

            Console.WriteLine("Enter : ");
            x = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
            if (x == "1")
            {
                path = allFiles[a];
                Run();
            }
            if (x == "2")
            {

            }
            if (x == "3")
            {
                return;
            }

        }


        public void Show( string path)
        {
            allFiles = Directory.GetFileSystemEntries(path);
            for ( int i = 0; i < allFiles.Length; i++ )
            {
                Console.WriteLine(i + " " + allFiles[i] );
            }
        }

       
    }
}
