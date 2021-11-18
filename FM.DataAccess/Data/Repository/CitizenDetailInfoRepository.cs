using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class CitizenDetailInfoRepository : Repository<CitizenDetailInfo>, ICitizenDetailInfoRepository
    {
        private readonly fmDBContext _db;
        public CitizenDetailInfoRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CitizenDetailInfo citizenDetailInfo)
        {
            var objFromDb = _db.CitizenDetailInfos.FirstOrDefault(i => i.CitizenId == citizenDetailInfo.CitizenId);

            //objFromDb.ProvinceId = citizenDetailInfo.ProvinceId;
            //objFromDb.DistrictId = citizenDetailInfo.DistrictId;
            objFromDb.Sex = citizenDetailInfo.Sex;
            objFromDb.CityId = citizenDetailInfo.CityId;
            objFromDb.Street = citizenDetailInfo.Street;
            objFromDb.Building = citizenDetailInfo.Building;
            objFromDb.Floor = citizenDetailInfo.Floor;
            objFromDb.HomeTypeId = citizenDetailInfo.HomeTypeId;
            objFromDb.Phone = citizenDetailInfo.Phone;
            objFromDb.Mobile = citizenDetailInfo.Mobile;
            objFromDb.Email = citizenDetailInfo.Email;
            objFromDb.MaritalStatusId = citizenDetailInfo.MaritalStatusId;
            objFromDb.Nationality = citizenDetailInfo.Nationality;
            objFromDb.IsDisabled = citizenDetailInfo.IsDisabled;
            objFromDb.EducationalLevelId = citizenDetailInfo.EducationalLevelId;
            objFromDb.BusinessSectorId = citizenDetailInfo.BusinessSectorId;
            objFromDb.PartyDivisionId = citizenDetailInfo.PartyDivisionId;
            objFromDb.PartyPositionId = citizenDetailInfo.PartyPositionId;
            objFromDb.ElectionRoleId = citizenDetailInfo.ElectionRoleId;

            _db.SaveChanges();
        }
    }
}
