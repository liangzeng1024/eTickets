using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required(ErrorMessage ="Cinema Logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        public string Name { get; set; }

        public string Description { get; set; }
        //relationships
        public List<Movie>? Movies { get; set; }

    }
}
