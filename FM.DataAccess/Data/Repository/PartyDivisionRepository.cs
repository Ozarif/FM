using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class PartyDivisionRepository : Repository<PartyDivision>, IPartyDivisionRepository
    {
        private readonly fmDBContext _db;
        public PartyDivisionRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PartyDivision partyDivision)
        {
            var objFromDb = _db.PartyDivisions.FirstOrDefault(i => i.Id == partyDivision.Id);

            objFromDb.Discription = partyDivision.Discription;

            _db.SaveChanges();
        }
    }
}
