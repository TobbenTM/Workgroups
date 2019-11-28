using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Workgroups.Domain.Models
{
    [Owned]
    public class FoodoraProduct
    {
        [Key]
        public long Id { get; set; }

        public string ProductId { get; set; }

        public string Code { get; set; }

        public string VendorId { get; set; }

        public int Quantity { get; set; }
    }
}
