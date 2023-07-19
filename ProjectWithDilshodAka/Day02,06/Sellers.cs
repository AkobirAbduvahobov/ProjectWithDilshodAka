using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day02_06
{
    internal class Sellers : Person
    {
        public static List<string> CarsToBuy = new List<string>();
        public static List<string> SallersName = new List<string>();
        public static Bozor makler;
        public int k { get; set; } = -1;
        public string CarHave { get; set; }
        public Sellers(string carHave, string name)
        {
            CarHave = carHave;
            Name = name;
            Check();
        }
        
        public void Check()
        {
            k = Clients.CarsToSell.IndexOf(CarHave);
            if (k < 0) return;
            makler += SendMessageBySeller;
            
        }

        public void AddCarToBuy()
        {
            CarsToBuy.Add(CarHave); 
            SallersName.Add(Name);
        }
        public void SendMessageBySeller(int a)
        {
            Console.WriteLine();
        }
    }
}
