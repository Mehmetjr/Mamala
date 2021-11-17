using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        void ContactAdd(Contact contact);
        void ContactDelete(Contact contact);
        List<Contact> GetAll();
        List<Contact> GetListById(int id);
        List<Contact> GetListByUser(int id);
        Contact GetById(int id);


    }
}
