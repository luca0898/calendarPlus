using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarPlus.PRODUCT.Shared.Entities
{
    public abstract class Entity<TKey> : Audit
    {
        public TKey Id { get; set; }
        public bool Deleted { get; set; }
    }
}
