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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void DeleteBL(Newsletter p)
        {
            _newsletterDal.Delete(p);
        }

        public Newsletter GetByIdBL(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public List<Newsletter> GetListBL()
        {
            return _newsletterDal.GetList();
        }

        public void InsertBL(Newsletter p)
        {
            _newsletterDal.Insert(p);
        }

        public void UpdateBL(Newsletter p)
        {
            _newsletterDal.Update(p);
        }
    }
}
