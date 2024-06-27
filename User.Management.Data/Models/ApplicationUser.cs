using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Models
{
    public class ApplicationUser : IdentityUser
    {


        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }

        public List<Booking>? Bookings { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<Favorite>? Favorites { get; set; }
    }

    
}
