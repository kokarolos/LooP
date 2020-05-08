using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {

        public ApplicationUserRepository(ApplicationDbContext context)
           : base(context)
        {

        }
    }
}
