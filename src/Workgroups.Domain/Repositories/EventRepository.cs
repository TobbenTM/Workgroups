namespace Workgroups.Domain.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly WorkgroupsDbContext _dbContext;

        public EventRepository(WorkgroupsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
