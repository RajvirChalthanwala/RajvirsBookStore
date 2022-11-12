using RajvirsBooks.DataAccess.Repository.IRepository;
using RajvirsBooks.Models;
using RajvirsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RajvirsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
