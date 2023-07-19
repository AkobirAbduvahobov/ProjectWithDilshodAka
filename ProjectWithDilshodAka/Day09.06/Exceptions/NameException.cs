using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day09._06.Exceptions
{
    internal class NameException : Exception
    {
        public override string Message => "Ism uzunligi 2 dan katta bo'lishi kk ";
    }
}
