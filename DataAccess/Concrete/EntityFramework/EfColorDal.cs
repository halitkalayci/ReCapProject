using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll()
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Color>().ToList();
            }
        }

        public Color GetById(int entityId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Color>().FirstOrDefault(c => c.Id == entityId);
            }
        }

        public void Update(Color entity)
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
