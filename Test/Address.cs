using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public Address(string city, string country, string postalCode)
        {
            City = city;
            Country = country;
            PostalCode = postalCode;
        }      
    }
}
