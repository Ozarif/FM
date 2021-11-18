using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class MaritalStatusRepository : Repository<MaritalStatus>, IMaritalStatusRepository
    {
        private readonly fmDBContext _db;
        public MaritalStatusRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MaritalStatus maritalStatus)
        {
            var objFromDb = _db.MaritalStatuses.FirstOrDefault(i => i.Id == maritalStatus.Id);

            objFromDb.Discription = maritalStatus.Discription;

            _db.SaveChanges();
        }
    }
}
