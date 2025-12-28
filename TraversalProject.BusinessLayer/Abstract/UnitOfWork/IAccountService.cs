using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Abstract.UnitOfWork
{
    public interface IAccountService:IGenericUnitOfWorkService<Account>
    {
    }
}
