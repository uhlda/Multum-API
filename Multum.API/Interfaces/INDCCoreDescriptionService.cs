using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multum.API.Services;
using Multum.API.Models;

namespace Multum.API.Interfaces
{
    public interface INDCCoreDescriptionService : IEntityService<ndc_core_description>
    {
        Task<ndc_core_description> GetNDCCoreDescription(string id);
    }
}
