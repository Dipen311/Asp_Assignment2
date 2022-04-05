using DipensBooks.DataAccess.Repository.IRepository;
using DipensBooks.Models;
using DipensBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DipensBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null) // save changes if not null
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl; // add the check for ImageUrl
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId; // all properties of Product object
            }
        }
    }
}
