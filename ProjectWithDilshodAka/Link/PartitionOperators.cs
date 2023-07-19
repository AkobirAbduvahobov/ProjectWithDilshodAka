using System;
using System.Linq;

namespace ProjectWithDilshodAka.Link
{
    public class PartitionOperators
    {
        public PartitionOperators()
        {
            Run();
        }
        public void Run()
        {
            /// Take(), Where(), TakeWhile(), Skip(), SkipWile()
            int range = 3;
            int pN = 2;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var res = arr.Skip((pN - 1) * range).Take(range);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }




        }
    }
}
