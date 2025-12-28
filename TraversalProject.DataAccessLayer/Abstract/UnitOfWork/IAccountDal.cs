using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Abstract.UnitOfWork
{
    public interface IAccountDal:IGenericUnitOfWorkDal<Account>
    {
    }
}
