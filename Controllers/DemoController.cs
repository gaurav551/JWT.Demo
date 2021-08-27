using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.DEMO.Controllers
{
    //TO demonstrate Cookie
    [ApiController]
    [Route("[controller]")]
   
    public class DemoController : Controller
    {
        [HttpPost]
        public IActionResult SetCookies()
        {
            var cookieOptions = new CookieOptions(){
                Expires = DateTime.Now.AddDays(1)
            };
           string cookieval = "my name is DON";
           Response.Cookies.Append("SomeRandomCookies", cookieval, cookieOptions);
           return Ok("COokies Added");
        }
        [HttpDelete]
        public IActionResult DeleteCookies()
        {
            Response.Cookies.Delete("SomeRandomCookies");
           
            return Ok("COokies Removed");
        }
        [HttpGet]
        public IActionResult GetCookies()
        {
           var cookiesVal = Request.Cookies["SomeRandomCookies"];
           if(cookiesVal==null)
           {
               return Ok("No COokies FOund");
           }
           
            return Ok(cookiesVal);
        }
        [HttpPut]
        public IActionResult EditCookies(string text)
        {
            var cookieOptions = new CookieOptions(){
                Expires = DateTime.Now.AddDays(1)
            };
           string cookieval = text;
           Response.Cookies.Append("SomeRandomCookies", cookieval, cookieOptions);
           return Ok("COokies Updated");
        }
    }
}