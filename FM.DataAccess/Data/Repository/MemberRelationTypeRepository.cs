using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class MemberRelationTypeRepository : Repository<MemberRelationType>, IMemberRelationTypeRepository
    {
        private readonly fmDBContext _db;

        public MemberRelationTypeRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MemberRelationType memberRelationType)
        {
            var objFromDb = _db.MemberRelationTypes.FirstOrDefault(i => i.Id == memberRelationType.Id);

            objFromDb.Discription = memberRelationType.Discription;

            _db.SaveChanges();
        }
    }
}
