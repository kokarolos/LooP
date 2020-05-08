using Loop.Database;
using Loop.Entities;
using Loop.Services.Repositories_interface;

namespace Loop.Services.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
