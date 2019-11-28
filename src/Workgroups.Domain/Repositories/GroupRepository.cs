using System;
using System.Threading.Tasks;
using Workgroups.Domain.Models;

namespace Workgroups.Domain.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly WorkgroupsDbContext _dbContext;

        public GroupRepository(WorkgroupsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Group> GetGroup(Guid id)
        {
            return _dbContext.Groups.FindAsync(id);
        }

        public Task AddGroup(Group group)
        {
            _dbContext.Groups.Add(group);
            return _dbContext.SaveChangesAsync();
        }
    }
}
