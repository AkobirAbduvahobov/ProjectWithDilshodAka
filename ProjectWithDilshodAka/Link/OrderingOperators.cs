using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Link
{
    public class OrderingOperators
    {
        public OrderingOperators()
        {
            Run();
        }
        public void Run()
        {
            /// orderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
            /// 

            int[] arr = {11,53,33};
            
            arr = arr.OrderBy(MyOrderBy).ToArray();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public int MyOrderBy(int a)
        {
            return a%10;
        }
    }
}
