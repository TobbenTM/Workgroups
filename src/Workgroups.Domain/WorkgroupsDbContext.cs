using Microsoft.EntityFrameworkCore;
using Workgroups.Domain.Models;

namespace Workgroups.Domain
{
    public class WorkgroupsDbContext : DbContext
    {
        public WorkgroupsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupLeader>()
                .HasKey(x => new { x.GroupId, x.UserId });

            modelBuilder.Entity<GroupLeader>()
                .HasOne(x => x.Group)
                .WithMany(g => g.Leaders);

            modelBuilder.Entity<GroupLeader>()
                .HasOne(x => x.User)
                .WithMany(u => u.LeaderOf);

            modelBuilder.Entity<GroupMember>()
                .HasKey(x => new { x.GroupId, x.UserId });

            modelBuilder.Entity<GroupMember>()
                .HasOne(x => x.Group)
                .WithMany(g => g.Members);

            modelBuilder.Entity<GroupMember>()
                .HasOne(x => x.User)
                .WithMany(u => u.MemberOf);

            modelBuilder.Entity<Attendee>()
                .HasKey(x => new { x.EventId, x.UserId });

            modelBuilder.Entity<Attendee>()
                .HasOne(x => x.Event)
                .WithMany(g => g.Attendees);

            modelBuilder.Entity<Attendee>()
                .HasOne(x => x.User)
                .WithMany(u => u.Attending);
        }
    }
}
