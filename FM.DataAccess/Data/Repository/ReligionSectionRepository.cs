using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ReligionSectionRepository : Repository<ReligionSection>, IReligionSectionRepository
    {
        private readonly fmDBContext _db;
        public ReligionSectionRepository(fmDBContext db) : base(db) { 
        
            _db = db;
        }

        public void Update(ReligionSection religionSection)
        {
            var objFromDb = _db.ReligionSections.FirstOrDefault(i => i.Id == religionSection.Id);

            objFromDb.Name = religionSection.Name;

            _db.SaveChanges();
        }
    }
}
