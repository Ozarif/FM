using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class FamilyMemberInfoBL : BaseBL
    {
        public FamilyMemberInfoBL() : base()
        {

        }
        public IEnumerable<FamilyMemberInfo> GetAll()
        {
            // _unitOfWork.Service.GetAll(includeProperties: "Category,Frequency")
            //_unitOfWork.OrderDetails.GetAll(filter: o => o.OrderHeaderId == id)

            return _unitOfWork.FamilyMemberInfo.GetAll();
        }
        public IEnumerable<FamilyMemberInfo> GetAll(int citizenId)
        {
            return _unitOfWork.FamilyMemberInfo.GetAll(c => c.CitizenId == citizenId);
        }
        public FamilyMemberInfo Get(int Id)
        {
            return _unitOfWork.FamilyMemberInfo.Get(Id);
        }
        public bool Save(FamilyMemberInfo familyMemberInfo)
        {
            if (familyMemberInfo.Id == 0)
            {
                _unitOfWork.FamilyMemberInfo.Add(familyMemberInfo);
            }
            else
            {
                _unitOfWork.FamilyMemberInfo.Update(familyMemberInfo);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.FamilyMemberInfo.Get(Id);

            if (objFromDb == null)
            {
                return false;
            }
            _unitOfWork.FamilyMemberInfo.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
