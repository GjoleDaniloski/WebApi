using HomeworkClass02.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeworkClass02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            //return StaticDB.Users;
            return StatusCode(StatusCodes.Status200OK, StaticDB.ListOfUsers);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            User user = StaticDB.ListOfUsers.SingleOrDefault(x => x.Id == id);
            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, $"There is no user with id{id}");
            return StatusCode(StatusCodes.Status200OK, user);
        }
        
        [HttpGet("route")]
        public ActionResult<string> GetPath()
        {
            var request = Request;
            return StatusCode(StatusCodes.Status200OK, request.Path.ToString());
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
