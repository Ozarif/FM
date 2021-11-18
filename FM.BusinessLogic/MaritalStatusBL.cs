using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class MaritalStatusBL :BaseBL
    {
         public MaritalStatusBL():base()
        {

        }
        public IEnumerable<MaritalStatus> GetAll()
        {
            return _unitOfWork.MaritalStatus.GetAll();
        }
        public MaritalStatus Get(int Id)
        {
            return _unitOfWork.MaritalStatus.Get(Id);
        }
        public bool Save(MaritalStatus maritalStatus)
        {
            if (maritalStatus.Id == 0)
            {
                _unitOfWork.MaritalStatus.Add(maritalStatus);
            }
            else
            {
                _unitOfWork.MaritalStatus.Update(maritalStatus);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.MaritalStatus.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.MaritalStatus.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
