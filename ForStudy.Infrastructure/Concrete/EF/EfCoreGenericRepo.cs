using ForStudy.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EF
{
    public class EfCoreGenericRepo<T, TContext> : IGenericRepo<T>
        where T : class
        where TContext : DbContext, new()
    {
        public async Task Create(T entity)
        {
            using (var context=new TContext())
            {
                context.Set<T>().Add(entity);
                await context.SaveChangesAsync();
            }
        }
        public async Task Remove(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
            }
        }
        public async Task Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
