using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRequestService
    {
        void Add(Request request);
        void Delete(Request request);
        List<Request> GetAll();
        Request GetById(int id);
    }
}
