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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void DeleteBL(Reservation p)
        {
            _reservationDal.Delete(p);
        }

        public Reservation GetByIdBL(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> GetListApprovalReservationBL(int id)
        {
            return _reservationDal.GetListApprovalReservation(id);
        }

        public List<Reservation> GetListBL()
        {
            return _reservationDal.GetList();
        }

        public List<Reservation> GetListWithReservationByAcceptedBL(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPreviousBL(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitApprovalBL(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public void InsertBL(Reservation p)
        {
            _reservationDal.Insert(p);
        }

        public void UpdateBL(Reservation p)
        {
            _reservationDal.Update(p);
        }
    }
}
