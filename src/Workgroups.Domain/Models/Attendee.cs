using System;
using System.Collections.Generic;

namespace Workgroups.Domain.Models
{
    public class Attendee
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid EventId { get; set; }

        public Event Event { get; set; }

        public string Comment { get; set; }

        public bool IsGoing { get; set; }

        public bool IsOnWaitlist { get; set; }

        public IEnumerable<FoodoraProduct> FoodoraOrder { get; set; }
    }
}
