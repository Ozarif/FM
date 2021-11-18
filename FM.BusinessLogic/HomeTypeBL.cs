using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
   public class HomeTypeBL : BaseBL
    {
        //HomeType
        public HomeTypeBL() : base()
        {

        }
        public IEnumerable<HomeType> GetAll()
        {
            return _unitOfWork.HomeType.GetAll();
        }
        public HomeType Get(int Id)
        {
            return _unitOfWork.HomeType.Get(Id);
        }
        public bool Save(HomeType homeType)
        {
            if (homeType.Id == 0)
            {
                _unitOfWork.HomeType.Add(homeType);
            }
            else
            {
                _unitOfWork.HomeType.Update(homeType);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.HomeType.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.HomeType.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
