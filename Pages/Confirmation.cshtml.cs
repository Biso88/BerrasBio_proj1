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
        public Booking Booking { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var _booking1 = await _context.Booking
                         .Include(s => s.Showing)
                         .FirstAsync(m => m.BookingId == id);

            if (_booking1 == null)
            {
                return NotFound();
            }
            else
            {
                Booking = _booking1;
            }

            return Page();
        }
    }
}
