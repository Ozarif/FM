using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ServiceInfoRepository : Repository<ServiceInfo>, IServiceInfoRepository
    {
        private readonly fmDBContext _db;
        public ServiceInfoRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ServiceInfo serviceInfo)
        {
            var objFromDb = _db.ServiceInfo.FirstOrDefault(i => i.Id == serviceInfo.Id);

            objFromDb.CitizenId = serviceInfo.CitizenId;
            objFromDb.ServiceTypeId = serviceInfo.ServiceTypeId;
            objFromDb.ContactName = serviceInfo.ContactName;
            objFromDb.ContactNumber = serviceInfo.ContactNumber;
            objFromDb.ResultTypeId = serviceInfo.ResultTypeId;

            _db.SaveChanges();
        }
    }
}
