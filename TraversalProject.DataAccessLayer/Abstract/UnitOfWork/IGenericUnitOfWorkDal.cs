using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.DataAccessLayer.Abstract.UnitOfWork
{
    public interface IGenericUnitOfWorkDal<T> where T :class
    {
        void Insert(T p);
        void Update(T p);
        T GetById(int id);
        void MultiUpdate(List<T> p);
    }
}
