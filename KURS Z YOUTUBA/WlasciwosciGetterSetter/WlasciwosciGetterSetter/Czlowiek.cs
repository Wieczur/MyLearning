using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WlasciwosciGetterSetter
{
    internal class Czlowiek
    {
        public string imie;

        private int wiek;

        public int Wiek
        {
            get { return wiek; }
            set 
            {
                if (value >= 0 && value <= 200)
                    wiek = value;
                else
                    wiek = 0;
            }
        }








        // przyjmownie getterow i setterow w innych jezykach programowania
        //public int getWiek()
        //{
        //    return wiek;
        //}

        //public void setWiek(int w)
        //{
        //    if(w >= 0 && w <= 200)
        //    wiek = w;
        //}

    }
}
