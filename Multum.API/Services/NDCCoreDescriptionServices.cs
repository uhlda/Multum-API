using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Multum.API.Models;
using Multum.API.Interfaces;

namespace Multum.API.Services
{
    public class NDCCoreDescriptionServices : EntityService<ndc_core_description>, INDCCoreDescriptionService
    {
        //IContext _context;
        public NDCCoreDescriptionServices(IContext context)
            : base(context)
        {
            _context = context;
            _dbset = _context.Set<ndc_core_description>();
        }

        public async Task<ndc_core_description> GetNDCCoreDescription(string id)
        {
            ndc_core_description desc = null;

            using (var dbContext = new MultumDBContext())
            {
                desc = await dbContext
                    .ndc_core_description
                    .Include("ndc_brand_name")
                    .FirstOrDefaultAsync(d => d.ndc_code == id);
            }
  
            return desc;
        }
    }
}