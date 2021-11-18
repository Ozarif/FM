using FM.DataAccess.Data;
using FM.DataAccess.Data.Repository;
using FM.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class BaseBL 
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseBL()
        {
            _unitOfWork = new UnitOfWork(new fmDBContext());
        }

        ~BaseBL()
        {
            _unitOfWork.Dispose();
        }
    }
}
