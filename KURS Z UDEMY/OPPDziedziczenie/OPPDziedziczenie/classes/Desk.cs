using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDziedziczenie
{
    internal class Desk : Item
    {
        
        public int Width { get; set; }
     
        public Desk(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}
