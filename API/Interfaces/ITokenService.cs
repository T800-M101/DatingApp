

using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        // An interface does not contain any implementation logic. Only contains the 
        // signatures of the functionality of the methods
        string  CreateToken(AppUser user);
    }
}