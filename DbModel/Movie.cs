using System.ComponentModel.DataAnnotations;

namespace BerrasBio_proj1.DbModel
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [MaxLength(100)]
        [Display(Name = "Movie title")]
        public string MovieTitle { get; set; }

        public virtual ICollection<Showing> Showings { get; set; }

    }
}
