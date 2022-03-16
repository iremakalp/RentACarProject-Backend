using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,ReCapContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (ReCapContext context= new ReCapContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userClaim in context.UserOperationClaims
                        on operationClaim.Id equals userClaim.OperationClaimId
                    where userClaim.UserId == user.Id
                    select new OperationClaim
                    {
                        Id = operationClaim.Id,
                        Name = operationClaim.Name
                    };
                return result.ToList();
            }
        }
    }
}