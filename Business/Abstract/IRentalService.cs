using Core.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        public IResult Add(Rental rental);
        public IResult Update(Rental rental);
        public IResult Delete(Rental rental);
        public IDataResult<Rental> get(int id);
        public IDataResult<List<Rental>> getAll();
    }
}
