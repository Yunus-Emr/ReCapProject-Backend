using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals on c.CarId equals r.CarId
                             join brand in context.Brands on c.BrandId equals brand.BrandId
                             join customer in context.Customers on r.CustomerId equals customer.CustomerId
                             select new RentalDetailDto
                             {
                                 FullName = customer.CompanyName,
                                 BrandName = brand.BrandName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
