using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieDatabase.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int GenreId { get; set; }
        
        [ValidateNever]
        public Genre Genre { get; set; }
    }
}
