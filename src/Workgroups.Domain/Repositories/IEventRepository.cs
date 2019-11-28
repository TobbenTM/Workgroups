using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workgroups.Domain.Models;

namespace Workgroups.Domain.Repositories
{
    public interface IEventRepository
    {
        Task AddEvent(Event evnt);

        Task<Event> GetEvent(Guid eventId);

        Task<List<Event>> GetUpcomingEvents(int count);

        Task<List<Event>> GetEventsForMonth(int month);

        Task<Attendee> AttendEvent(Guid eventId, User user);
    }
}
