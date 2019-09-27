using System;

namespace EventInfo.Data
{
    public class EventTicket
    {
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public bool IsAvailable { get; set; }
        public int TotalTickets { get; set; }
    }
}
