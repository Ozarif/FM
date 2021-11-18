using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class CitizenRepository : Repository<Citizen>, ICitizenRepository
    {
        private readonly fmDBContext _db;
        public CitizenRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Citizen citizen)
        {
            var objFromDb = _db.Citizens.FirstOrDefault(i => i.Id == citizen.Id);

            objFromDb.FirstName = citizen.FirstName;
            objFromDb.FatherName = citizen.FatherName;
            objFromDb.LastName = citizen.LastName;
            objFromDb.MotherFullName = citizen.MotherFullName;
            objFromDb.DateOfBirth = citizen.DateOfBirth;
            objFromDb.Province = citizen.Province;
            objFromDb.District = citizen.District;
            objFromDb.RegisterPlace = citizen.RegisterPlace;
            objFromDb.RegisterNumber = citizen.RegisterNumber;
            objFromDb.Religion = citizen.Religion;
            objFromDb.ReligionSect = citizen.ReligionSect;    

            _db.SaveChanges();
        }
    }
}
