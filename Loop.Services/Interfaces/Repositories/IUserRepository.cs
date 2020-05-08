using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using Loop.Services.Repositories_interface;

namespace Loop.Services.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
    }
}
