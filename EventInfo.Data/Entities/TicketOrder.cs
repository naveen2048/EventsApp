using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class TicketOrder
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual Order Order { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
