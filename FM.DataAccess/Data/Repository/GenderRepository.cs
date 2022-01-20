using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        private readonly fmDBContext _db;
        public GenderRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Gender gender)
        {
            var objFromDb = _db.Genders.FirstOrDefault(i => i.Id == gender.Id);

            objFromDb.Name = gender.Name;

            _db.SaveChanges();
        }
    }
}
