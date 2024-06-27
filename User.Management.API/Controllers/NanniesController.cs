using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User.Management.Data.Dtos;
using User.Management.Data.Models;

namespace User.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NanniesController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public NanniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Nannies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NannyDto>>> GetNannies()
        {
            return await _context.Nannies
                .Select(n => new NannyDto
                {
                    NannyId = n.NannyId,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Phone = n.Phone,
                    ExperienceYear = n.ExperienceYear,
                    Description = n.Description,
                    PricePerDaily = n.PricePerDaily,
                    PricePerHour = n.PricePerHour,
                    NannyImagePath = n.NannyImagePath
                })
                .ToListAsync();
        }

        // GET: api/Nannies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NannyDto>> GetNanny(int id)
        {
            var nanny = await _context.Nannies
                .Select(n => new NannyDto
                {
                    NannyId = n.NannyId,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Phone = n.Phone,
                    ExperienceYear = n.ExperienceYear,
                    Description = n.Description,
                    PricePerDaily = n.PricePerDaily,
                    PricePerHour = n.PricePerHour,
                    NannyImagePath = n.NannyImagePath
                })
                .FirstOrDefaultAsync(n => n.NannyId == id);

            if (nanny == null)
            {
                return NotFound();
            }

            return nanny;
        }

        // POST: api/Nannies
        [HttpPost]
        public async Task<ActionResult<NannyDto>> PostNanny(NannyDto nannyDto)
        {
            var nanny = new Nanny
            {
                FirstName = nannyDto.FirstName,
                LastName = nannyDto.LastName,
                Phone = nannyDto.Phone,
                ExperienceYear = nannyDto.ExperienceYear,
                Description = nannyDto.Description,
                PricePerDaily = nannyDto.PricePerDaily,
                PricePerHour = nannyDto.PricePerHour,
                NannyImagePath = nannyDto.NannyImagePath
            };

            _context.Nannies.Add(nanny);
            await _context.SaveChangesAsync();

            nannyDto.NannyId = nanny.NannyId;

            return CreatedAtAction(nameof(GetNanny), new { id = nanny.NannyId }, nannyDto);
        }

        // PUT: api/Nannies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNanny(int id, NannyDto nannyDto)
        {
            if (id != nannyDto.NannyId)
            {
                return BadRequest();
            }

            var nanny = await _context.Nannies.FindAsync(id);
            if (nanny == null)
            {
                return NotFound();
            }

            nanny.FirstName = nannyDto.FirstName;
            nanny.LastName = nannyDto.LastName;
            nanny.Phone = nannyDto.Phone;
            nanny.ExperienceYear = nannyDto.ExperienceYear;
            nanny.Description = nannyDto.Description;
            nanny.PricePerDaily = nannyDto.PricePerDaily;
            nanny.PricePerHour = nannyDto.PricePerHour;
            nanny.NannyImagePath = nannyDto.NannyImagePath;

            _context.Entry(nanny).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NannyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Nannies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNanny(int id)
        {
            var nanny = await _context.Nannies.FindAsync(id);
            if (nanny == null)
            {
                return NotFound();
            }

            _context.Nannies.Remove(nanny);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        //--------------------------------------------------------------------------------------------

        [HttpGet("NanniesWithCategory")]
        public async Task<ActionResult<IEnumerable<NannyWithCategoryDto>>> GetNanniesWithCategory()
        {
            var nannies = await _context.Nannies
                .Include(n => n.Categories)
                .Select(n => new NannyWithCategoryDto
                {
                    NannyId = n.NannyId,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Phone = n.Phone,
                    ExperienceYear = n.ExperienceYear,
                    Description = n.Description,
                    PricePerDaily = n.PricePerDaily,
                    PricePerHour = n.PricePerHour,
                    NannyImagePath = n.NannyImagePath,
                    Categories = n.Categories.Select(c => new CategoryDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description
                    }).ToList()
                })
                .ToListAsync();

            return nannies;
        }

        
        [HttpGet("NanniesWithCategory/{id}")]
        public async Task<ActionResult<NannyWithCategoryDto>> GetNanniesWithCategory(int id)
        {
            var nanny = await _context.Nannies
                .Include(n => n.Categories)
                .Select(n => new NannyWithCategoryDto
                {
                    NannyId = n.NannyId,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Phone = n.Phone,
                    ExperienceYear = n.ExperienceYear,
                    Description = n.Description,
                    PricePerDaily = n.PricePerDaily,
                    PricePerHour = n.PricePerHour,
                    NannyImagePath = n.NannyImagePath,
                    Categories = n.Categories.Select(c => new CategoryDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description
                    }).ToList()
                })
                .FirstOrDefaultAsync(n => n.NannyId == id);

            if (nanny == null)
            {
                return NotFound();
            }

            return nanny;
        }

        
        [HttpPost("NannyWithCategory")]
        public async Task<ActionResult<NannyWithCategoryDto>> PostNanny(NannyWithCategoryDto nannyDto)
        {
            var nanny = new Nanny
            {
                FirstName = nannyDto.FirstName,
                LastName = nannyDto.LastName,
                Phone = nannyDto.Phone,
                ExperienceYear = nannyDto.ExperienceYear,
                Description = nannyDto.Description,
                PricePerDaily = nannyDto.PricePerDaily,
                PricePerHour = nannyDto.PricePerHour,
                NannyImagePath = nannyDto.NannyImagePath,
                Categories = new List<Category>()
            };

            foreach (var categoryDto in nannyDto.Categories)
            {
                var category = await _context.Categories.FindAsync(categoryDto.Id);
                if (category != null)
                {
                    nanny.Categories.Add(category);
                }
            }

            _context.Nannies.Add(nanny);
            await _context.SaveChangesAsync();

            nannyDto.NannyId = nanny.NannyId;

            return CreatedAtAction(nameof(GetNanny), new { id = nanny.NannyId }, nannyDto);
        }

        // PUT: api/Nannies/5
        [HttpPut("NanniesWithCategory/{id}")]
        public async Task<IActionResult> PutNanny(int id, NannyWithCategoryDto nannyDto)
        {
            if (id != nannyDto.NannyId)
            {
                return BadRequest();
            }

            var nanny = await _context.Nannies
                .Include(n => n.Categories)
                .FirstOrDefaultAsync(n => n.NannyId == id);

            if (nanny == null)
            {
                return NotFound();
            }

            nanny.FirstName = nannyDto.FirstName;
            nanny.LastName = nannyDto.LastName;
            nanny.Phone = nannyDto.Phone;
            nanny.ExperienceYear = nannyDto.ExperienceYear;
            nanny.Description = nannyDto.Description;
            nanny.PricePerDaily = nannyDto.PricePerDaily;
            nanny.PricePerHour = nannyDto.PricePerHour;
            nanny.NannyImagePath = nannyDto.NannyImagePath;

            nanny.Categories.Clear();
            foreach (var categoryDto in nannyDto.Categories)
            {
                var category = await _context.Categories.FindAsync(categoryDto.Id);
                if (category != null)
                {
                    nanny.Categories.Add(category);
                }
            }

            _context.Entry(nanny).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NannyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        //---------------------------------------------------------------------------------------------------
        // GET: api/Nannies/WithReviews
        [HttpGet("WithReviews")]
        public async Task<ActionResult<IEnumerable<NannyWithReviewsDto>>> GetNanniesWithReviews()
        {
            var nannies = await _context.Nannies
                .Include(n => n.Reviews)
                .ThenInclude(r => r.User)
                .Select(n => new NannyWithReviewsDto
                {
                    NannyId = n.NannyId,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Phone = n.Phone,
                    ExperienceYear = n.ExperienceYear,
                    Description = n.Description,
                    PricePerDaily = n.PricePerDaily,
                    PricePerHour = n.PricePerHour,
                    NannyImagePath = n.NannyImagePath,
                    Reviews = n.Reviews.Select(r => new ReviewDto
                    {
                        ReviewId = r.ReviewId,
                        Rating = r.Rating,
                        Comment = r.Comment,
                       
                    }).ToList()
                })
                .ToListAsync();

            return nannies;
        }

        // GET: api/Nannies/WithReviews/5
        [HttpGet("WithReviews/{id}")]
        public async Task<ActionResult<NannyWithReviewsDto>> GetNannyWithReviews(int id)
        {
            var nanny = await _context.Nannies
                .Include(n => n.Reviews)
                .ThenInclude(r => r.User)
                .Select(n => new NannyWithReviewsDto
                {
                    NannyId = n.NannyId,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Phone = n.Phone,
                    ExperienceYear = n.ExperienceYear,
                    Description = n.Description,
                    PricePerDaily = n.PricePerDaily,
                    PricePerHour = n.PricePerHour,
                    NannyImagePath = n.NannyImagePath,
                    Reviews = n.Reviews.Select(r => new ReviewDto
                    {
                        ReviewId = r.ReviewId,
                        Rating = r.Rating,
                        Comment = r.Comment,
                        
                    }).ToList()
                })
                .FirstOrDefaultAsync(n => n.NannyId == id);

            if (nanny == null)
            {
                return NotFound();
            }

            return nanny;
        }


        private bool NannyExists(int id)
        {
            return _context.Nannies.Any(e => e.NannyId == id);
        }

    }
}
