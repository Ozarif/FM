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
    public class CityRepository : Repository<City>, ICityRepository
    {
        private readonly fmDBContext _db;
        public CityRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(City city)
        {
            var objFromDb = _db.Cities.FirstOrDefault(i => i.Id == city.Id);

            objFromDb.Name = city.Name;
            objFromDb.DistrictId = city.DistrictId;

            _db.SaveChanges();
        }
    }
}
