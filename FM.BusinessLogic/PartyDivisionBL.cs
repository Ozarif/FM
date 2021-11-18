using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class PartyDivisionBL : BaseBL
    {
        public PartyDivisionBL():base()
        {

        }
        public IEnumerable<PartyDivision> GetAll()
        {
            return _unitOfWork.PartyDivision.GetAll();
        }
        public PartyDivision Get(int Id)
        {
            return _unitOfWork.PartyDivision.Get(Id);
        }
        public bool Save(PartyDivision partyDivision)
        {
            if (partyDivision.Id == 0)
            {
                _unitOfWork.PartyDivision.Add(partyDivision);
            }
            else
            {
                _unitOfWork.PartyDivision.Update(partyDivision);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.PartyDivision.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.PartyDivision.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
