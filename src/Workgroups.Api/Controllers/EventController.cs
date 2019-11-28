using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Workgroups.Api.Hubs;
using Workgroups.Domain.Models;
using Workgroups.Domain.Repositories;

namespace Workgroups.Api.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;
        private readonly IHubContext<GlobalHub, IGlobalHubClient> _globalHubContext;

        public EventController(
            IEventRepository eventRepository,
            IHubContext<GlobalHub, IGlobalHubClient> globalHubContext)
        {
            _eventRepository = eventRepository;
            _globalHubContext = globalHubContext;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateEvent(Event evnt)
        {
            await _eventRepository.AddEvent(evnt);
            await _globalHubContext.Clients.All.EventCreated(evnt);
            return CreatedAtAction(nameof(GetEvent), new { eventId = evnt.Id }, evnt);
        }

        [HttpGet("{eventId}")]
        public Task<Event> GetEvent(Guid eventId)
        {
            return _eventRepository.GetEvent(eventId);
        }

        [HttpGet("upcoming")]
        public Task<List<Event>> GetUpcomingEvents(int count = 30)
        {
            return _eventRepository.GetUpcomingEvents(count);
        }

        [HttpGet]
        public Task<List<Event>> GetEventsForMonth(int month)
        {
            return _eventRepository.GetEventsForMonth(month);
        }
    }
}
