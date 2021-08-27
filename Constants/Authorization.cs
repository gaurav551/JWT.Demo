namespace JWT.DEMO.Constants
{
   public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }
        public const string default_username = "user";
        public const string default_email = "user@jwt.com";
        public const string default_password = "P@$$w0Rd";
        public const Roles default_role = Roles.User;
    }
}