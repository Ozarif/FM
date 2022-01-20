using FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FM.BusinessLogic
{
    //[System.ComponentModel.DataObject]
    public class CitizenBL : BaseBL
    {
        public CitizenBL() : base()
        {

        }
        //[System.ComponentModel.DataObjectMethodAttribute
        //(System.ComponentModel.DataObjectMethodType.Select, true)]
        public IEnumerable<Citizen> GetAll()
        {
            // _unitOfWork.Service.GetAll(includeProperties: "Category,Frequency")
            //_unitOfWork.OrderDetails.GetAll(filter: o => o.OrderHeaderId == id)

            return _unitOfWork.Citizen.GetAll();
        }

        //public IEnumerable<Citizen> Search(string firstName = default(string), string fatherName = default(string), string lastName = default(string))
        //{
        //    return _unitOfWork.Citizen.GetAll(filter: s =>
        //                        (string.IsNullOrEmpty(firstName) || s.FirstName.Trim().Contains(firstName)) &&
        //                        (string.IsNullOrEmpty(fatherName) || s.FatherName.Trim().Contains(fatherName)) &&
        //                        (string.IsNullOrEmpty(lastName) || s.LastName.Trim().Contains(lastName)),
        //                        orderBy: q => q.OrderBy(d => d.FirstName)
        //        );
        //}

        public IEnumerable<Citizen> Search(Expression<Func<Citizen, bool>> filter = null,Func<IQueryable<Citizen>, IOrderedQueryable<Citizen>> orderBy = null)
        {
            return _unitOfWork.Citizen.GetAll(filter: filter, orderBy: orderBy);
        }

        public Citizen Get(int Id)
        {
            return _unitOfWork.Citizen.Get(Id);
        }
        public bool Save(Citizen citizen)
        {
            if (citizen.Id == 0)
            {
                _unitOfWork.Citizen.Add(citizen);
            }
            else
            {
                _unitOfWork.Citizen.Update(citizen);
            }
            return _unitOfWork.Save();
        }
        public bool Delete(int Id)
        {
            var objFromDb = _unitOfWork.Citizen.Get(Id);

            if (objFromDb == null)
            {
                // throw new Exception("Error while deleting.");
                return false;
            }
            _unitOfWork.Citizen.Remove(objFromDb);

            return _unitOfWork.Save();
        }
    }
}
