using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Repository;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(Context context) : base(context)
        {
        }

        public List<Comment> GetListByDestinationId(int id)
        {
            using (var context = new Context())
            {
                return context.Comments
                              .Where(x => x.DestinationId == id)
                              .OrderByDescending(x => x.CreatedDate)
                              .ToList();
            }
        }
    }
}
