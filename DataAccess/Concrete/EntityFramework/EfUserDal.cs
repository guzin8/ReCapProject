using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, InformationContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (InformationContext context = new InformationContext())
            {
                var result = from a in context.OperationClaims
                             join b in context.UserOperationClaims
                             on a.Id equals b.OperationClaimId
                             where a.Id == b.OperationClaimId
                             select new OperationClaim() { Id = a.Id, Name = a.Name };

                return result.ToList();
            }
        }
    }
}
