using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void InsertBL(T p);
        void DeleteBL(T p);
        void UpdateBL(T p);
        List<T> GetListBL();
        T GetByIdBL(int id);
    }
}
