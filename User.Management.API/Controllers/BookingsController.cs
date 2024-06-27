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
    public class BookingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingDto>>> GetBookings()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var bookings = await _context.Bookings
                .Where(b => b.UserId == userId)
                .Select(b => new BookingDto
                {
                    NannyId = b.NannyId,
                    Duration = b.Duration,
                    From = b.From,
                    To = b.To,
                    Notes = b.Notes,
                    ChildName = b.ChildName,
                    ChildGender = b.ChildGender,
                    MedicalHistoryAboutChild = b.MedicalHistoryAboutChild,
                    HomeSpace = b.HomeSpace,
                    NumOfLivingRoom = b.NumOfLivingRoom,
                    NumOfDinningRoom = b.NumOfDinningRoom,
                    NumOfBedRoom = b.NumOfBedRoom,
                    NumOfLaundryRoom = b.NumOfLaundryRoom,
                    NumOfKitchenRoom = b.NumOfKitchenRoom,
                    NumOfBathRoom = b.NumOfBathRoom,
                    BuildingName = b.BuildingName,
                    AptNo = b.AptNo,
                    Floor = b.Floor,
                    AdditionalDirection = b.AdditionalDirection,
                    PaymentMethod = b.PaymentMethod
                })
                .ToListAsync();

            return Ok(bookings);
        }

        // POST: api/Bookings
        [HttpPost]
        public async Task<ActionResult> CreateBooking(BookingDto bookingDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 

            var nanny = await _context.Nannies.FindAsync(bookingDto.NannyId);
            if (nanny == null)
            {
                return NotFound("Nanny not found.");
            }

            var booking = new Booking
            {
                NannyId = bookingDto.NannyId,
                Duration = bookingDto.Duration,
                From = bookingDto.From,
                To = bookingDto.To,
                Notes = bookingDto.Notes,
                ChildName = bookingDto.ChildName,
                ChildGender = bookingDto.ChildGender,
                MedicalHistoryAboutChild = bookingDto.MedicalHistoryAboutChild,
                HomeSpace = bookingDto.HomeSpace,
                NumOfLivingRoom = bookingDto.NumOfLivingRoom,
                NumOfDinningRoom = bookingDto.NumOfDinningRoom,
                NumOfBedRoom = bookingDto.NumOfBedRoom,
                NumOfLaundryRoom = bookingDto.NumOfLaundryRoom,
                NumOfKitchenRoom = bookingDto.NumOfKitchenRoom,
                NumOfBathRoom = bookingDto.NumOfBathRoom,
                BuildingName = bookingDto.BuildingName,
                AptNo = bookingDto.AptNo,
                Floor = bookingDto.Floor,
                AdditionalDirection = bookingDto.AdditionalDirection,
                PaymentMethod = bookingDto.PaymentMethod
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return Ok("Booking created successfully.");
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{bookingId}")]
        public async Task<ActionResult> DeleteBooking(int bookingId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == bookingId && b.UserId == userId);

            if (booking == null)
            {
                return NotFound("Booking not found.");
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();

            return Ok("Booking deleted successfully.");
        }
    }
}
