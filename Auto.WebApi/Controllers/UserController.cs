using Auto.Application;
using Auto.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Auto.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IOptions<ApplicationSettings> _settings;
        private UserService _service;

        public UserController(IOptions<ApplicationSettings> settings)
        {
            _settings = settings;
            _service = new UserService(_settings.Value.TestSetting);
        }

        [HttpPost("create")]
        public void Post([FromBody] User user)
        {
            _service.Add(user);
        }
    }
}