using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Bungalow : Rentel
    {
        public double SizeYard { get; set; }

        public Bungalow(string name, string location, double size, int rooms, int toilets, double price, double sizeYard) : base(name, location, size, rooms, toilets, price)
        {
            SizeYard = sizeYard;
        }
    }
}
