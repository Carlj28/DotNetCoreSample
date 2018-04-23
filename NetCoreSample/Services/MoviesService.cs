using System;
using System.Collections.Generic;
using NetCoreSample.Models;

namespace NetCoreSample.Services
{
    //Fake IMoviesService implementation
    public class MoviesService : IMoviesService
    {
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = Guid.NewGuid(),
                    DateOfRelease = DateTime.Today.AddDays(-1),
                    Description = "Movie 1 description",
                    Genre = "Movie 1 genre",
                    Title = "Movie 1 title"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    DateOfRelease = DateTime.Today.AddDays(-2),
                    Description = "Movie 2 description",
                    Genre = "Movie 2 genre",
                    Title = "Movie 2 title"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    DateOfRelease = DateTime.Today.AddDays(-3),
                    Description = "Movie 3 description",
                    Genre = "Movie 3 genre",
                    Title = "Movie 3 title"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    DateOfRelease = DateTime.Today.AddDays(-4),
                    Description = "Movie 4 description",
                    Genre = "Movie 4 genre",
                    Title = "Movie 4 title"
                }
            };
        }

        public IEnumerable<string> GetAllGenres()
        {
            return new List<string>
            {
                "Movie 1 genre",
                "Movie 2 genre",
                "Movie 3 genre",
                "Movie 4 genre"
            };
        }
    }
}
