using CalendarPlus.PRODUCT.Enums;
using CalendarPlus.PRODUCT.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarPlus.PRODUCT.Entities
{
    public class Schedule : Entity<string>
    {
        /// <summary>
        /// Data de inicio do procedimento
        /// </summary>
        public DateTimeOffset StartProcedure { get; set; }

        /// <summary>
        /// Data de finalização do procedimento
        /// </summary>
        public DateTimeOffset EndProcedure { get; set; }

        /// <summary>
        /// Tipo de procedimento
        /// </summary>
        public ProcedureTypes Type { get; set; }

        public Customer Customer { get; set; }
    }
}
