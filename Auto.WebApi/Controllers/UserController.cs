using Auto.Application;
using Auto.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Auto.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _service = new UserService();    

        [HttpPost("create")]
        public void Post([FromBody] User user)
        {
            _service.Add(user);
        }
    }
}