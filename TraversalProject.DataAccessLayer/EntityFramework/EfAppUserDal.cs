using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Repository;

namespace TraversalProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<EntityLayer.Concrete.AppUser>, Abstract.IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }
    }
}
