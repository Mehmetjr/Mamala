using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public List<Admin> GetList()
        {
            return _adminDal.GetAll();
        }

        public void AdminAdd(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x => x.adminId == id);
        }

        public void AdminDelete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
