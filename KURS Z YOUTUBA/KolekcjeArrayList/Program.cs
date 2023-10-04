using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjeArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Michal");
            list.Add(new Auto("BMW"));
            //list.RemoveAt(1);
            //list.Insert(0, "Ola");
            //Console.WriteLine(list.Count);
            //list.Clear();
            //Console.WriteLine(list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
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
        public override string ToString()
        {
            return Nazwa;
        }
       


    }
}
