using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        List<Comment> GetListByDestinationId(int id);
        List<Comment> GetListCommentWithDestination();
        List<Comment> GetListByUserId(int userId);
    }
}
