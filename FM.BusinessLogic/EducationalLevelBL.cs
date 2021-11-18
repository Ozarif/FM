using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class EducationalLevelBL : BaseBL
    {
         public EducationalLevelBL():base()
        {

        }
        public IEnumerable<EducationalLevel> GetAll()
        {
            return _unitOfWork.EducationalLevel.GetAll();
        }
        public EducationalLevel Get(int Id)
        {
            return _unitOfWork.EducationalLevel.Get(Id);
        }
        public bool Save(EducationalLevel educationalLevel)
        {
            if (educationalLevel.Id == 0)
            {
                _unitOfWork.EducationalLevel.Add(educationalLevel);
            }
            else
            {
                _unitOfWork.EducationalLevel.Update(educationalLevel);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.EducationalLevel.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.EducationalLevel.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
