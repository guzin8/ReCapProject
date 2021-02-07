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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand { BrandName = "Astra" };
            brandManager.Add(brand1);
            
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color { ColorName = "Mor" };
            Color color2 = new Color { ColorName = "Kirmizi" };
            colorManager.Add(color1);
            colorManager.Add(color2);

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { BrandId = 3, ColorId = 1, ModelYear = 2015, DailyPrice = 150, Description = "Otomatik" };
            carManager.Add(car1);
            Console.WriteLine(carManager.GetById(2).ModelYear);
        }
    }
}
