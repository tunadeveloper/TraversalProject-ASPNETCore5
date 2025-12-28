using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract.UnitOfWork;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Repository;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.EntityFramework.UnitOfWork
{
    public class EfAccountDal : GenericUnitOfWorkRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {
        }
    }
}
