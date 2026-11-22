using IT3_Q2_32E2_Arciaga_LloydNathaniel.DTO.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT3_Q2_32E2_Arciaga_LloydNathaniel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = new GetUsersResponse
            {
                Users = new()
                {
                    new(){ Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                    new(){ Id = 2, Name = "John Otto", Email = "john.otto@example.com" },
                    new(){ Id = 3, Name = "Marc Antonio", Email = "marc.antonio@example.com" },
                    new(){ Id = 4, Name = "Renen Isip", Email = "renen.isip@example.com" },
                    new(){ Id = 5, Name = "Angelo Salomon", Email = "angelo.salomon@example.com" },
                    new(){ Id = 6, Name = "Anna Rose", Email = "anna.rose@example.com" },
                    new(){ Id = 7, Name = "Evan Arezala", Email = "evan.arezala@example.com" },
                    new(){ Id = 8, Name = "Neil Tumala", Email = "neil.tumala@example.com" },
                    new(){ Id = 9, Name = "Kier Harvey", Email = "kier.harvey@example.com" },
                    new(){ Id = 10, Name = "Denmark Ambrocio", Email = "denmark.ambrocio@example.com" }
                }
            };
            return Ok(response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var users = new List<GetUserByIdResponse>
            {
                new() {Id = 1, Something = "something"}
            };
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserResponse user)
        {
            return Ok(new
            {
                Message = "Put",
                Data = user
            });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditUserResponse user)
        {
            return Ok(new
            {
                Message = "Update",
                Data = user
            });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}