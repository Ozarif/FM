using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository.IRepository
{
    public interface ICitizenDetailInfoRepository : IRepository<CitizenDetailInfo>
    {
        void Update(CitizenDetailInfo citizenDetailInfo);
    }
}
