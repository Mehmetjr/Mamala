using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SupporterManager : ISupporterService
    {
        ISupporterDal _supporterDal;
        public SupporterManager(ISupporterDal supporterDal)
        {
            _supporterDal = supporterDal;
        }
        public List<Supporter> GetAll()
        {
            return _supporterDal.GetAll();
        }

        public Supporter GetById(int id)
        {
           return _supporterDal.Get(x => x.supporterId == id);
        }

        public void SupporterAdd(Supporter supporter)
        {
            _supporterDal.Add(supporter);
        }

        public void SupporterDelete(Supporter supporter)
        {
            _supporterDal.Delete(supporter);
        }

        public void SupporterUpdate(Supporter supporter)
        {
            _supporterDal.Update(supporter);
        }
    }
}
