using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OPPDziedziczeniecz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 50);
            Console.WriteLine(p1.imie + " " + p1.punktyHP + " " + p1.mana);
        }
    }

    abstract class Postac
    {

        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public abstract void Ruch();

        public string imie;
        public int punktyHP;


    }

    class Mag : Postac
    {

        public Mag(string imie, int punktyHP, int mana) : base("ELF", 200)
        {
            this.mana = mana;
        }
        public int mana;

        public override void Ruch()
        {
            Console.WriteLine("Ruch Maga");
        }
    }
}

// saled - zapieczentowany, zablkokowany
// abstract - abstrakcyjny


