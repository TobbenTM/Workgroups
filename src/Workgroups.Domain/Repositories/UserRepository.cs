using System;
using System.Threading.Tasks;
using Workgroups.Domain.Models;

namespace Workgroups.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WorkgroupsDbContext _dbContext;

        public UserRepository(WorkgroupsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User> GetUser(Guid id)
        {
            return _dbContext.Users.FindAsync(id);
        }

        public Task AddUser(User user)
        {
            _dbContext.Users.Add(user);
            return _dbContext.SaveChangesAsync();
        }
    }
}
