using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RequestManager : IRequestService
    {
        IRequestDal _requestDal;
        public RequestManager(IRequestDal requestDal)
        {
            _requestDal = requestDal;
        }
        public void Add(Request request)
        {
            _requestDal.Add(request);
        }

        public void Delete(Request request)
        {
            _requestDal.Delete(request);
        }

        public List<Request> GetAll()
        {
            return _requestDal.GetAll();
        }
       
        public Request GetById(int id)
        {
            return _requestDal.Get(x => x.requestId == id);
        }
    }
}
