using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarMethodTest();
            //BrandTest();
            //ColorTest();

            CarManager carManager = new(new EfCarDao());
            var result = carManager.GetCarDetails();

            foreach (var detail in result.Data)
            {
                Console.WriteLine(detail.Description + "/" + detail.BrandName + "/" + detail.ColorName + "/" + detail.DailyPrice);
            }
            Console.WriteLine(result.Message);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new(new EfColorDao());

            colorManager.Add(new Color { Id = 1, Name = "blue" });
            colorManager.Add(new Color { Id = 2, Name = "red" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new(new EfBrandDao());

            brandManager.Add(new Brand { Id = 1, Name = "mercedes" });
            brandManager.Add(new Brand { Id = 2, Name = "ferrari" });
        }

        private static void CarMethodTest()
        {
            CarManager carManager = new CarManager(new EfCarDao());



            var carToShow = carManager.GetCarDetails();

        }
    }
}
