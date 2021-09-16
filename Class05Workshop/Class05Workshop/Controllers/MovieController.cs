using Class05Workshop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Class05Workshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, StaticDB.ListOfMovies);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            try
            {
                var movie = StaticDB.ListOfMovies.SingleOrDefault(x => x.Id == id);
                if (movie == null) throw new Exception($"There is no movie with that id {id}");
                return Ok(movie);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        // GET api/<MovieController>/5
        [HttpGet("movieByGenre")]
        public ActionResult<Movie> Get(string genre)
        {
            
            try
            {
                if (string.IsNullOrEmpty(genre))
                {
                    return StatusCode(StatusCodes.Status404NotFound, "Put a genre");
                }
            
                Movie movieByGenre = StaticDB.ListOfMovies.FirstOrDefault(x => x.Genre.Contains(genre));
                return StatusCode(StatusCodes.Status200OK, movieByGenre.Title.ToString());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        
        [HttpPost("addMovie")]
        public IActionResult Post([FromBody] Movie movie)
        {
            try
            {
                var existingMovie = StaticDB.ListOfMovies.SingleOrDefault(x => x.Id == movie.Id);
                if (existingMovie == null)
                {
                    StaticDB.ListOfMovies.Add(movie);
                    return StatusCode(StatusCodes.Status200OK, "Movie successfully added");
                }
                throw new Exception($"Movie with id {movie.Id} alredy exists.");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error!");
            }
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            try
            {
                StaticDB.ListOfMovies.RemoveAt(index);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
    }
}
