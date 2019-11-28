using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Workgroups.Domain.Models
{
    [Owned]
    public class FoodoraVendor
    {
        [Key]
        public long Id { get; set; }

        public string VendorId { get; set; }
    }
}
