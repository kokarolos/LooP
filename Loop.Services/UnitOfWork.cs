using Loop.Database;
using Loop.Services.Interfaces.Repositories;
using Loop.Services.Repositories;
using Loop.Services.Repositories_interface;
using System;
using System.Threading.Tasks;

namespace Loop.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IPostRepository Posts { get; private set; }
        public IProductRepository Products { get; private set; }
        public IApplicationUserRepository Users { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IOrderProductRepository OrderProducts { get; private set; }
        public ITagRepository Tags { get; private set; }
        public IImageRepository Images { get; private set; }
        public IReplyRepository Replies { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Posts = new PostRepository(_context);
            Products = new ProductRepository(_context);
            Users = new ApplicationUserRepository(_context);
            Orders = new OrderRepository(_context);
            OrderProducts = new OrderProductRepository(_context);
            Tags = new TagRepository(_context);
            Images = new ImageRepository(_context);
            Replies = new ReplyRepository(_context);
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
