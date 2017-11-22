using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required, StringLength(60, MinimumLength = 3)] // max lenght 60, min lenght is 3
        public string Title { get; set; }

        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)] // display as eg 02-May-2017
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required, StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required ,StringLength(5)] // Max Length is 5
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie>Movies { get; set; }
    }
}

/*
 * The MovieDBContext class represents the Entity Framework movie database context, which handles fetching,
 * storing, and updating Movie class instances in a database. 
 * The MovieDBContext derives from the DbContext base class provided by the Entity Framework.
 * [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)] // culture specific
 */
