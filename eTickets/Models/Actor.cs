using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50,MinimumLength =2, ErrorMessage ="Full Name must between 2 and 50 chars")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }

        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
