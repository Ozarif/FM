using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ElectionRoleRepository : Repository<ElectionRole>, IElectionRoleRepository
    {
        private readonly fmDBContext _db;
        public ElectionRoleRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ElectionRole electionRole)
        {
            var objFromDb = _db.ElectionRoles.FirstOrDefault(i => i.Id == electionRole.Id);

            objFromDb.Discription = electionRole.Discription;

            _db.SaveChanges();
        }
    }
}
