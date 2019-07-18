using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multum.API.Interfaces
{
    public interface IEntity<T>
    {
        /* 
         * Uncomment when Automapper is added 
         * so that each enity wil contain an ID
         */

        // T Id { get; set; }
    }
}