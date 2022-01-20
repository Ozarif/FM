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
            objFromDb.ProvinceID = citizen.ProvinceID;
            objFromDb.DistrictID = citizen.DistrictID;
            objFromDb.RegisterPlaceID = citizen.RegisterPlaceID;
            objFromDb.RegisterNumber = citizen.RegisterNumber;
            objFromDb.PersonalReligionSectionID = citizen.PersonalReligionSectionID;
            objFromDb.RegisterReligionSectionID = citizen.RegisterReligionSectionID;
            objFromDb.Gender = citizen.Gender;    

            _db.SaveChanges();
        }
    }
}
