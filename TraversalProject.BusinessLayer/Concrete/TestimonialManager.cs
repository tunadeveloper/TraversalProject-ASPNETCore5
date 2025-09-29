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
    public class TestimonialManager : ITestimonalService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void DeleteBL(Testimonial p)
        {
            _testimonialDal.Delete(p);
        }

        public Testimonial GetByIdBL(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetListBL()
        {
            return _testimonialDal.GetList();
        }

        public void InsertBL(Testimonial p)
        {
            _testimonialDal.Insert(p);
        }

        public void UpdateBL(Testimonial p)
        {
            _testimonialDal.Update(p);
        }
    }
}
