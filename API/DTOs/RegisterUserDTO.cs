namespace API.DTOs
{
    public class RegisterUserDTO
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}