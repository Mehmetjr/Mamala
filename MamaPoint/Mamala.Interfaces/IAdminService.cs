using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Mamala.Interfaces
{
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        List<Admin> GetAll();
        [OperationContract]
        void Add(Admin admin);
        [OperationContract]
        void Delete(int adminId);
        [OperationContract]
        void Update(Admin admin);
    }
}
