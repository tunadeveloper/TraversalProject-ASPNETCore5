using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Repository;

namespace TraversalProject.DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<TraversalProject.EntityLayer.Concrete.ContactUs>, Abstract.IContactUsDal
    {
        public EfContactUsDal(Context context) : base(context)
        {
        }
    }
}
