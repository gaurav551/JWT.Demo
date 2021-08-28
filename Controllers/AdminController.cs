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
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecuredData()
        {
            //Get UserInfo From Payload In Token
            return Ok("This Secured Data is available only for Authenticated Users.");
        }
        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public IActionResult PostSecuredData()
        {

            return Ok("This Secured Data is available only for Admin Users.");
        }
      
    }
    
}