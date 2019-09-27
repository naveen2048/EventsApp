using System;

namespace EventInfo.Data
{
    public class EventInfo
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public EventType TypeOfEvent { get; set; }
        public string CityName { get; set; }
        public  string Venue { get; set; }
        public  string Country { get; set; }
        public  DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }

    public enum EventType
    {
        Sports=0,
        Musical=1,
        Awards=3,
        Plays=4,
        Political=5
    }
}
