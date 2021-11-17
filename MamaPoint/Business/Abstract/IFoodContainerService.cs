using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFoodContainerService
    {
        void Add(FoodContainer foodContainer);
        void Delete(FoodContainer foodContainer);
        void Update(FoodContainer foodContainer);
        FoodContainer GetById(int id);
        List<FoodContainer> GetList();

    }
}
