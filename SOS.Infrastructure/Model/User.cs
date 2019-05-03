namespace SOS.Infrastructure.Model
{
    public class User : Person
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public Role Role { get; set; }
    }
}