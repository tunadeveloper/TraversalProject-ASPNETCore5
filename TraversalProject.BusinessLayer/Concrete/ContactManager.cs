using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void DeleteBL(Contact p)
        {
            _contactDal.Delete(p);
        }

        public Contact GetByIdBL(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListBL()
        {
            return _contactDal.GetList();
        }

        public void InsertBL(Contact p)
        {
            _contactDal.Insert(p);
        }

        public void UpdateBL(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
