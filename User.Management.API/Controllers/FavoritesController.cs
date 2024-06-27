using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using User.Management.Data.Dtos;
using User.Management.Data.Models;

namespace User.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FavoritesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoritesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Favorites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nanny>>> GetFavorites()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Extract user ID from JWT token

            var favorites = await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Nanny)
                .Select(f => f.Nanny)
                .ToListAsync();

            return Ok(favorites);
        }

        // POST: api/Favorites
        [HttpPost]
        public async Task<ActionResult> AddToFavorites(FavoriteDto favoriteDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Extract user ID from JWT token

            // Check if the nanny exists
            var nanny = await _context.Nannies.FindAsync(favoriteDto.NannyId);
            if (nanny == null)
            {
                return NotFound("Nanny not found.");
            }

            // Check if the nanny is already in the user's favorites
            var existingFavorite = await _context.Favorites
                .FirstOrDefaultAsync(f => f.NannyId == favoriteDto.NannyId && f.UserId == userId);

            if (existingFavorite != null)
            {
                return BadRequest("Nanny is already in your favorites.");
            }

            var favorite = new Favorite
            {
                NannyId = favoriteDto.NannyId,
                UserId = userId
            };

            _context.Favorites.Add(favorite);
            await _context.SaveChangesAsync();

            return Ok("Nanny added to favorites.");
        }

        // DELETE: api/Favorites/5
        [HttpDelete("{nannyId}")]
        public async Task<ActionResult> RemoveFromFavorites(int nannyId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Extract user ID from JWT token

            var favorite = await _context.Favorites
                .FirstOrDefaultAsync(f => f.NannyId == nannyId && f.UserId == userId);

            if (favorite == null)
            {
                return NotFound("Favorite not found.");
            }

            _context.Favorites.Remove(favorite);
            await _context.SaveChangesAsync();

            return Ok("Nanny removed from favorites.");
        }
    }
}
