using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
            List<Car> _cars = new List<Car>
        {
            new Car{Id= 1,BrandId=8,ColorId = 3,ModelYear = 2006,DailyPrice = 2000, Description = "2. El Araba."},
            new Car{Id= 2,BrandId=9,ColorId = 4,ModelYear = 2016,DailyPrice = 3000, Description = "Temiz kullanılmış."},
            new Car{Id= 3,BrandId=10,ColorId = 5,ModelYear = 2020,DailyPrice = 4000, Description = "Spor Araba"},
            new Car{Id= 4,BrandId=11,ColorId = 10,ModelYear = 2021,DailyPrice = 5000, Description = "Klasik Araba"}
        };
       
        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c=>c.Id ==car.Id); 

            _cars.Remove(CarToDelete);
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c=>c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description; 
        }
    }
}
