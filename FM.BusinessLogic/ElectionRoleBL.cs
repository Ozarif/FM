using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
   public  class ElectionRoleBL : BaseBL
    {

        public ElectionRoleBL() : base()
        {

        }
        public IEnumerable<ElectionRole> GetAll()
        {
            return _unitOfWork.ElectionRole.GetAll();
        }
        public ElectionRole Get(int Id)
        {
            return _unitOfWork.ElectionRole.Get(Id);
        }
        public bool Save(ElectionRole electionRole)
        {
            if (electionRole.Id == 0)
            {
                _unitOfWork.ElectionRole.Add(electionRole);
            }
            else
            {
                _unitOfWork.ElectionRole.Update(electionRole);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.ElectionRole.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.ElectionRole.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
