using Loop.Entities.Concrete;
using Loop.Services.Repositories_interface;

namespace Loop.Services.Interfaces.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        //User's Id is string so I created method that takes id as string
        ApplicationUser GetUserById(string id);
    }
}
