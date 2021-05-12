using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, InformationContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (InformationContext context = new InformationContext())
            {
                var result = from ca in context.Cars
                             join re in context.Rentals
                             on ca.Id equals re.CarId
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join us in context.Users
                             on cu.UserId equals us.Id
                             join be in context.Brands
                             on ca.BrandId equals be.BrandId
                            
                           
                             select new RentalDetailsDto
                             {
                                 RentalId = re.Id,
                                 BrandName = be.BrandName,                                                               
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 RentDate = re.RentDate,
                                 ReturnDate =re.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
