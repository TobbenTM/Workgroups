using System;
using System.Collections.Generic;

namespace Workgroups.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string AvatarUrl { get; set; }

        public IEnumerable<GroupLeader> LeaderOf { get; set; }

        public IEnumerable<GroupMember> MemberOf { get; set; }

        public IEnumerable<Attendee> Attending { get; set; }
    }
}
