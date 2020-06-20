using CalendarPlus.PRODUCT.Shared;
using CalendarPlus.PRODUCT.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarPlus.PRODUCT.Entities
{
    public class Customer: Entity<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<PersonDocuments> DocumentNumber { get; set; }
        public string Gender { get; set; }

        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public IEnumerable<string> Emails { get; set; }

        public IEnumerable<Address> Addresses { get; set; }

        /// <summary>
        /// Get the customer full name
        /// </summary>
        /// <returns></returns>
        public string FullName()
        {
            StringBuilder fullName =  new StringBuilder();

            fullName.Append(FirstName.Trim());
            fullName.Append(" ");
            fullName.Append(LastName.Trim());

            return fullName.ToString();
        }
    }
}
