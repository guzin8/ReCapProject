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
            //BrandTest();
            //ColorTest();
            //CarTest();
           // RentalTest();
            //Customer customer = new Customer { CustomerId = 5, CustomerName = "Sevgi", UserId = 10 };
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(customer);
        }
        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental.CustomerName);
            }
            Console.WriteLine(rentalManager.GetRentalDetails().Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { BrandId = 3, ColorId = 1, ModelYear = 2015, DailyPrice = 150, Description = "Otomatik" };
            carManager.Add(car1);

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / "  + car.ColorName + " / " + car.DailyPrice);
            }

            car1.Description = "Manuel";
            carManager.Update(car1);

            Console.WriteLine("----Güncellendikten sonra------ ");

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }

            Console.WriteLine(" ----- Car1 silindikten sonra----- ");
            carManager.Delete(car1);
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }

            Console.WriteLine("2. Arabanın model yili: " + carManager.GetById(2).Data.ModelYear);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color { ColorName = "Yesil" };
            Color color2 = new Color { ColorName = "Beyaz" };
            colorManager.Add(color1);
            colorManager.Add(color2);

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("-----Güncellendikten sonra------");

            color1.ColorName = "Siyah";
            colorManager.Update(color1);

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("-----Color2 silindikten sonra----");

            colorManager.Delete(color2);

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("1. renk: " + colorManager.GetById(1).Data.ColorName);
        }

        static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand1 = new Brand { BrandName = "Bugatti" };
            brandManager.Add(brand1);

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            brand1.BrandName = "Cadillac";
            brandManager.Update(brand1);

            Console.WriteLine("-----Güncellendikten sonra-----");

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            brandManager.Delete(brand1);

            Console.WriteLine("-------Brand1 silindikten sonra---------");

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("Birinci marka: " + brandManager.GetById(1).Data.BrandName);
        }
    }
}
