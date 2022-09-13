using e_Tickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Cinema : IEntityBase
    {
        public Cinema()
        {
            this.Movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Cinema name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name should be betweeen 3 and 30 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cinema description is required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Description should be between 10 and 100 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
