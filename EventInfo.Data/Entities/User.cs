using System;
using System.Collections.Generic;

namespace EventInfo.Data.Entities
{
    public partial class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
