using Multum.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Multum.API.Models
{
    [Table("ndc_brand_name")]
    public class ndc_brand_name : AuditableEntity<long>
    {
        [Key, Required]
        public int brand_code { get; set; }

        [Required]
        public string brand_description { get; set; }
    }
}