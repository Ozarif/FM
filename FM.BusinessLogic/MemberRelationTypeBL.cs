using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class MemberRelationTypeBL : BaseBL
    {
        public MemberRelationTypeBL() : base()
        {
            
        }
        public IEnumerable<MemberRelationType> GetAll()
        {
            return _unitOfWork.MemberRelationType.GetAll();
        }
        public MemberRelationType Get(int Id)
        {
            return _unitOfWork.MemberRelationType.Get(Id);
        }
        public bool Save(MemberRelationType memberRelationType)
        {
            if (memberRelationType.Id == 0)
            {
                _unitOfWork.MemberRelationType.Add(memberRelationType);
            }
            else
            {
                _unitOfWork.MemberRelationType.Update(memberRelationType);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.MemberRelationType.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.MemberRelationType.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
