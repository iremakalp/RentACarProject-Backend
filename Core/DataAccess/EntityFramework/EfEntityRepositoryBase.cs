﻿
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity: class, IEntity,new()
        where TContext: DbContext,new()
    {
        //IDisposable pattern implementation of c#
        //using bittigi anda garbage collector bellekten temizler
        public void Add(TEntity entity)
        {
            using (TContext context= new TContext())
            {
                // referans tut
                var addedEntity = context.Entry(entity);
                // nesne durumunu belirle
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                // referans tut
                var deletedEntity = context.Entry(entity);
                // nesne durumunu belirle
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context= new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // filtre null ise tum listeyi yaz
                // filtre varsa filtreye gore listele
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                // referans tut
                var updatedEntity = context.Entry(entity);
                // nesne durumunu belirle
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
