using System.ComponentModel.DataAnnotations;

namespace BerrasBio_proj1.DbModel
{
    public partial class Salon
    {
        [Key]
        public int SalonId { get; set; }

        public int SalonSize { get; set; }

        public virtual ICollection<Showing> Showings { get; set; } = new List<Showing>();


    }
}
