using FM.DataAccess.Data;
using FM.DataAccess.Data.Repository;
using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    public class CityBL : BaseBL
    {
      
        public CityBL():base()
        {
            
        }

        public IEnumerable<City> GetAll()
        {
            // _unitOfWork.Service.GetAll(includeProperties: "Category,Frequency")
            //_unitOfWork.OrderDetails.GetAll(filter: o => o.OrderHeaderId == id)

            return _unitOfWork.City.GetAll();
        }
        public IEnumerable<City> GetAll(int districtId)
        {
            return _unitOfWork.City.GetAll(c => c.DistrictId == districtId);
        }
        public City Get(int Id)
        {
            return _unitOfWork.City.Get(Id);
        }

        public bool Save(City city)
        {
            if (city.Id == 0)
            {
                _unitOfWork.City.Add(city);
            }
            else
            {
                _unitOfWork.City.Update(city);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.City.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.City.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
