using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = c.Id,
                                 CarBrandName = b.Name,
                                 CarColorName = col.Name,
                                 CarDailyPrice = c.DailyPrice,
                                 CarDescription = c.Name,
                                 CarModelYear = c.ModelYear,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate.Value,
                                 UserEmail = u.Email,
                                 UserFirstName = u.FirstName,
                                 UserLastName = u.LastName
                             };
                if (filter != null) result = result.Where(filter);
                return result.ToList();
            }
        }

        public RentalDetailDto GetRentalDetailsById(int rentalId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             where r.Id == rentalId
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = c.Id,
                                 CarBrandName = b.Name,
                                 CarColorName = col.Name,
                                 CarDailyPrice = c.DailyPrice,
                                 CarDescription = c.Name,
                                 CarModelYear = c.ModelYear,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate.Value,
                                 UserEmail = u.Email,
                                 UserFirstName = u.FirstName,
                                 UserLastName = u.LastName
                             };
                return result.FirstOrDefault();
            }
        }
    }
}

