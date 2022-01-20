using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class GenderBL : BaseBL
    {
        public GenderBL() : base()
        {

        }
        public IEnumerable<Gender> GetAll()
        {
            return _unitOfWork.Gender.GetAll();
        }
        public Gender Get(int Id)
        {
            return _unitOfWork.Gender.Get(Id);
        }
        public bool Save(Gender gender)
        {
            if (gender.Id == 0)
            {
                _unitOfWork.Gender.Add(gender);
            }
            else
            {
                _unitOfWork.Gender.Update(gender);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.Gender.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.Gender.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
