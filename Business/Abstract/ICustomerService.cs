using Core.Result;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public IResult Add(Customer customer);
        public IResult Update(Customer customer);
       
        public IResult Delete(Customer customer);
        public IDataResult<Customer> Get(int id);
        public IDataResult<List<Customer>> GetAll();
        public IDataResult<List<CustomerDetail>>  GetCustomerDetail();

    }
}
