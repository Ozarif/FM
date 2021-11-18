using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class EducationalLevelRepository : Repository<EducationalLevel>, IEducationalLevelRepository
    {
        private readonly fmDBContext _db;
        public EducationalLevelRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(EducationalLevel educationalLevel)
        {
            var objFromDb = _db.EducationalLevels.FirstOrDefault(i => i.Id == educationalLevel.Id);

            objFromDb.Discription = educationalLevel.Discription;

            _db.SaveChanges();
        }
    }
}
