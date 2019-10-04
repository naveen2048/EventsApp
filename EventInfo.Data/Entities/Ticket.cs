using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class Ticket
    {
        public Ticket()
        {
            TicketOrder = new HashSet<TicketOrder>();
        }

        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual TicketType TypeNavigation { get; set; }
        public virtual ICollection<TicketOrder> TicketOrder { get; set; }
    }
}
