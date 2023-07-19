using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day02_06
{
    internal class Clients : Person
    {
        public static List<string> CarsToSell = new List<string>();
        public static List<string> ClientsName = new List<string>();
        public string CarWant { get; set; }
        public Clients(string carWant, string name)
        {
            CarWant = carWant;
            Name = name;
        }

        public void AddCarToSell()
        {
            CarsToSell.Add(CarWant);
            ClientsName.Add(Name);
        }

        public void SendMessageByClient(int a)
        {

        }
    }
}
