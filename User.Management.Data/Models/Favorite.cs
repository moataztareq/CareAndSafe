using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public int NannyId { get; set; }
        public Nanny Nanny { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
