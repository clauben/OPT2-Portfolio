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
        public double Belasting { get; set; } = 0.2;

        public Apartment(string name, string location, double size, int rooms, int toilets, double price, bool balcony) : base(name, location, size, rooms, toilets, price)
        {
            Balcony = balcony;
        }

        public override double CalculatePrice(int stayDays, Rentel rentel)
        {
            return Price * stayDays + (Price * Belasting);
        }
    }
}
