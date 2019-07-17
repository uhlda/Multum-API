using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using Multum.API.Models;

namespace Multum.API.Interfaces
{
    public interface IContext
    {
        DbSet<ndc_core_description> ndc_core_description { get; set; }
        DbSet<ndc_brand_name> ndc_brand_name { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        Task<int> SaveChangesAsync();
    }
}