using FM.DataAccess.Data;
using FM.DataAccess.Data.Repository;
using FM.DataAccess.Data.Repository.IRepository;
using FM.Models;
using System;
using System.Collections.Generic;

namespace FM.BusinessLogic
{
    [System.ComponentModel.DataObject]
    public class ProvinceBL :  BaseBL
    {

        public ProvinceBL():base()
        {      
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public IEnumerable<Province> GetAll()
        {
            return _unitOfWork.Province.GetAll();
        }
        public Province Get(int Id)
        {
            return _unitOfWork.Province.Get(Id);
        }
        public bool Save(Province province)
        {
            if (province.Id == 0)
            {
                _unitOfWork.Province.Add(province);
            }
            else
            {
                _unitOfWork.Province.Update(province);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.Province.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.Province.Remove(objFromDb);

            return _unitOfWork.Save();
        } 
    }
}
