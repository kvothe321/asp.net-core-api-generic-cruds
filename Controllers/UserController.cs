using Microsoft.AspNetCore.Mvc;
using MyHealth.Models;
using MyHealth.Services;

namespace MyHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User, UserService>
    {
        public UserController(UserService service) : base(service)
        {
        }
    }
}
