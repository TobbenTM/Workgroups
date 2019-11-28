using Microsoft.EntityFrameworkCore;

namespace Workgroups.Domain.Models
{
    [Owned]
    public class ExternalEvent
    {
        public EventSource Source { get; set; }

        public string Url { get; set; }

        public string EventId { get; set; }
    }
}
