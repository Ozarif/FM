using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class BusinessSectorRepository : Repository<BusinessSector>, IBusinessSectorRepository
    {
        private readonly fmDBContext _db;
        public BusinessSectorRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BusinessSector businessSector)
        {
            var objFromDb = _db.BusinessSectors.FirstOrDefault(i => i.Id == businessSector.Id);

            objFromDb.Discription = businessSector.Discription;
    
            _db.SaveChanges();
        }
    }
}
