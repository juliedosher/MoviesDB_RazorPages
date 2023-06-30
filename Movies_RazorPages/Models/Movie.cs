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
        [Required]
        [StringLength(3, MinimumLength = 1)]
        public int RuntimeMin { get; set; }


        [StringLength(4, MinimumLength = 4)]
        [Display(Name = "Release Year")]
        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}
