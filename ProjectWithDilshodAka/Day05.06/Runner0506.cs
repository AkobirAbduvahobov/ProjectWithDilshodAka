using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day05._06
{
    public delegate int SSSS(string s);
    internal class Runner0506
    {
        public static void Run()
        {
            Console.WriteLine("1 masala ");
            Func<int, int, int> funcByMe = (a, b) => a + b;
            Console.WriteLine(funcByMe(45,5));
            Console.WriteLine();
            Console.WriteLine("2 masala");
            funcByMe += Kopp;
            Console.WriteLine(funcByMe.Invoke(15,5));
            Console.WriteLine();
            Console.WriteLine("3 masala");





        }

        public static int Kopp(int a, int b) => a * b;

        public void Cheese(string s) =>  Console.WriteLine("Salom") ;
       
    }
}//.exe
