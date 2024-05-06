using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MovieDatabase.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Release Date")]
        public DateOnly ReleaseDate { get; set; }
        public int GenreId { get; set; }
        
        [ValidateNever]
        public Genre Genre { get; set; }

        [ValidateNever]
        public String ImgFileName { get; set; }
    }
}
