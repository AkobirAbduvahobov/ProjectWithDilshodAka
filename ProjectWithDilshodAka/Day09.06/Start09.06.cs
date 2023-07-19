using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day09._06
{
    class Start09
    {
		public int? Age { get; set; }
		public string Name { get; set; }
		public Start09()
        {
            Run2();
        }
       
        public void Run()
        {
            Age = null;
            (int a, int b) = (4, 8);
        }

        public void Run1()
        {
            var MyTuple = (4, 8, "AkoOne");

            MyTuple.Item1 = 5;

            Console.WriteLine(MyTuple);  
        }

        public void Run2()
        {
            var MyTuple = (Ism: "Akobir", Familiya: "Abduvahobov", Jins : Gender.Male );

            Console.WriteLine(MyTuple);
        }
    }

    public enum Gender
    {
        Male,
        Female,
    }

}
