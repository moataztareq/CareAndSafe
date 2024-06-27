using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Models
{
    public class Review
    {
        
        public int ReviewId { get; set; }
        
        [Range(1, 5)]
        public int? Rating { get; set; } // e.g., 1 to 5
        public string? Comment { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int NannyId { get; set; }
        public Nanny Nanny { get; set; }

    }
}
