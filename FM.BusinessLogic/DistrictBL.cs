using FM.DataAccess.Data;
using FM.DataAccess.Data.Repository;
using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
   public  class DistrictBL : BaseBL
    {

        public DistrictBL():base()
        {
            
        }

        public IEnumerable<District> GetAll()
        {
            return _unitOfWork.District.GetAll();
        }
        public IEnumerable<District> GetAll(int provinceId)
        {
            return _unitOfWork.District.GetAll(c => c.ProvinceId == provinceId);
        }
        public District Get(int Id)
        {
            return _unitOfWork.District.Get(Id);
        }
        public bool Save(District district)
        {
            if (district.Id == 0)
            {
                _unitOfWork.District.Add(district);
            }
            else
            {
                _unitOfWork.District.Update(district);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.District.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.District.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
