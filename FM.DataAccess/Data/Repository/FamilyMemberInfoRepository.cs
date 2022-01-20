using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class FamilyMemberInfoRepository : Repository<FamilyMemberInfo>, IFamilyMemberInfoRepository
    {
        private readonly fmDBContext _db;
        public FamilyMemberInfoRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(FamilyMemberInfo familyMemberInfo)
        {
            var objFromDb = _db.FamilyMemberInfo.FirstOrDefault(i => i.Id == familyMemberInfo.Id);

            objFromDb.CitizenId = familyMemberInfo.CitizenId;
            objFromDb.Name = familyMemberInfo.Name;
            objFromDb.Sex = familyMemberInfo.Sex;
            objFromDb.MemberRelationTypeId = familyMemberInfo.MemberRelationTypeId;
            objFromDb.DateOfBirth = familyMemberInfo.DateOfBirth;


            _db.SaveChanges();
        }
    }
}
