using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    internal class UserManager : IUserService
    {
        IUserDal _UserDal;
        public UserManager(IUserDal UserDal)
        {
            _UserDal = UserDal;
        }
        public void TAdd(User t)
        {
            _UserDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _UserDal.Delete(t);
        }

        public User TGetByID(int id)
        {
            var user = _UserDal.GetById(id);
            return user;
        }

        public List<User> TGetList()
        {
            return _UserDal.GetList();
        }

        public void TUpdate(User t)
        {
            _UserDal.Update(t);
        }
    }
}
