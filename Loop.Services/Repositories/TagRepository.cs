using Loop.Database;
using Loop.Entities;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
