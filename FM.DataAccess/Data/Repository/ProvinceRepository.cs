using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        private readonly fmDBContext _db;

        public ProvinceRepository(fmDBContext db) : base (db)
        {
            _db = db;
        }
        public void Update(Province province)
        {
            var objFromDb = _db.Provinces.FirstOrDefault(i => i.Id == province.Id);

            objFromDb.Name = province.Name;

            _db.SaveChanges();
        }
    }
}
