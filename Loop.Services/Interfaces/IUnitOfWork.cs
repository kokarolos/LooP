using Loop.Services.Interfaces.Repositories;
using Loop.Services.Repositories_interface;
using System;

namespace Loop.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository Posts { get; }
        IProductRepository Products { get; }
        IApplicationUserRepository Users { get; }
        IOrderRepository Orders { get; }
        IOrderProductRepository OrderProducts { get; }
        ITagRepository Tags { get; }

        void Save();
    }
}
