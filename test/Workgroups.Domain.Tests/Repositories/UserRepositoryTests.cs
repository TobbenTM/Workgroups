using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workgroups.Domain.Models;
using Workgroups.Domain.Repositories;
using Xunit;

namespace Workgroups.Domain.Tests.Repositories
{
    public class UserRepositoryTests : TestBase
    {
        [Fact]
        public async Task Repository_AddUser_UserIsAdded()
        {
            // Arrange
            var expectedUser = new User
            {
                Name = Guid.NewGuid().ToString(),
            };

            // Act
            using (var dbContext = GetInMemoryDb())
            {
                var repo = new UserRepository(dbContext);
                await repo.AddUser(expectedUser);
            }

            // Assert
            using (var dbContext = GetInMemoryDb())
            {
                Assert.NotEmpty(dbContext.Users);
                var user = await dbContext.Users.SingleAsync();
                Assert.Same(expectedUser.Name, user.Name);
            }
        }
    }
}
