using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void ContactAdd(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.contactId == id);
        }

        public List<Contact> GetListById(int id)
        {
            return _contactDal.GetList(x => x.userId == id);
        }

        public List<Contact> GetListByUser(int id)
        {
            return _contactDal.GetList(x => x.userId == id);
        }
    }
}
