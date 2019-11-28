using Microsoft.AspNetCore.Mvc;
using Workgroups.Domain.Repositories;

namespace Workgroups.Api.Controllers
{
    [Route("api/groups")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
    }
}
