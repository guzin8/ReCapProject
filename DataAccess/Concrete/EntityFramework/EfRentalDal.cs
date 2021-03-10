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
                             select new RentalDetailsDto
                             {
                                 RentalId = re.Id,
                                 CarId = ca.Id,
                                 CarName = ca.Description,
                                 CustomerName = cu.CustomerName,
                                 UserName = us.FirstName,
                                 RentDate = re.RentDate,
                                 ReturnDate =re.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
