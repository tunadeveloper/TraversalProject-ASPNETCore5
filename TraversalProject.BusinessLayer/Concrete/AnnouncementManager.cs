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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void DeleteBL(Announcement p)
        {
            _announcementDal.Delete(p);
        }

        public Announcement GetByIdBL(int id)
        {
          return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListBL()
        {
            return _announcementDal.GetList();
        }

        public void InsertBL(Announcement p)
        {
           _announcementDal.Insert(p);
        }

        public void UpdateBL(Announcement p)
        {
          _announcementDal.Update(p);
        }
    }
}
