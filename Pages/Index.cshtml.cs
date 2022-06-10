using BerrasBio_proj1.Data;
using BerrasBio_proj1.DbModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BerrasBio_proj1.Pages;

public class IndexModel : PageModel
{
    private readonly BerrasBio_proj1Context _context;

    public IEnumerable<Showing> Showing { get; set; }

    private IList<Showing> showings;

    [BindProperty]
    public Movie Movies { get; set; }
    [BindProperty]
    public Booking Bookings { get; set; }

    public IndexModel(BerrasBio_proj1Context context)
    {
        _context = context;
    }

    public async Task OnGetAsync()
    {
        showings = await _context.Showing
          .Include(m => m.Movie)
          .Include(b => b.Bookings)
          .ToListAsync();

        Showing = showings;
    }
    
}