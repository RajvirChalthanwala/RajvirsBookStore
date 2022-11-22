using RajvirsBooks.DataAccess.Repository.IRepository;
using RajvirsBooks.Models;
using RajvirsBookStore.DataAccess.Data;
using System.Linq;
using System;
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

        public void Update(CoverType covertype)
        {
            // use .NET LINQ to retrieve the first or default covertype object,
            // then pass the id as a generic entity which matches the covertype ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = covertype.Name;
                _db.SaveChanges();
            }
        }
    }
}
