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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (InformationContext context= new InformationContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (InformationContext context = new InformationContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (InformationContext context= new InformationContext())
            {
                return filter == null ?
               context.Set<Brand>().ToList() :
               context.Set<Brand>().Where(filter).ToList();
            }    
        }

        public Brand GetById(int id)
        {
            using (InformationContext context= new InformationContext())
            {
                return context.Set<Brand>().SingleOrDefault(p => p.BrandId == id);
            }
        }

        public void Update(Brand entity)
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
