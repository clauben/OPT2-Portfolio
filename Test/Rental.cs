using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Rentel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Size { get; set; }
        public int Rooms { get; set; }
        public int Toilets { get; set; }
        public double Price { get; set; }


        public Rentel(string name, string location, double size, int rooms, int toilets, double price)
        {
            Name = name;
            Location = location;
            Size = size;
            Rooms = rooms;
            Toilets = toilets;
            Price = price;
        }
    }
}
