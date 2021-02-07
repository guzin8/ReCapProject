using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (InformationContext context = new InformationContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (InformationContext context = new InformationContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (InformationContext context = new InformationContext())
            {
                return filter == null ?
                    context.Set<Color>().ToList():
                    context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color GetById(int id)
        {
            using (InformationContext context= new InformationContext())
            {
                return context.Set<Color>().SingleOrDefault(p => p.ColorId == id);
            }
        }

        public void Update(Color entity)
        {
            using (InformationContext context = new InformationContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
