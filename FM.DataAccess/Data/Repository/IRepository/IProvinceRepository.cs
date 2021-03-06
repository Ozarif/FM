using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository.IRepository
{
    public interface IProvinceRepository : IRepository<Province>
    {
        void Update(Province province);
    }
}
