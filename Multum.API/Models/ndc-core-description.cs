using Multum.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Multum.API.Models
{
    [Table("ndc_core_description")]
    public class ndc_core_description : AuditableEntity<long>
    {
        [Key, Required]
        public string ndc_code { get; set; }

    	public int main_multum_drug_code { get; set; }

	    public string otc_status { get; set; }

	    public double inner_package_size { get; set; }

	    public Int32? inner_package_desc_code { get; set; }

	    public double outer_package_size { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? obsolete_date { get; set; }

        public int source_id { get; set; }

        public int orange_book_id { get; set; }

        public string unit_dose_code { get; set; }

        public string repackaged { get; set; }

        public string gbo { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        [Required]
        public int brand_code { get; set; }

        [ForeignKey("brand_code")]
        public ndc_brand_name ndc_brand_name { get; set; }
    }
}