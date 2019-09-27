using System;

namespace EventInfo.Data
{
    public class Ticket
    {
        public int TciketId { get; set; }
        public string Name { get; set; }
        public TicketType TicketType { get; set; }
    }

    public enum TicketType
    {
        VIP=0,
        Box=1,
        Regular=3
    }
}
