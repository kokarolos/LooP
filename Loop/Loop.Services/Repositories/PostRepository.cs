using Loop.Database;
using Loop.Entities;
using Loop.Services.Repositories_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
