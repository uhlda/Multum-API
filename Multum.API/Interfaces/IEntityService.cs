using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Multum.API.Models;

namespace Multum.API.Interfaces
{
    public interface IEntityService<T> : IService
      where T : BaseEntity
    {
        Task Create(T entity);
        Task Delete(T entity);
        IEnumerable<T> GetAll();
        Task Update(T entity);
    }
}