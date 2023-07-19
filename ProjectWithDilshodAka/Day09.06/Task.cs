using ProjectWithDilshodAka.Day09._06.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjectWithDilshodAka.Day09._06
{
    public class Task
    {

        public Task()
        {
            Task1();
        }
        public void Task1()
        { 
            List<(string Name, int Age, int Salary, string Emsil)> Customer = new List<(string, int, int, string)>()
            {
                 
                 ( "Bekzod" , 25 , 400, "Odilov@.com" ),
                 ( "Sherzod" , 14 , 380 , "Bahromov@.com" ),
                 ("Okmkjnk", 18, 400, "Odilov@.com"),
                 ("Asror", 18, 400, "Odilov@.ru"),
            };

            foreach (var tuple in Customer)
            {
                UserValidation(tuple);
                Console.WriteLine(tuple);
            }
        }
        public void UserValidation(( string name, int age, int salary, string email ) person )
        {
            if (person.name.Length <= 2)
            {
                throw new NameException();
            }
            else if( !person.email.EndsWith( "@.com" ) )
            {
                throw new EmailExeption();
            }

           



        }

       






    }
}
