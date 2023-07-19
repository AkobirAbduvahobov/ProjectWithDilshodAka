using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.WorkingFAYL
{
    public class MemoryStreamWork
    {
        public MemoryStreamWork()
        {
            TaskDeleteAnyFile();
            ///TaskMoveAnyFile();
            ///TaskCopyAnyFile();
            ///Task();
        }

        public void TaskDeleteAnyFile()
        {
            string deletingFile = @"C:\Users\Acer\Desktop\mustaqil\кризис.txt";
           
                File.Delete(deletingFile); 
            
        }


        public void TaskCopyAnyFile()
        {
            string copyingFile = @"C:\Users\Acer\Desktop\Fevral Akobir.xlsx";
            string adressToCOpy = @"C:\Users\Acer\Desktop\mustaqil\salom2.xlsx";

            using( FileStream myFile = new FileStream(adressToCOpy, FileMode.Create ) )
            {
                byte[] arr = File.ReadAllBytes(copyingFile);
                myFile.Write( arr, 0, arr.Length );
            }
        }

        public void TaskMoveAnyFile()
        {
            string copyingFile = @"C:\Users\Acer\Desktop\Abduvahobov Akobir Mart 2023.xlsx";
            string adressToCOpy = @"C:\Users\Acer\Desktop\mustaqil\salom2.xlsx";

            using (FileStream myFile = new FileStream(adressToCOpy, FileMode.Create))
            {
                byte[] arr = File.ReadAllBytes(copyingFile);
                myFile.Write(arr, 0, arr.Length);
                File.Delete(copyingFile);
            }
        }


        public void Task()
        {
            string path = @"""C:\Users\Acer\Desktop\Akobir f86.txt";

            byte[] streams = File.ReadAllBytes(path);

            foreach (var stream in streams)
            {
                Console.WriteLine(stream);
            }

        }


    }
}
