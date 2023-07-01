using System.ComponentModel.DataAnnotations;

namespace Movies_RazorPages.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Synopsis { get; set; }

        [Display(Name = "Runtime (minutes)")]
        [Range(1, 999, ErrorMessage = "Please enter an integer between 1-999")]
        [Required]
        public int RuntimeMin { get; set; }


        [Display(Name = "Release Year")]
        [Range(1000, 9999, ErrorMessage = "Please enter in the format YYYY")]
        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}
