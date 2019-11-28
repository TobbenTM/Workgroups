using System;
using System.Collections.Generic;

namespace Workgroups.Domain.Models
{
    public class Group
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public string Tags { get; set; }

        public GroupType Type { get; set; }

        public IEnumerable<GroupLeader> Leaders { get; set; }

        public IEnumerable<GroupMember> Members { get; set; }
    }
}
