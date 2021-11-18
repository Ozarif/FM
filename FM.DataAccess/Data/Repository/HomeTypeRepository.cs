using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class HomeTypeRepository : Repository<HomeType>, IHomeTypeRepository
    {
        private readonly fmDBContext _db;
        public HomeTypeRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(HomeType homeType)
        {
            var objFromDb = _db.HomeTypes.FirstOrDefault(i => i.Id == homeType.Id);

            objFromDb.Discription = homeType.Discription;

            _db.SaveChanges();
        }
    }
}
