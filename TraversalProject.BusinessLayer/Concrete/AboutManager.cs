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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void DeleteBL(About p)
        {
            _aboutDal.Delete(p);
        }

        public About GetByIdBL(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> GetListBL()
        {
            return _aboutDal.GetList();
        }

        public void InsertBL(About p)
        {
            _aboutDal.Insert(p);
        }

        public void UpdateBL(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
