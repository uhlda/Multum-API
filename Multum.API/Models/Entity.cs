using Multum.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multum.API.Models
{
    public abstract class BaseEntity
    {
    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        /* 
         * Uncomment when Automapper is added so that 
         * each enity wil contain an ID
         */

        // public virtual T Id { get; set; }
    }
}