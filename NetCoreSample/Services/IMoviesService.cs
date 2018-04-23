using NetCoreSample.Models;
using System.Collections.Generic;

namespace NetCoreSample.Services
{
    //IMoviesService interface
    public interface IMoviesService
    {
        IEnumerable<Movie> GetMovies();
        IEnumerable<string> GetAllGenres();
    }
}
