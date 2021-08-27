using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JWT.DEMO.Models
{
    //Used to return Token and userInformation upon successfull login
    public class AuthenticationModel
    {
       
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        //For Refresh
        //Prevents from showing
        [JsonIgnore]
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}