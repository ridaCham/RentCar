using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDal : EfEntityRepositoryBase<Car, RentCarDB>, ICarDal
    {
        public List<CarDetails> GetProductDetails()
        {
            using (var context = new RentCarDB())
            {
                var result = from car in context.cars
                             join color in context.colors
                             on car.ColorId equals color.Id
                             join brand in context.brands
                             on car.BrandId equals brand.Id
                             select new CarDetails {
                                 CarName = car.Name,
                                 BrandName = brand.Name,
                                 ColorName = color.Name,
                                 DailyPrice = car.DailyPrice
                             };  
                return result.ToList(); 

            }
        }
    }
}
