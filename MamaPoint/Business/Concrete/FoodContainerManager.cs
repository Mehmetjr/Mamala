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
    public class FoodContainerManager : IFoodContainerService
    {
        IFoodContainerDal _foodContainerDal;
        public FoodContainerManager(IFoodContainerDal foodContainerDal)
        {
            _foodContainerDal = foodContainerDal;
        }
        public void Add(FoodContainer foodContainer)
        {
            _foodContainerDal.Add(foodContainer);
        }

        public void Delete(FoodContainer foodContainer)
        {
            _foodContainerDal.Delete(foodContainer);
        }

        public FoodContainer GetById(int id)
        {
            return _foodContainerDal.Get(x => x.containerId == id);
        }

        public List<FoodContainer> GetList()
        {
            return _foodContainerDal.GetAll();
        }

        public void Update(FoodContainer foodContainer)
        {
            _foodContainerDal.Update(foodContainer);
        }
    }
}
