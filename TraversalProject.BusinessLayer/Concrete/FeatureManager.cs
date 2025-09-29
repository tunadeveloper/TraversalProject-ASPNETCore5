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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void DeleteBL(Feature p)
        {
            _featureDal.Delete(p);
        }

        public Feature GetByIdBL(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> GetListBL()
        {
            return _featureDal.GetList();
        }

        public void InsertBL(Feature p)
        {
            _featureDal.Insert(p);
        }

        public void UpdateBL(Feature p)
        {
            _featureDal.Update(p);
        }
    }
}
