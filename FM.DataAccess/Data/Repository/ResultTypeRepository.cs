using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository
{
    public class ResultTypeRepository : Repository<ResultType>, IResultTypeRepository
    {
        private readonly fmDBContext _db;
        public ResultTypeRepository(fmDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ResultType resultType)
        {
            var objFromDb = _db.ResultTypes.FirstOrDefault(i => i.Id == resultType.Id);

            objFromDb.Discription = resultType.Discription;

            _db.SaveChanges();
        }
    }
}
