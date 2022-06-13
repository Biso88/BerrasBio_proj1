using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BerrasBio_proj1.DbModel
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [MaxLength(50)]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }

        [Display(Name = "Tickets")]
        [Range (1, 12)]
        public int TicketQuantity { get; set; }

        public Showing? Showing { get; set; }
        public int ShowingId { get; set; }

    }
}
