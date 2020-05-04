using Loop.Services.Interfaces.Repositories;
using Loop.Services.Repositories_interface;
using System;

namespace Loop.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository Posts { get; }
        IProductRepository Products { get; }

        void Save();
    }
}
