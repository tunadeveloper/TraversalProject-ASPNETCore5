using System.Collections.Generic;
using TraversalProject.BusinessLayer.Abstract.UnitOfWork;
using TraversalProject.DataAccessLayer.Abstract.UnitOfWork;
using TraversalProject.DataAccessLayer.UnitOfWork;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete.UnitOfWork
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public Account GetByIdBL(int id)
        {
           return _accountDal.GetById(id);
        }

        public void InsertBL(Account p)
        {
            _accountDal.Insert(p);
            _unitOfWorkDal.Save();
        }

        public void MultiUpdateBL(List<Account> p)
        {
            _accountDal.MultiUpdate(p);
            _unitOfWorkDal.Save();
        }

        public void UpdateBL(Account p)
        {
            _accountDal.Update(p);
            _unitOfWorkDal.Save();
        }
    }
}
