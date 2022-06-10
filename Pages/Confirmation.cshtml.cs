using BerrasBio_proj1.Data;
using BerrasBio_proj1.DbModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BerrasBio_proj1.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly BerrasBio_proj1Context _context;

        public ConfirmationModel(BerrasBio_proj1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; } = new Booking();


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (_context.Booking != null)
            {
                var _booking = await _context.Booking.FirstOrDefaultAsync(m => m.BookingId == id);
                if (_booking != null)
                {
                    Booking = _booking;
                    _booking = await _context.Booking
                        .Include(s => s.Showing)
                        .FirstAsync(x => x.ShowingId == _booking.ShowingId);
                }

            }
            else
            {
                return NotFound("");
            }

            return Page();
        }
    }
}
