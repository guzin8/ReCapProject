using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, InformationContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (InformationContext context = new InformationContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             join i in context.CarImages
                             on c.Id equals i.CarId
                             select new CarDetailsDto { BrandName = b.BrandName,
                                 CarName = c.Description,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ImagePath = i.ImagePath,
                                 CarId = c.Id
                             };
                return result.ToList();
            }
        }
    }
}
