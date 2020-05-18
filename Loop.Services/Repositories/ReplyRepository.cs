using Loop.Entities;
using Loop.Services.Interfaces.Repositories;
using System.Data.Entity;


namespace Loop.Services.Repositories
{
    public class ReplyRepository : GenericRepository<Reply>, IReplyRepository
    {
        public ReplyRepository(DbContext context) : base(context)
        {

        }
    }
}
