using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class City
    {
        public City()
        {
            Event = new HashSet<Event>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Country { get; set; }

        public virtual Country IdNavigation { get; set; }
        public virtual ICollection<Event> Event { get; set; }
    }
}
