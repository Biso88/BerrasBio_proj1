using BerrasBio_proj1.Data;
using BerrasBio_proj1.DbModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BerrasBio_proj1.Pages
{
    public class AddBookingModel : PageModel
    {
        private readonly BerrasBio_proj1Context _context;

        public AddBookingModel(BerrasBio_proj1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; }
        [BindProperty]
        public Showing Showing { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (_context.Showing != null)
            {
                Showing = await _context.Showing
                    .Include(x => x.Movie)
                    .Include(x => x.Salon)
                    .Include(x => x.Bookings)
                    .FirstOrDefaultAsync(x => x.ShowingId == id);
            }
            else if (Showing == null)
            {
                return NotFound();

            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("AddBooking", id);
            }

            else if (Booking.TicketQuantity > 12)
            {
                return RedirectToPage("AddBooking", id);
            }

            Showing showing = await _context.Showing.FindAsync(id);
            showing.RemainingSeats -= Booking.TicketQuantity;

            Booking booking = new()
            {
                ShowingId = Showing.ShowingId,
                Showing = showing,
                FirstName = Booking.FirstName,
                LastName = Booking.LastName,
                TicketQuantity = Booking.TicketQuantity
            };

            _context.Booking.Add(booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("Confirmation", id == booking.BookingId);
        }
    }
}

