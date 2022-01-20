using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
   public  class RegisterPlaceRepository : Repository<RegisterPlace>, IRegisterPlaceRepository    {
        private readonly fmDBContext _db;
        public RegisterPlaceRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RegisterPlace registerPlace)
        {
            var objFromDb = _db.RegisterPlaces.FirstOrDefault(i => i.Id == registerPlace.Id);

            objFromDb.Name = registerPlace.Name;
            objFromDb.DistrictId = registerPlace.DistrictId;

            _db.SaveChanges();
        }
    }
}
