using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CustomerDal : EfEntityRepositoryBase<Customer, RentCarDB>, ICustomerDal
    {
        public List<CustomerDetail> GetCustomerDetail()
        {
            using (RentCarDB context = new RentCarDB())
            {
                var result = from c in context.Customers
                             join u in context.users
                             on c.UserId equals u.UserId
                             select new CustomerDetail
                             {
                                 Email = u.Email,
                                 Password = u.Password,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = c.CompanyName,
                             };
                return result.ToList();
            }
        }
    }
}
