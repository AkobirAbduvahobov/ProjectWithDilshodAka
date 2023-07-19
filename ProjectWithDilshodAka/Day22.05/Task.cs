using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day22._05
{
    public static class Task
    {
        public static int CountWords( this string str )
        {
            while( str.Contains("  ") )
            {
                str = str.Replace("  ", " ");
            }
            int a = str.Split(' ').Count();
            return a;
        }

    }
}
