using Business.Abstract;
using Core.Result;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _IRentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _IRentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                _IRentalDal.Add(rental);    
                return new SuccessResult();
            }
            return new ErrorResult("Araba Müşteride");
        }

        public IResult Delete(Rental rental)
        {
            _IRentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<Rental> get(int id)
        {
            return new SuccessDataResult<Rental>();
        }

        public IDataResult<List<Rental>> getAll()
        {
            return new SuccessDataResult<List<Rental>>();
        }

        public IResult Update(Rental rental)
        {
            _IRentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
