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
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 CarImages = (from cimg in context.CarImages
                                              where cimg.CarId == c.Id
                                              select new CarImage
                                              {
                                                  Id = cimg.Id,
                                                  ImagePath = cimg.ImagePath,
                                                  CarId = c.Id,
                                                  Date = cimg.Date
                                              }).ToList()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetDetailsByBrandId(int brandId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 CarName = c.Name,
                                 ColorName = col.Name,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 CarImages = (from cimg in context.CarImages
                                              where cimg.CarId == c.Id
                                              select new CarImage
                                              {
                                                  Id = cimg.Id,
                                                  ImagePath = cimg.ImagePath,
                                                  CarId = c.Id,
                                                  Date = cimg.Date
                                              }).ToList()
                             };
                return result.ToList();
            }
        }

        public CarDetailDto GetDetailsById(int carId)
        {
            using(ReCapContext context =new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             where c.Id == carId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 CarName = c.Name,
                                 ColorName = col.Name,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 CarImages = (from cimg in context.CarImages
                                             where cimg.CarId == c.Id
                                             select new CarImage
                                             {
                                                 Id = cimg.Id,
                                                 ImagePath = cimg.ImagePath,
                                                 CarId = c.Id,
                                                 Date = cimg.Date
                                             }).ToList()
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
