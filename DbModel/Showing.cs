using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BerrasBio_proj1.DbModel
{
    public partial class Showing
    {
        [Key]
        public int ShowingId { get; set; }

        [Display(Name = "Remaining seats")]
        public int RemainingSeats { get; set; }

        [Display(Name = "Starting From")]
        public DateTime StartHour { get; set; }


        public Movie? Movie { get; set; }
        public int MovieId { get; set; }


        public Salon? Salon { get; set; }
        public int SalonId { get; set; }

        public virtual ICollection<Booking>? Bookings { get; set; }

    }
}
