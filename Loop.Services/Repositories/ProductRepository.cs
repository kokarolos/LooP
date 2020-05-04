using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Services.Repositories
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
