using API.Models;

namespace API.Helpers
{
    public interface ITokenHelper
    {
        string CreateToken(User user);
        string GetIdByToken(string token);
    }
}