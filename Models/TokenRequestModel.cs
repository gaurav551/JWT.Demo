using System.ComponentModel.DataAnnotations;

namespace JWT.DEMO.Models
{
    //Like Login Model
    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}