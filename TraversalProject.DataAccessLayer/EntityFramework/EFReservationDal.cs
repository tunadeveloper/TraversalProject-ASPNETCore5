using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Repository;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.EntityFramework
{
    public class EFReservationDal : GenericRepository<TraversalProject.EntityLayer.Concrete.Reservation>, Abstract.IReservationDal
    {
        private readonly Context _context;
        public EFReservationDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
           return _context.Reservations.Where(x => x.AppUserId == id && x.Status == "Onay Bekliyor").ToList();
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _context.Reservations.Include(x => x.AppUser).Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status == "Onaylandı").ToList();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status == "Geçmiş Rezervasyon").ToList();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId == id && x.Status == "Onay Bekliyor").ToList();
        }
    }
}
