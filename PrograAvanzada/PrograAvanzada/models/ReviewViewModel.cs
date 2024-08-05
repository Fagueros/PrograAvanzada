using System.ComponentModel.DataAnnotations;

namespace PrograAvanzada.Models
{
    public class ReviewViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter your comment.")]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Please rate us.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }
    }
}