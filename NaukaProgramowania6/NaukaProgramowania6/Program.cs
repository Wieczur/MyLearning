using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaProgramowania6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lista = new List<int>();

            lista.Add(5);
            lista.Add(3);
            lista.Add(7);

            foreach (var item in lista)
            {

                Console.WriteLine(item);
            }
           

           

           
        }
    }
}

/* Komentarz: 
 * pętla ( for ) wykonuje sie okreslona ilosc razy
 * i = 0; ( iteratory, zmienne które beda w klamerkach w petli ktore pokazuja nam na ktorm jestesmy elemncie ) 
 * i < length; ( warunek do spelnienia dopoki ta ma sie wykonywac )
 * i++ ( co ma sie stac po petli )
 * while ( dopoki ) jezeli warunek jest spelniony to petla bedzie sie wykonywac
 * foreach ( tworzenie listy w kolekcji )
 */