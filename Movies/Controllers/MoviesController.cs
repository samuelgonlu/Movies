
using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private readonly MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet, Route("/movies")]
        public List<Movie> GetMovies()
        {
            return _moviesService.GetUserMovies();
        }

        [HttpPost, Route("/movies")]
        public Movie PostMovie([FromBody] DTO.Movie movie)
        {
            return _moviesService.AddUserMovie(movie);
        }
    }
}
