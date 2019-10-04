using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class TicketType
    {
        public TicketType()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
