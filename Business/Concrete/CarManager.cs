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
    public class CarManager : ICarService
    {
        ICarDao _carDao;

        public CarManager(ICarDao carDao)
        {
            _carDao = carDao;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("daily price must be larger than 0");
            }
            else if (car.Description.Length <= 2)
            {
                Console.WriteLine("description must be larger than 2 words");
            }
            else
            {
                _carDao.Add(car);
            }

        }

        public void Delete(Car car)
        {
            _carDao.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDao.GetById(id);
        }

        public void Update(Car car)
        {
            _carDao.Update(car);
        }
    }
}
