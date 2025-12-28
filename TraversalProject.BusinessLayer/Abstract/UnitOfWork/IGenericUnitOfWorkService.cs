using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.BusinessLayer.Abstract.UnitOfWork
{
    public interface IGenericUnitOfWorkService<T>
    {
        void InsertBL(T p);
        void UpdateBL(T p);
        T GetByIdBL(int id);
        void MultiUpdateBL(List<T> p);
    }
}
