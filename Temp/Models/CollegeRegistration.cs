namespace Temp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollegeRegistration")]
    public partial class CollegeRegistration
    {
        public int id { get; set; }

        public int CollegeCode { get; set; }

        public string OfficerName { get; set; }

        public long? Mobile { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? paymentdone { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        public string CollegeCategory { get; set; }

        [StringLength(50)]
        public string CollegeType { get; set; }

        public string CollegeFullName { get; set; }

        public virtual College College { get; set; }
    }
}
