using BerrasBio_proj1.DbModel;

namespace BerrasBio_proj1.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(BerrasBio_proj1Context _context)
        {

            if (_context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            _context.Movie.AddRange
            (
                new Movie
                {
                    MovieTitle = "Infinity War"
                },
                new Movie
                {
                    MovieTitle = "Spider man"
                },
                new Movie
                {
                    MovieTitle = "Thor"
                }
            );

            if (_context.Salon.Any())
            {
                return;   // DB has been seeded
            }
            _context.Salon.AddRange(
                new Salon
                {
                    SalonSize = 50
                });

            if (_context.Showing.Any())
            {
                return;   // DB has been seeded
            }
            _context.Showing.AddRange(
                new Showing
                { 
                    SalonId = 1,
                    RemainingSeats = 50,
                    StartHour = DateTime.Today.AddHours(16)

                },

                new Showing
                {
                    SalonId = 1,
                    RemainingSeats = 50,
                    StartHour = DateTime.Today.AddHours(18)

                },
                new Showing
                {
                    SalonId = 1,
                    RemainingSeats = 50,
                    StartHour = DateTime.Today.AddHours(21)

                }
                );
            _context.SaveChanges();

        }
    }
}
