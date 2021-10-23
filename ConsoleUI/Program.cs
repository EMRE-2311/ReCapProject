using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDao());

            carManager.Delete(new Car { Id = 2 });
            carManager.Add(new Car { Id = 5, BrandId = 3, ColorId = 6, DailyPrice = 831, ModelYear = 2015, Description = "TBC" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}
