using RajvirsBooks.DataAccess.Repository.IRepository;
using RajvirsBooks.Models;
using RajvirsBookStore.DataAccess.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RajvirsBooks.DataAccess.Repository
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
            // throw new NotImplementedException();
            // Use .NET LNQ to retrieve the first or default coverType object
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)  // Save changes if not null
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}