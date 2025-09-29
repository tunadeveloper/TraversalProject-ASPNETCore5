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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void DeleteBL(Guide p)
        {
            _guideDal.Delete(p);
        }

        public Guide GetByIdBL(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> GetListBL()
        {
            return _guideDal.GetList();
        }

        public void InsertBL(Guide p)
        {
            _guideDal.Insert(p);
        }

        public void UpdateBL(Guide p)
        {
            _guideDal.Update(p);
        }
    }
}
