using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)] // culture specific
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
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
 */
