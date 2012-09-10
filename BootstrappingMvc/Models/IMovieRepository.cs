using System;
namespace BootstrappingMvc.Models
{
    interface IMovieRepository
    {
        System.Linq.IQueryable<Movie> GetMovies();
    }
}
