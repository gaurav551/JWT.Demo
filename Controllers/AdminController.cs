using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.DEMO.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult GetUser()
        {
            //Get UserInfo From Payload In Token
            var userIdFromClaimsInJwt = User.FindFirst("uid")?.Value;
            return Ok($"Hi user {userIdFromClaimsInJwt}");
        }
        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public IActionResult Post()
        {
           return Ok("Hi Admin");
        }
      
    }
    
}