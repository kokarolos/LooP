using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public ApplicationDbContext DatabaseContext
        {
            get { return Context as ApplicationDbContext; }
        }
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {

        }

    }
}
