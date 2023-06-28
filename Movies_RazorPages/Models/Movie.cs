﻿using System.ComponentModel.DataAnnotations;

namespace Movies_RazorPages.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        [Display(Name = "Runtime (minutes)")]
        public int RuntimeMin { get; set; }

        public string Synopsis { get; set; }

        public string Language { get; set; }

        public string Genre { get; set; }
    }
}