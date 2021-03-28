using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using(ReCapContext context = new ReCapContext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll()
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().ToList();
            }
        }

        public Car GetById(int entityId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().FirstOrDefault(c=>c.Id==entityId);
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().Where(c=>c.BrandId == brandId).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().Where(c => c.ColorId == colorId).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var entityToUpdate = context.Entry(entity);
                entityToUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
