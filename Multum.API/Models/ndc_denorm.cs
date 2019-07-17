namespace Multum.API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ndc_denorm
    {
        [StringLength(20)]
        public string ndc_code { get; set; }

        [StringLength(255)]
        public string brand_description { get; set; }

        public int? main_multum_drug_code { get; set; }

        [StringLength(255)]
        public string route_description { get; set; }

        [StringLength(255)]
        public string dose_form_description { get; set; }

        [StringLength(255)]
        public string product_strength_description { get; set; }

        [StringLength(6)]
        public string drug_id { get; set; }

        public string active_ingredient { get; set; }

        public double? strength_num_amount { get; set; }

        [StringLength(30)]
        public string strength_num { get; set; }

        public double? strength_denom_amount { get; set; }

        [StringLength(30)]
        public string strength_denom { get; set; }

        [StringLength(1)]
        public string csa_schedule { get; set; }

        [StringLength(10)]
        public string j_code { get; set; }

        [StringLength(50)]
        public string j_code_description { get; set; }

        [StringLength(1)]
        public string otc_status { get; set; }

        public double? inner_package_size { get; set; }

        [StringLength(255)]
        public string inner_package_description { get; set; }

        public double? outer_package_size { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? obsolete_date { get; set; }

        [StringLength(120)]
        public string source_desc { get; set; }

        [StringLength(100)]
        public string address1 { get; set; }

        [StringLength(50)]
        public string address2 { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        [StringLength(30)]
        public string province { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(50)]
        public string orange_book_description { get; set; }

        [StringLength(1)]
        public string unit_dose_code { get; set; }

        [StringLength(1)]
        public string repackaged { get; set; }

        [StringLength(1)]
        public string gbo { get; set; }

        public double? awp { get; set; }

        public double? ful { get; set; }

        public double? mdr { get; set; }

        public double? wsc { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
