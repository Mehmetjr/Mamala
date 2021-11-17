using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupporterService 
    {
        void SupporterAdd(Supporter supporter);
        void SupporterDelete(Supporter supporter);
        void SupporterUpdate(Supporter supporter);
        Supporter GetById(int id);
        List<Supporter> GetAll();

    }
}
