using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace JWT.DEMO.Models
{
  public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}