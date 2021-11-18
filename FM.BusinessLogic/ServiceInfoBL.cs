using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class ServiceInfoBL : BaseBL
    {
        public ServiceInfoBL() : base()
        {
         
        }
        public IEnumerable<ServiceInfo> GetAll()
        {
            // _unitOfWork.Service.GetAll(includeProperties: "Category,Frequency")
            //_unitOfWork.OrderDetails.GetAll(filter: o => o.OrderHeaderId == id)

            return _unitOfWork.ServiceInfo.GetAll();
        }
        public IEnumerable<ServiceInfo> GetAll(int citizenId)
        {
            return _unitOfWork.ServiceInfo.GetAll(c => c.CitizenId == citizenId);
        }
        public ServiceInfo Get(int Id)
        {
            return _unitOfWork.ServiceInfo.Get(Id);
        }
        public bool Save(ServiceInfo serviceInfo)
        {
            if (serviceInfo.Id == 0)
            {
                _unitOfWork.ServiceInfo.Add(serviceInfo);
            }
            else
            {
                _unitOfWork.ServiceInfo.Update(serviceInfo);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.ServiceInfo.Get(Id);

            if (objFromDb == null)
            {
                return false;
            }
            _unitOfWork.ServiceInfo.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
