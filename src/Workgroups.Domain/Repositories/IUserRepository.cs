using System;
using System.Threading.Tasks;
using Workgroups.Domain.Models;

namespace Workgroups.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUser(Guid id);

        Task AddUser(User user);
    }
}
