using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Mamala.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaPoint.WcfLibrary.Concrete
{
    public class ProductService : IAdminService
    {
        private AdminManager _adminManager = new AdminManager(new EfAdminDal());
        public void Add(Admin admin)
        {
            _adminManager.Add(admin);
        }

        public void Delete(int adminId)
        {
            _adminManager.Delete(adminId);
        }

        public List<Admin> GetAll()
        {
            return _adminManager.GetAll();
        }

        public void Update(Admin admin)
        {
            _adminManager.Update(admin);
        }
    }
}
