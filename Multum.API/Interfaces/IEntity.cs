using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multum.API.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}