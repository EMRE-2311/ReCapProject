using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDao : ICarDao
    {
        List<Car> _cars;
        public InMemoryCarDao()
        {
            _cars = new List<Car> {new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=2500, ModelYear=2000, Description="Sports Car"},
                 new Car {Id =2, BrandId=2, ColorId=1, DailyPrice=5000, ModelYear=2010, Description="Sports Car"},
                 new Car {Id=3, BrandId=2, ColorId=2, DailyPrice=800, ModelYear=1999, Description="Van"} ,
                 new Car {Id=4, BrandId=3, ColorId=3, DailyPrice=10000, ModelYear=2019, Description="Sports Car"}};
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
