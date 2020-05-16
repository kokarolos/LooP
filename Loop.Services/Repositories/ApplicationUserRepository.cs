using System.Linq;
using System.Data.Entity;
using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using Loop.Entities;

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
     
        public void UpdateUserWithImage(ApplicationUser entity,Image image)
        {
            Database.ApplicationUsers.Attach(entity);
            Database.Entry(entity).Collection("Images").Load();
            entity.Images.Clear();
            entity.Images = new List<Image>() { image };

        }
    }
}
