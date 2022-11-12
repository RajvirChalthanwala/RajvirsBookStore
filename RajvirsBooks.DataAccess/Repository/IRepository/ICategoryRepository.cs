using RajvirsBooks.DataAccess.Repository.IRepository;
using RajvirsBooks.Models;
using System;
using RajvirsBookStore.DataAccess.Data;
using System.Collections.Generic;
using System.Text;

namespace RajvirsBooks.DataAccess.Repository.IRepository
{
     public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
