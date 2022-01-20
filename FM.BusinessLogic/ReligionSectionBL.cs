using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class ReligionSectionBL : BaseBL
    {
        public ReligionSectionBL() : base()
        {        }

        public IEnumerable<ReligionSection> GetAll()
        {
            return _unitOfWork.ReligionSection.GetAll();
        }
        public ReligionSection Get(int Id)
        {
            return _unitOfWork.ReligionSection.Get(Id);
        }
        public bool Save(ReligionSection religionSection)
        {
            if (religionSection.Id == 0)
            {
                _unitOfWork.ReligionSection.Add(religionSection);
            }
            else
            {
                _unitOfWork.ReligionSection.Update(religionSection);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.ReligionSection.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.ReligionSection.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}

