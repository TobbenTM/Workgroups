using System;
using System.Collections.Generic;

namespace Workgroups.Domain.Models
{
    public class Event
    {
        public Guid Id { get; set; }

        public Guid HostedById { get; set; }

        public Group HostedBy { get; set; }

        public Guid CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Location { get; set; }

        public string Tags { get; set; }

        public int? MaxNumberOfAttendees { get; set; }

        public IEnumerable<Attendee> Attendees { get; set; }

        public ExternalEvent ExternalEvent { get; set; }

        public IEnumerable<FoodoraVendor> FoodoraVendors { get; set; }
    }
}
