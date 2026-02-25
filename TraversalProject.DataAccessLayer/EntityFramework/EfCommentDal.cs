using Microsoft.EntityFrameworkCore;
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
        private readonly Context _context;
        public EfCommentDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetListByDestinationId(int id)
        {
                return _context.Comments
                              .Where(x => x.DestinationId == id)
                              .OrderByDescending(x => x.CreatedDate)
                              .ToList();
            
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _context.Comments.Include(x => x.Destination).ToList();
        }

        public List<Comment> GetListByUserId(int userId)
        {
            return _context.Comments
                .Include(x => x.Destination)
                .Where(x => x.UserId == userId)
                .OrderByDescending(x => x.CreatedDate)
                .ToList();
        }
    }
}
