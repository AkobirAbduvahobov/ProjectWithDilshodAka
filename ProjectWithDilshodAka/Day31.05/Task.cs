using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day31._05
{
   class Task
   {
        public delegate void DelegateMath();

        public void Do()
        {
            DelegateMath delegateMath = Do1;
            delegateMath += Do2;
            delegateMath.Invoke();
            delegateMath = delegateMath - Do1;
            delegateMath = delegateMath - Do2;
            delegateMath.Invoke();

        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void Do1()
        {
            Console.WriteLine("Salom");
        }
        public void Do2()
        {
            Console.WriteLine("Hello");
        }
   } 
}