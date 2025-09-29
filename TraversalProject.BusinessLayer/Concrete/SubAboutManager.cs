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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAbout;

        public SubAboutManager(ISubAboutDal subAbout)
        {
            _subAbout = subAbout;
        }

        public void DeleteBL(SubAbout p)
        {
            _subAbout.Delete(p);
        }

        public SubAbout GetByIdBL(int id)
        {
            return _subAbout.GetById(id);
        }

        public List<SubAbout> GetListBL()
        {
            return _subAbout.GetList();
        }

        public void InsertBL(SubAbout p)
        {
            _subAbout.Insert(p);
        }

        public void UpdateBL(SubAbout p)
        {
            _subAbout.Update(p);
        }
    }
}
