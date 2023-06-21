using Business.Abstract;
using Business.Constante;
using Core.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _IcarDal;

        public CarManager(CarDal carDal)
        {
            _IcarDal = carDal;
        }

        
        public IResult Add(Car car)
        {
            if (car.DailyPrice>0 && car.Name.Length>1)
            {
                _IcarDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else return new ErrorResult(Messages.CarNameError);

        }

        public IResult Update(Car car)
        {
            _IcarDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        public IResult Delet(Car car)
        {
            _IcarDal.Delete(car);
            return new SuccessResult(Messages.Cardeleted);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_IcarDal.Get(p => p.Id==id ));
        }
        public IDataResult<Car> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Car> (_IcarDal.Get(p => p.BrandId == brandId));
        }
        public IDataResult<Car> GetByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_IcarDal.Get(p => p.ColorId == colorId));
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll(p => p.BrandId==brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_IcarDal.GetAll(p => p.ColorId == colorId));
        }

        public IDataResult<List<CarDetails>> GetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetails>>(_IcarDal.GetProductDetails());
        }
    }
}
