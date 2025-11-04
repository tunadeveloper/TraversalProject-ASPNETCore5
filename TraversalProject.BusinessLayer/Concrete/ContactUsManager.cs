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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void DeleteBL(ContactUs p)
        {
            _contactUsDal.Delete(p);
        }

        public ContactUs GetByIdBL(int id)
        {
            return _contactUsDal.GetById(id);
        }

        public List<ContactUs> GetListBL()
        {
            return _contactUsDal.GetList();
        }

        public void InsertBL(ContactUs p)
        {
           _contactUsDal.Insert(p);
        }

        public void UpdateBL(ContactUs p)
        {
            throw new NotImplementedException();
        }
    }
}
