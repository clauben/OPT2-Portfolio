using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Apartment : Rentel
    {
        public bool Balcony { get; set; }

        public Apartment(string name, string location, double size, int rooms, int toilets, double price, bool balcony) : base(name, location, size, rooms, toilets, price)
        {
            Balcony = balcony;
        }
    }
}
