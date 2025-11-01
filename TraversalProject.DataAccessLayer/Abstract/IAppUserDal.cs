using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Repository;

namespace TraversalProject.DataAccessLayer.Abstract
{
    public interface IAppUserDal:IGenericDal<EntityLayer.Concrete.AppUser>
    {
    }
}
