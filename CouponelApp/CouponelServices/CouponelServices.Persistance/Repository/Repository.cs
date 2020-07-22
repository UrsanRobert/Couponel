﻿using CouponelServices.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CouponelServices.Persistence.Repository
{
    public abstract class Repository<T> : IRepository<T>
            where T : Entity
    {
        protected readonly CouponelContext context;

        protected Repository(CouponelContext context)
        {
            this.context = context;
        }

        public async Task<T> GetById(Guid id)
            => await this.context.Set<T>().FindAsync(id);

        public async Task Add(T entity)
            => await this.context.Set<T>().AddAsync(entity);

        public void Update(T entity)
            => this.context.Set<T>().Update(entity);

        public void Delete(T entity)
            => this.context.Set<T>().Remove(entity);

        public Task SaveChanges()
            => this.context.SaveChangesAsync();

        public async Task<IList<T>> GetAll()
            => await this.context.Set<T>().ToListAsync();
    }
}
