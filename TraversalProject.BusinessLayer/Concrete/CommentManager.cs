using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.EntityFramework;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void DeleteBL(Comment p)
        {
           _commentDal.Delete(p);
        }

        public Comment GetByIdBL(int id)
        {
         return  _commentDal.GetById(id);
        }

        public List<Comment> GetListBL()
        {
            return _commentDal.GetList();
        }

        public List<Comment> GetListByDestinationIdBL(int id)
        {
            return _commentDal.GetListByDestinationId(id);
        }

        public List<Comment> GetListCommentWithDestinationBL()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> GetListByUserIdBL(int userId)
        {
            return _commentDal.GetListByUserId(userId);
        }

        public void InsertBL(Comment p)
        {
           _commentDal.Insert(p);
        }

        public void UpdateBL(Comment p)
        {
            throw new NotImplementedException();
        }
    }
}
