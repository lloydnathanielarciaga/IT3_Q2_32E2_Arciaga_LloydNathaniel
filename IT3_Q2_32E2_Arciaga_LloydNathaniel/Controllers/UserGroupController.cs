
using Microsoft.AspNetCore.Mvc;
using IT3_Q2_32E2_Arciaga_LloydNathaniel.DTO.UserGroup;

namespace IT3_Q2_32E2_Arciaga_LloydNathaniel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private static List<GetUsersGroupResponse> userGroups = new List<GetUsersGroupResponse>
        {
            new() { Id = 1, Name = "Admin Group", Email = "admin@example.com" },
            new() { Id = 2, Name = "Student Group", Email = "student@example.com" },
            new() { Id = 3, Name = "Teacher Group", Email = "teacher@example.com" },
            new() { Id = 4, Name = "IT Group", Email = "it@example.com" },
            new() { Id = 5, Name = "HR Group", Email = "hr@example.com" }
        };

        // GET api/<UserGroupController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(userGroups);
        }

        // GET api/<UserGroupController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var userGroup = userGroups.FirstOrDefault(u => u.Id == id);

            return Ok(new GetUserGroupByIdResponse
            {
                Id = userGroup.Id,
                Name = userGroup.Name,
                Email = userGroup.Email
            });
        }

        // POST api/<UserGroupController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserGroup value)
        {
            userGroups.Add(new GetUsersGroupResponse
            {
                Id = value.Id,
                Name = value.Name,
                Email = value.Email
            });

            return Ok(value);
        }

        // PUT api/<UserGroupController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditUserGroupResponse value)
        {
            var userGroup = userGroups.FirstOrDefault(u => u.Id == id);

            if (userGroup == null)
            {
                return NotFound();
            }

            userGroup.Name = value.Name;
            userGroup.Email = value.Email;

            return Ok(value);
        }

        // DELETE api/<UserGroupController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
