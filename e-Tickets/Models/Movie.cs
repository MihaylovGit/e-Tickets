using e_Tickets.Data.Base;
using e_Tickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_Tickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}
