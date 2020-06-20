using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarPlus.PRODUCT.Entities
{
    public class Address
    {
        public string ZipPostalCode { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string Complement { get; set; }
    }
}
