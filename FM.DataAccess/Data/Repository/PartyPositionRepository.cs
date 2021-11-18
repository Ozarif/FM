using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class PartyPositionRepository : Repository<PartyPosition>, IPartyPositionRepository
    {
        private readonly fmDBContext _db;
        public PartyPositionRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(PartyPosition partyPosition)
        {
            var objFromDb = _db.PartyPositions.FirstOrDefault(i => i.Id == partyPosition.Id);

            objFromDb.Discription = partyPosition.Discription;

            _db.SaveChanges();
        }
    }
}
