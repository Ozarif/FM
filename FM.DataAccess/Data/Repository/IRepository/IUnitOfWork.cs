using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork :IDisposable
    {

        IBusinessSectorRepository BusinessSector { get; }
        IProvinceRepository Province { get; }
        IDistrictRepository District { get; }
        ICityRepository City { get; }
        IEducationalLevelRepository EducationalLevel { get; }
        IElectionRoleRepository ElectionRole { get; }
        IHomeTypeRepository HomeType { get; }
        IMaritalStatusRepository MaritalStatus { get; }
        IMemberRelationTypeRepository MemberRelationType { get; }
        IPartyDivisionRepository PartyDivision { get; }
        IPartyPositionRepository PartyPosition { get; }
        IResultTypeRepository ResultType { get; }
        IServiceTypeRepository ServiceType { get; }
        ICitizenRepository Citizen { get; }
        ICitizenDetailInfoRepository CitizenDetailInfo { get; }
        IFamilyMemberInfoRepository FamilyMemberInfo { get; }
        IReferenceInfoRepository ReferenceInfo { get; }
        IServiceInfoRepository ServiceInfo { get; }
        IRegisterPlaceRepository RegisterPlace { get; }
        IReligionSectionRepository ReligionSection { get; }
        IGenderRepository Gender { get; }
        bool Save();

    }
}
