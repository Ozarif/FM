using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class RegisterPlaceBL : BaseBL
    {
        public RegisterPlaceBL() : base()
        {

        }
        public IEnumerable<RegisterPlace> GetAll()
        {
            return _unitOfWork.RegisterPlace.GetAll();
        }
        public RegisterPlace Get(int Id)
        {
            return _unitOfWork.RegisterPlace.Get(Id);
        }
        public bool Save(RegisterPlace registerPlace)
        {
            if (registerPlace.Id == 0)
            {
                _unitOfWork.RegisterPlace.Add(registerPlace);
            }
            else
            {
                _unitOfWork.RegisterPlace.Update(registerPlace);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.RegisterPlace.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.RegisterPlace.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
