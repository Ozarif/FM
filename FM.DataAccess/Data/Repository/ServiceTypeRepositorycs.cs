using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ServiceTypeRepositorycs : Repository<ServiceType>, IServiceTypeRepository
    {
        private readonly fmDBContext _db;
        public ServiceTypeRepositorycs(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ServiceType serviceType)
        {
            var objFromDb = _db.ServiceTypes.FirstOrDefault(i => i.Id == serviceType.Id);

            objFromDb.Discription = serviceType.Discription;

            _db.SaveChanges();
        }
    }
}
