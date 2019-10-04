using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class Event
    {
        public Event()
        {
            Order = new HashSet<Order>();
            Ticket = new HashSet<Ticket>();
            TicketOrder = new HashSet<TicketOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Venue { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public virtual City CityNavigation { get; set; }
        public virtual Country CountryNavigation { get; set; }
        public virtual EventType TypeNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<TicketOrder> TicketOrder { get; set; }
    }
}
