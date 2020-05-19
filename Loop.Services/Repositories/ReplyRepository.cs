using Loop.Database;
using Loop.Entities;
using Loop.Services.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Loop.Services.Repositories
{
    public class ReplyRepository : GenericRepository<Reply>, IReplyRepository
    {
        public ApplicationDbContext Database
        {
            get { return Context as ApplicationDbContext; }
        }
        public ReplyRepository(DbContext context) : base(context)
        {

        }

        //Including User Image Table so we can display user who posted
        public override IEnumerable<Reply> GetAll()
        {
            return Database.Replies.Include(reply => reply.ApplicationUser.Images)
                                   .Include(reply=>reply.Post)
                                   .AsEnumerable();
        }
    
    }
}
