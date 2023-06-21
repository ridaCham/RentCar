using Core.DataAccess.EntityFramework;
using Core.Entity;
using Core.Result;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentalDal : EfEntityRepositoryBase<Rental, RentCarDB>, IRentalDal
    {
       
        
    }
}
