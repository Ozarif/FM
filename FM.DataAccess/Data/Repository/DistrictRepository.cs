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
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        private readonly fmDBContext _db;
        public DistrictRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(District district)
        {
            var objFromDb = _db.Districts.FirstOrDefault(i => i.Id == district.Id);

            objFromDb.Name = district.Name;
            objFromDb.ProvinceId = district.ProvinceId;

            _db.SaveChanges();
        }
    }
}
