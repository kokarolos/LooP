using System.Linq;
using System.Data.Entity;
using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;
using System.Collections.Generic;


namespace Loop.Services.Repositories
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationDbContext Database
        {
            get { return Context as ApplicationDbContext; }
        }

        public ApplicationUserRepository(ApplicationDbContext context)
           : base(context)
        {
            
        }
        public ApplicationUser GetUserById(string id)
        {
            return Database.ApplicationUsers.Find(id);
        }
        public override IEnumerable<ApplicationUser> GetAll()
        {
            return Database.ApplicationUsers.Include(x => x.Images).AsEnumerable();
        }
    }
}
