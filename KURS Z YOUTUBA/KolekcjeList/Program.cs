using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(2);
            //list.Add(5);

            List<Auto> list = new List<Auto>();
            list.Add(new Auto("BMW"));
            list.Add(new Auto("Mercedes"));

            foreach (Auto item in list) 
            {
                Console.WriteLine(item.Nazwa);
            }
            Console.ReadKey();
        }
    }
    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            Nazwa = marka;
        }
    }
}
