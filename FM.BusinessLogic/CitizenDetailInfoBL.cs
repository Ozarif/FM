using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
   public  class CitizenDetailInfoBL : BaseBL
    {
        public CitizenDetailInfoBL() : base()
        {
            
        }

        public IEnumerable<CitizenDetailInfo> GetAll()
        {
            // _unitOfWork.Service.GetAll(includeProperties: "Category,Frequency")
            //_unitOfWork.OrderDetails.GetAll(filter: o => o.OrderHeaderId == id)

            return _unitOfWork.CitizenDetailInfo.GetAll();
        }
        public CitizenDetailInfo Get(int citizenId)
        {
            return _unitOfWork.CitizenDetailInfo.Get(citizenId);
        }
        public bool Save(CitizenDetailInfo citizenDetailInfo)
        {
            var objFromDb = _unitOfWork.CitizenDetailInfo.Get(citizenDetailInfo.CitizenId);

            if (objFromDb == null)
            {
                _unitOfWork.CitizenDetailInfo.Add(citizenDetailInfo);
            }
            else
            {
                _unitOfWork.CitizenDetailInfo.Update(citizenDetailInfo);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int citizenId)
        {
            var objFromDb = _unitOfWork.CitizenDetailInfo.Get(citizenId);

            if (objFromDb == null)
            {
                return false;
            }
            _unitOfWork.CitizenDetailInfo.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
