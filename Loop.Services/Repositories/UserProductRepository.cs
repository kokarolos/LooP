using Loop.Database;
using Loop.Entities.Intermediate;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class UserProductRepository : GenericRepository<UserProduct>, IUserProductRepository
    {
        public UserProductRepository(ApplicationDbContext context) 
            : base(context)
        {

        }
    }
}
