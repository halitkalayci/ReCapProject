using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = br.Name,
                                 CarName = c.Name,
                                 ColorName = col.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
