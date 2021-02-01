using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface CarService
    {
        List<Car> GetAll();
        Car GetById(int id);
    }
}
