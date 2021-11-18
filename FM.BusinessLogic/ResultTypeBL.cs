using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
   public  class ResultTypeBL : BaseBL
    {
        public ResultTypeBL():base()
        {

        }
        public IEnumerable<ResultType> GetAll()
        {
            return _unitOfWork.ResultType.GetAll();
        }
        public ResultType Get(int Id)
        {
            return _unitOfWork.ResultType.Get(Id);
        }
        public bool Save(ResultType resultType)
        {
            if (resultType.Id == 0)
            {
                _unitOfWork.ResultType.Add(resultType);
            }
            else
            {
                _unitOfWork.ResultType.Update(resultType);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.ResultType.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.ResultType.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
