using Loop.Database;
using Loop.Entities;
using Loop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Services
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private GenericRepository<Post> _postRepository;
        private GenericRepository<Product> _productRepository;

        public GenericRepository<Post> PostRepository
        {
            get
            {
                if (_postRepository == null)
                {
                    _postRepository = new GenericRepository<Post>(context);
                }
                return _postRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (_productRepository == null)
                {
                    _productRepository = new GenericRepository<Product>(context);
                }
                return _productRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}