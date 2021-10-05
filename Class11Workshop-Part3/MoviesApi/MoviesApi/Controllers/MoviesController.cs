using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Models.ViewModels;
using MoviesApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<MovieModel>> Get()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _movieService.GetAllMovies());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<MovieModel> GetById(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _movieService.GetMovieById(id));
            }

            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] MovieModel noteModel)
        {
            try
            {
                _movieService.AddMovie(noteModel);
                return StatusCode(StatusCodes.Status201Created, "Movie Created");
            }


            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong!");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _movieService.DeleteMovie(id);
                return StatusCode(StatusCodes.Status204NoContent, "Movie Deleted");
            }

            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong!");
            }

        }
    }
}
