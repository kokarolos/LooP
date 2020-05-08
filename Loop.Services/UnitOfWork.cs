using Loop.Database;
using Loop.Services.Interfaces.Repositories;
using Loop.Services.Repositories;
using Loop.Services.Repositories_interface;

namespace Loop.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IPostRepository Posts { get; private set; }
        public IProductRepository Products { get; private set; }
        public IApplicationUserRepository Users { get; private set; }
        public IUserProductRepository UserProduct { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Posts = new PostRepository(_context);
            Products = new ProductRepository(_context);
            Users = new ApplicationUserRepository(_context);
            UserProduct = new UserProductRepository(_context);
        }

        public void Save()
        {
             _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
