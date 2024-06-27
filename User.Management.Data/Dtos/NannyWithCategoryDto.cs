using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Dtos
{
    public class NannyWithCategoryDto
    {
        public int NannyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Phone { get; set; }
        public int? ExperienceYear { get; set; }
        public string? Description { get; set; }
        public int? PricePerDaily { get; set; }
        public int? PricePerHour { get; set; }
        public string? NannyImagePath { get; set; }
        public List<CategoryDto> Categories { get; set; }
    }
}
