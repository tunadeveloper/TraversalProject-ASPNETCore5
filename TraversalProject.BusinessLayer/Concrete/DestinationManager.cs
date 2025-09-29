using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void DeleteBL(Destination p)
        {
            _destinationDal.Delete(p);
        }

        public Destination GetByIdBL(int id)
        {
          return  _destinationDal.GetById(id);
        }

        public List<Destination> GetListBL()
        {
            return _destinationDal.GetList();
        }

        public void InsertBL(Destination p)
        {
            _destinationDal.Insert(p);
        }

        public void UpdateBL(Destination p)
        {
            _destinationDal.Update(p);
        }
    }
}
