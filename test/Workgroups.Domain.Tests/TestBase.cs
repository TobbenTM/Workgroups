using System;
using Microsoft.EntityFrameworkCore;

namespace Workgroups.Domain.Tests
{
    public class TestBase
    {
        private readonly DbContextOptions<WorkgroupsDbContext> _dbOpts;

        public TestBase()
        {
            _dbOpts = new DbContextOptionsBuilder<WorkgroupsDbContext>()
                .UseInMemoryDatabase($"db_{Guid.NewGuid()}")
                .Options;
        }

        public WorkgroupsDbContext GetInMemoryDb()
        {
            return new WorkgroupsDbContext(_dbOpts);
        }
    }
}
