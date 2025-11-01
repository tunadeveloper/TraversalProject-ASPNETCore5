using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete
{
    public class AppUserManager : Abstract.IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void DeleteBL(AppUser p)
        {
            _appUserDal.Delete(p);
        }

        public AppUser GetByIdBL(int id)
        {
           return _appUserDal.GetById(id);
        }

        public List<AppUser> GetListBL()
        {
           return _appUserDal.GetList();
        }

        public void InsertBL(AppUser p)
        {
           _appUserDal.Insert(p);
        }

        public void UpdateBL(AppUser p)
        {
           _appUserDal.Update(p);
        }
    }
}
