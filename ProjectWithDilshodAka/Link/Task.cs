using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Link
{
    public class Task
    {
        public Task()
        {
            Run();
        }
        public void Run()
        {
            /// set operators
            /// distinct, except, intersect, union
            
            // Task3();
            //Task2();
            //Task1();
            
        }

        public void Task4()
        {
            /// intersect
            List<string> strings = new List<string>()
            {
                "Abror",
                "Sherzod",
                "Akbar",
            };
        }

        public void Task3()
        {
            /// intersect
            List<int> numbers1 = new List<int>()
            {
                1, 4, 7, 8, 11, 16
            };
            List<int> numbers2 = new List<int>()
            {
                1, 2, 3, 11, 5, 16
            };

            List<int> res = numbers1.Except(numbers2).ToList();
            res.Sort();

            foreach (int i in res)
            {
                Console.WriteLine(i);
            }

        }

        public void Task2()
        {
            /// intersect
            List<int> numbers1 = new List<int>()
            {
                1, 4, 7, 8, 11, 16
            };
            List<int> numbers2 = new List<int>()
            {
                1, 2, 3, 11, 5, 16
            };

            List<int> res = numbers1.Union(numbers2).ToList();
            res.Sort();
            
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }

        }

        public void Task1()
        {
            /// intersect
            List<int> numbers1 = new List<int>()
            {
                1, 4, 7, 8, 11, 16
            };
            List<int> numbers2 = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            var res = numbers1.Intersect(numbers2);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }

        }
    }
}
