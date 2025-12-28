using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract.UnitOfWork;
using TraversalProject.DataAccessLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Repository
{
    public class GenericUnitOfWorkRepository<T> : IGenericUnitOfWorkDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUnitOfWorkRepository(Context context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T p)
        {
            _context.Add(p);
        }

        public void MultiUpdate(List<T> p)
        {
           _context.UpdateRange(p);
        }

        public void Update(T p)
        {
           _context.Update(p);
        }
    }
}
