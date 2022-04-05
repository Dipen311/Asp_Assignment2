using DipensBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipensBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
