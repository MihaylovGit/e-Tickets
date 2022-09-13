using e_Tickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Actor : IEntityBase
    {
        public Actor()
        {
            this.Actors_Movies = new List<Actor_Movie> { };
        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name should be between 3 and 50 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Biography { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
