using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class PartyPositionBL : BaseBL
    {
        public PartyPositionBL() :base()
        {

        }
        public IEnumerable<PartyPosition> GetAll()
        {
            return _unitOfWork.PartyPosition.GetAll();
        }
        public PartyPosition Get(int Id)
        {
            return _unitOfWork.PartyPosition.Get(Id);
        }
        public bool Save(PartyPosition partyPosition)
        {
            if (partyPosition.Id == 0)
            {
                _unitOfWork.PartyPosition.Add(partyPosition);
            }
            else
            {
                _unitOfWork.PartyPosition.Update(partyPosition);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.PartyPosition.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.PartyPosition.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
