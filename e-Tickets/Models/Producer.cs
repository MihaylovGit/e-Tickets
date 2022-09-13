using e_Tickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Producer : IEntityBase
    {
        public Producer()
        {
            this.Movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Producer profile picture is required")]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Producer full name is required")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Description should be between 10 and 50 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Producer biography is required")]
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
