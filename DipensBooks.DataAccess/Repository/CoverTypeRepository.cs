using DipensBooks.DataAccess.Repository.IRepository;
using DipensBooks.Models;
using DipensBookStore.DataAccess.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipensBooks.DataAccess.Repository
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
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;

            }
        }
    }
}
