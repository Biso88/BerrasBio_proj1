using BerrasBio_proj1.DbModel;

namespace BerrasBio_proj1.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(BerrasBio_proj1Context context)
        {
            if (context.Movie.Any())
            {
                return;
            }

            context.Showing.AddRange(
               new Showing
               {
                   MovieId = 1,
                   SalonId = 1,
                   StartHour = DateTime.Parse("2022-05-30 15:00"),
                   RemainingSeats = 50,
               },

               new Showing
               {
                   MovieId = 2,
                   SalonId = 1,
                   StartHour = DateTime.Parse("2022-05-30 18:00"),
                   RemainingSeats = 50,
               },

               new Showing
               {
                   MovieId = 3,
                   SalonId = 1,
                   StartHour = DateTime.Parse("2022-05-30 21:00"),
                   RemainingSeats = 50,
               });

            context.Movie.AddRange(
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
               });

            context.Salon.AddRange(
                new Salon
                {
                    SalonSize = 50
                });

            context.Booking.AddRange(
                new Booking 
                { FirstName = "Bassam", 
                    LastName = "AL-Nashi", 
                    TicketQuantity = 2 },

                new Booking 
                { FirstName = "Claes", 
                    LastName = "Engelin", 
                    TicketQuantity = 5 });

               await context.SaveChangesAsync();
        }
        
    }
}
