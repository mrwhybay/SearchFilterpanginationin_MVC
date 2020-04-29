namespace Temp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollegeChoice")]
    public partial class CollegeChoice
    {
        public int id { get; set; }

        public int? Collegeid { get; set; }

        public int? FormNo { get; set; }

        public int? Choicenumber { get; set; }

        public bool? ChoiceLocked { get; set; }

        public int? BranchCode { get; set; }

        public string BranchName { get; set; }

        public string CollegeName { get; set; }

        public virtual College College { get; set; }
    }
}
