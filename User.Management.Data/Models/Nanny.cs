using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Models
{
    public class Nanny
    {
        public int NannyId { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string LastName { get; set; }
        public string? Phone { get; set; }
        public int? ExperienceYear { get; set; }
        public string? Description { get; set; }
        public int? PricePerDaily { get; set; }
        public int? PricePerHour { get; set; }
        public string? NannyImagePath { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<Favorite>? Favorites { get; set; }
        public List<Booking>? Bookings { get; set; }

    }
}
