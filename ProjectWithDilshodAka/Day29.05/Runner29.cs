using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day29._05
{
   

    class Runner29
    {
        public static void Start()
        {
            Task task = new Task();
            //task.Do();

            task.Do();
        }


        
    }


    


    class Task
    {
        public void Do()
        {
            //List<string> list = new List<string>();
            //list.Add("salom");
            //list.Add("privet");
            //list.Add("hello");
            //IEnumerable<string> values = list;
            //Console.WriteLine(CountElement(  values ) );
            

            

            MyCollection<string> myCollection =  new List<string>() ;


            myCollection.Add( "salom" ) ;
            myCollection.Add( "hello" ) ;
            myCollection.Add( "privet" ) ;

            Console.WriteLine(CheckElement(myCollection, "salom"));
          


        }

        public bool CheckElement(MyCollection<string> aa, string s )
        {
            return aa.Contains(s);
        }
        public int CountElement( IEnumerable<string> values )
        {
            int sanoq = 0;
            foreach ( string value in values )
            {
                ++sanoq;
            }
            return sanoq;
        }
    }

}
