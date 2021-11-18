using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class ReferenceInfoBL : BaseBL
    {
        public ReferenceInfoBL() : base()
        {

        }
        public IEnumerable<ReferenceInfo> GetAll()
        {
            // _unitOfWork.Service.GetAll(includeProperties: "Category,Frequency")
            //_unitOfWork.OrderDetails.GetAll(filter: o => o.OrderHeaderId == id)

            return _unitOfWork.ReferenceInfo.GetAll();
        }
        public IEnumerable<ReferenceInfo> GetAll(int citizenId)
        {
            return _unitOfWork.ReferenceInfo.GetAll(c => c.CitizenId == citizenId);
        }
        public ReferenceInfo Get(int Id)
        {
            return _unitOfWork.ReferenceInfo.Get(Id);
        }
        public bool Save(ReferenceInfo referenceInfo)
        {
            if (referenceInfo.Id == 0)
            {
                _unitOfWork.ReferenceInfo.Add(referenceInfo);
            }
            else
            {
                _unitOfWork.ReferenceInfo.Update(referenceInfo);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.ReferenceInfo.Get(Id);

            if (objFromDb == null)
            {
                return false;
            }
            _unitOfWork.ReferenceInfo.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
