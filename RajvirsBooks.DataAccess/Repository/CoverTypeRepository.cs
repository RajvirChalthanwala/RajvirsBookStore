using RajvirsBooks.DataAccess.Repository.IRepository;
using RajvirsBooks.Models;
using RajvirsBookStore.DataAccess.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RajvirsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // throw new NotImplementedException();
            // Use .NET LNQ to retrieve the first or default coverType object
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)  // Save changes if not null
            {
                objFromDb.Name = coverType.Name;
                /* _db.SaveChanges();*/  // removed as per ppt
            }
        }
    }
}