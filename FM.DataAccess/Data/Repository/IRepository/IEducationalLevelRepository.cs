using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataAccess.Data.Repository.IRepository
{
   public  interface IEducationalLevelRepository : IRepository<EducationalLevel>
    {
        void Update(EducationalLevel educationalLevel);
    }
}
