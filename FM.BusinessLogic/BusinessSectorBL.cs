using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class BusinessSectorBL : BaseBL
    {
        public BusinessSectorBL() : base()
        {
            
        }
        public IEnumerable<BusinessSector> GetAll()
        {
            return _unitOfWork.BusinessSector.GetAll();
        }
        public BusinessSector Get(int Id)
        {
            return _unitOfWork.BusinessSector.Get(Id);
        }
        public bool Save(BusinessSector businessSector)
        {
            if (businessSector.Id == 0)
            {
                _unitOfWork.BusinessSector.Add(businessSector);
            }
            else
            {
                _unitOfWork.BusinessSector.Update(businessSector);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.BusinessSector.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.BusinessSector.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
