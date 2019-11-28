using System.Threading.Tasks;
using Workgroups.Domain.Models;

namespace Workgroups.Api.Hubs
{
    public interface IGlobalHubClient
    {
        /// <summary>
        /// Signals that an event has been created for notifying the user about
        /// </summary>
        /// <param name="evnt">The created event</param>
        Task EventCreated(Event evnt);
    }
}
