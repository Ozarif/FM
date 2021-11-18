using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class ServiceTypeBL : BaseBL
    {
        public ServiceTypeBL() : base()
        {

        }
        public IEnumerable<ServiceType> GetAll()
        {
            return _unitOfWork.ServiceType.GetAll();
        }
        public ServiceType Get(int Id)
        {
            return _unitOfWork.ServiceType.Get(Id);
        }
        public bool Save(ServiceType serviceType)
        {
            if (serviceType.Id == 0)
            {
                _unitOfWork.ServiceType.Add(serviceType);
            }
            else
            {
                _unitOfWork.ServiceType.Update(serviceType);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.ServiceType.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.ServiceType.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
