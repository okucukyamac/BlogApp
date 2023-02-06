using Business.Abstrackt;
using DataAccess.Abstract;
using Entity.Concrete;
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

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> GetAll()
        {
            List<Contact> contacts = _contactDal.GetAll();
            return contacts;
        }

        public Contact GetById(int id)
        {
            Contact contact = _contactDal.GetById(id);
            return contact;
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
