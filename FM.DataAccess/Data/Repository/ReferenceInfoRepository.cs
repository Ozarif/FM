using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ReferenceInfoRepository : Repository<ReferenceInfo>, IReferenceInfoRepository
    {
        private readonly fmDBContext _db;
        public ReferenceInfoRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ReferenceInfo referenceInfo)
        {
            var objFromDb = _db.ReferenceInfos.FirstOrDefault(i => i.Id == referenceInfo.Id);

            objFromDb.CitizenId = referenceInfo.CitizenId;
            objFromDb.Name = referenceInfo.Name;
            objFromDb.ContactNumber = referenceInfo.ContactNumber;
            objFromDb.PartyPositionId = referenceInfo.PartyPositionId;

            _db.SaveChanges();
        }
    }
}
