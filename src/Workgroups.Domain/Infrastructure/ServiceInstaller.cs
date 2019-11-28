using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Workgroups.Domain.Repositories;

namespace Workgroups.Domain.Infrastructure
{
    public static class ServiceInstaller
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WorkgroupsDbContext>(opts =>
            {
                var connectionString = configuration.GetConnectionString("Database");
                opts.UseNpgsql(connectionString);
            });
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<IEventRepository, EventRepository>();

            return services;
        }
    }
}
