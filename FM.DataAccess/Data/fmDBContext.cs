using FM.Models;
using System.Data.Entity;

namespace FM.DataAccess.Data
{
   public class fmDBContext :DbContext
    {
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<RegisterPlace> RegisterPlaces { get; set; }
        public DbSet<BusinessSector> BusinessSectors { get; set; }
        public DbSet<EducationalLevel> EducationalLevels { get; set; }
        public DbSet<ElectionRole> ElectionRoles { get; set; }
        public DbSet<HomeType> HomeTypes { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<MemberRelationType> MemberRelationTypes { get; set; }
        public DbSet<PartyDivision> PartyDivisions { get; set; }
        public DbSet<PartyPosition> PartyPositions { get; set; }
        public DbSet<ResultType> ResultTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<CitizenDetailInfo> CitizenDetailInfo { get; set; }
        public DbSet<FamilyMemberInfo> FamilyMemberInfo { get; set; }
        public DbSet<ReferenceInfo> ReferenceInfo { get; set; }
        public DbSet<ServiceInfo> ServiceInfo { get; set; }
        public DbSet<ReligionSection> ReligionSections { get; set; }
        public DbSet<Gender> Genders { get; set; }

    }
}
