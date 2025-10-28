using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<TraversalProject.EntityLayer.Concrete.Reservation>
    {
        List<Reservation> GetListApprovalReservationBL(int id);
        List<Reservation> GetListWithReservationByWaitApprovalBL(int id);
        List<Reservation> GetListWithReservationByAcceptedBL(int id);
        List<Reservation> GetListWithReservationByPreviousBL(int id);
    }
}
