using Business.Abstract;
using Business.Constante;
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
    public class UserManager : IUserService
    {
        IUserDal _IUserDal;
        public UserManager(IUserDal IUserDal)
        {
            _IUserDal = IUserDal;
        }
        public IResult Add(User user)
        {
            if (user.FirstName.Length<2 || user.LastName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameError);
            }
            _IUserDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _IUserDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_IUserDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_IUserDal.Get(p=> p.UserId==id));
        }

        public IResult Update(User user)
        {
            _IUserDal.Update(user);
            return new SuccessResult();
        }
    }
}
