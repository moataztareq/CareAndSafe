using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Dtos
{
    public class ReviewDto
    {
        [Range(1, 5)]
        public int? Rating { get; set; }
        public string? Comment { get; set; }
        public int NannyId { get; set; }
        public int ReviewId { get; set; }
    }
}
