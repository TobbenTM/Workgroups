using System;
using System.Threading.Tasks;
using Workgroups.Domain.Models;

namespace Workgroups.Domain.Repositories
{
    public interface IGroupRepository
    {
        Task<Group> GetGroup(Guid id);

        Task AddGroup(Group group);
    }
}
