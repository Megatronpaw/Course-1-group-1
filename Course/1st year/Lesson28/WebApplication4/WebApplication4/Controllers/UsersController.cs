using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static Dictionary<int, string> user = new Dictionary<int, string> { { 1, "Alice" }, { 2, "Bob" }, { 3, "Charli" } };
        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(user);

        }

        [HttpPost]
        public IActionResult AddUser([FromBody] string user_)
        {
            user.Add(user.Count + 1, user_);
            return Ok($"Пользователь {user_} добавлен");
        }
        [HttpPut]
        public IActionResult PutUser([FromBody] int id)
        {

            return Ok($"Данные рользователя {user[id]} обнавлены");
        }
        [HttpDelete]
        public IActionResult DeleteUser([FromBody] int id)
        {
            
            return Ok($"Пользователь {user[id]} {user.Remove(id)} удален");
        }

    }
}
