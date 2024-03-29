﻿using Core.Entity;
using Core.Result;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        public IResult Add(User user);
        public IResult Update(User user);
        public IResult Delete(User user);

        public IDataResult<List<User>> GetAll();
        public IDataResult<User> GetById(int id);

    }
}
