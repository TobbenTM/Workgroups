using System.Collections.Generic;

namespace Workgroups.Domain.Models
{
    public class Attendee
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public long EventId { get; set; }

        public Event Event { get; set; }

        public string Comment { get; set; }

        public bool IsGoing { get; set; }

        public bool IsOnWaitlist { get; set; }

        public IEnumerable<FoodoraProduct> FoodoraOrder { get; set; }
    }
}
