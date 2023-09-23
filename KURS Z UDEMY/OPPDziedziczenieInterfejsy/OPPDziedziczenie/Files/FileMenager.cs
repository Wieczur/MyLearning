using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDziedziczenie
{
    class FileMenager : IMenager
    {
        public void SaveLamp(Lamp lamp)
        {
            var path = "lamps.txt";
            var content = "lampa: " + "Wysokosc - " + lamp.Height + "Moc - " + lamp.Power;

            File.WriteAllText(path, content);
        }
    }
}
