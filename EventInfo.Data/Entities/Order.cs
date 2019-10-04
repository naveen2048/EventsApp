using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class Order
    {
        public Order()
        {
            TicketOrder = new HashSet<TicketOrder>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TicketOrder> TicketOrder { get; set; }
    }
}
