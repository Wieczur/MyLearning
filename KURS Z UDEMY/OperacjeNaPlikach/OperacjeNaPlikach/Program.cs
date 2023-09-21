using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacjeNaPlikach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var filePath = "imiona.txt";


            // Sprawwdzic, czy mamy jakies nazwisko zapisane
            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllText(filePath);
                if (fileContent.Length > 0)
                {
                    // Jesli tak, wypisujemy i pytamy o usniecie
                    //            Jesli usunal, wczytujemy nowe
                    //            Jesli nie usunal, konczymy program
                    Console.WriteLine("Imie zapisane to:" + " " + fileContent);
                    Console.WriteLine("Czy chcesz usunac to imie?:");


                    var userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "tak")
                      
                    {
                        // Jesli usunal, wczytujemy nowe
                        File.Delete(filePath);
                    }
                    else
                    {
                        // Jesli nie usunal, konczymy program
                        Console.ReadKey();
                    }
                }

            }
   
            //Jesli nie, wczytujemy i zapisujemy
            Console.WriteLine("Podaj prosze swoje imie: ");
            var userName = Console.ReadLine();
            Console.ReadKey();
            File.WriteAllText(filePath, userName);






        }
    }
}
