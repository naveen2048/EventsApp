using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class Country
    {
        public Country()
        {
            Event = new HashSet<Event>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Event> Event { get; set; }
    }
}
