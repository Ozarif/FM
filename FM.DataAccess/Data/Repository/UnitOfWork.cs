using FM.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly fmDBContext _db;

        public UnitOfWork(fmDBContext db)
        {
            _db = db;

            BusinessSector = new BusinessSectorRepository(_db);
            Province = new ProvinceRepository(_db);
            District = new DistrictRepository(_db);
            City = new CityRepository(_db);
            EducationalLevel = new EducationalLevelRepository(_db);
            ElectionRole = new ElectionRoleRepository(_db);
            HomeType = new HomeTypeRepository(_db);
            MaritalStatus = new MaritalStatusRepository(_db);
            MemberRelationType = new MemberRelationTypeRepository(_db);
            PartyDivision = new PartyDivisionRepository(_db);
            PartyPosition = new PartyPositionRepository(_db);
            ResultType = new ResultTypeRepository(_db);
            ServiceType = new ServiceTypeRepositorycs(_db);
            Citizen = new CitizenRepository(_db);
            CitizenDetailInfo = new CitizenDetailInfoRepository(_db);
            FamilyMemberInfo = new FamilyMemberInfoRepository(_db);
            ReferenceInfo = new ReferenceInfoRepository(_db);
            ServiceInfo = new ServiceInfoRepository(_db);
        }  
        public IBusinessSectorRepository BusinessSector {get; private set; }

        public IProvinceRepository Province { get; private set; }

        public IDistrictRepository District { get; private set; }

        public ICityRepository City { get; private set; }

        public IEducationalLevelRepository EducationalLevel { get; private set; }

        public IElectionRoleRepository ElectionRole { get; private set; }

        public IHomeTypeRepository HomeType { get; private set; }

        public IMaritalStatusRepository MaritalStatus { get; private set; }

        public IMemberRelationTypeRepository MemberRelationType { get; private set; }

        public IPartyDivisionRepository PartyDivision { get; private set; }

        public IPartyPositionRepository PartyPosition { get; private set; }

        public IResultTypeRepository ResultType { get; private set; }

        public IServiceTypeRepository ServiceType { get; private set; }

        public ICitizenRepository Citizen { get; private set; }

        public ICitizenDetailInfoRepository CitizenDetailInfo { get; private set; }

        public IFamilyMemberInfoRepository FamilyMemberInfo { get; private set; }

        public IReferenceInfoRepository ReferenceInfo { get; private set; }

        public IServiceInfoRepository ServiceInfo { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0 ? true : false;
        }
    }
}
