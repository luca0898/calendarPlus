using CalendarPlus.Product.Entities.Shared;
using System;

namespace CalendarPlus.Product.Entities
{
    public class Schedule : Entity
    {
        public DateTime Date { get; set; }

        public bool ProcedurePerformed { get; set; }
    }
}
