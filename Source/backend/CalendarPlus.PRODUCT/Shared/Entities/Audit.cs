using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarPlus.PRODUCT.Shared.Entities
{
    public class Audit
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdateAt { get; set; }


        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
