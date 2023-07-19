using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Link
{
    public class GroupingOperators
    {
        public GroupingOperators()
        {
            Run();
        }
        public void Run()
        {
            /// GroupBy(), INTRO
            


            /// Task3();
            /// Task2();
            /// Task1();
           
        }


        public void Task6()
        {

        }


        public void Task2()
        {
            List<string> list = new List<string>() { "salom", "hello", "ok", "mashina" };

            IEnumerable<IGrouping<bool, string>> res = list.GroupBy(s => s.Contains("a"));

            foreach( var a in res )
            {
                Console.WriteLine(a.Key);
                foreach( var b in a )
                {
                    Console.WriteLine("  " +  b );
                }
            }

        }


        public void Task3()
        {
            /// option 1
            //List<int> numbers = new List<int> { 5,4, 8, 5, 6, 7, 5, 9, 11 };
            //IEnumerable<IGrouping<bool, int>> res = numbers.GroupBy(son => son % 2 == 0);
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i.Key);
            //    foreach(var group in i)
            //    {
            //        Console.WriteLine("  " + group);
            //    }
            //}

            /// option2

          



        }
        public void Task1()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Abror", LastName = "Odilov"},
                new Person() {Name = "Axror", LastName = "Abdulayev"},
                new Person() {Name = "Lobar", LastName = "Kenjayev"},
                new Person() {Name = "Sevara", LastName = "Toxirov"},
                new Person() {Name = "Odina", LastName = "Toxirov"},
                new Person() {Name = "Sevara", LastName = "Toxirov"},
                new Person() {Name = "Zebo", LastName = "Odilov"},
                new Person() {Name = "Zebo", LastName = "Kenjayev"},
            };


            IEnumerable<IGrouping<string, Person>> GroupedList = people.GroupBy(x => x.LastName);

            foreach (var grouping in GroupedList)
            {
                Console.WriteLine(grouping.Key);
                foreach (var person in grouping)
                {
                    Console.WriteLine("  " + person.Name);
                }
                Console.WriteLine();
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
