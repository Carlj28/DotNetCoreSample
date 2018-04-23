using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Models;
using System;
using System.Linq;
using NetCoreSample.DTO;
using NetCoreSample.Services;

namespace NetCoreSample.Controllers
{
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        public IMoviesService MoviesService { get; set; }

        //Inject IMoviesService
        public MoviesController(IMoviesService moviesService)
        {
            MoviesService = moviesService;
        }

        //Set this as default method
        [Route("")]
        public IActionResult GetDefaultMovie()
        {
            var model = new Movie
            {
                DateOfRelease = DateTime.Now,
                Description = "Test description",
                Genre = "Comedy",
                Id = Guid.NewGuid(),
                Title = "Test title"
            };

            return new ObjectResult(model);
        }

        //Use route path as action method name
        [Route("[action]")]
        public IActionResult GetRate()
        {
            return Content("2/10");
        }

        //Get view for model
        [Route("Favorite")]
        public IActionResult GetMyFavoriteMovie()
        {
            var model = new Movie
            {
                DateOfRelease = DateTime.Now,
                Description = "A detective specializing in finding missing animals looks for a stolen dolphin.",
                Genre = "Comedy",
                Id = Guid.NewGuid(),
                Title = "Ace Ventura"
            };

            return View(model);
        }

        //Get view for model enumerable as table
        [Route("Table")]
        public IActionResult GetTable()
        {
            var model = MoviesService.GetMovies();

            return View(model);
        }

        //Get view for dto model
        [Route("dto")]
        public IActionResult GetDto()
        {
            var movies = MoviesService.GetMovies();
            var allGenres = MoviesService.GetAllGenres();

            return View(movies.Select(x => new MoviesDTO
            {
                DateOfRelease = x.DateOfRelease,
                Genre = x.Genre,
                Description = x.Description,
                Title = x.Title,
                Id = x.Id,
                Genres = allGenres
            }));
        }
    }
}
