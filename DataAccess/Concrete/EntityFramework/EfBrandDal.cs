using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll()
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brand>().ToList();
            }
        }

        public Brand GetById(int entityId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brand>().FirstOrDefault(p=>p.Id == entityId);
            }
        }

        public void Update(Brand entity)
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
