namespace Temp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class College_Registration2
    {
        public int id { get; set; }

        public int? collegeid { get; set; }

        public string Address { get; set; }

        public string Locality { get; set; }

        public string District { get; set; }

        [StringLength(50)]
        public string landlinePhone { get; set; }

        public long? Fax { get; set; }

        public long? Mobile { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public int? RTU_Shift1_Code { get; set; }

        public int? RTU_Shift2_Code { get; set; }

        public string DirectorName { get; set; }

        public long? DirectorMobileNumber { get; set; }

        public string OfficerName { get; set; }

        public long? OfficerMobile { get; set; }

        [StringLength(50)]
        public string Regdate { get; set; }

        [Required]
        public string username { get; set; }

        public string CollegeCategory { get; set; }

        public virtual College College { get; set; }
    }
}
