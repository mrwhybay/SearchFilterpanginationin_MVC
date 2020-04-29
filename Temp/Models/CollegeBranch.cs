namespace Temp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollegeBranch")]
    public partial class CollegeBranch
    {
        public int id { get; set; }

        public int? collegeid { get; set; }

        public string branchname { get; set; }

        public int? branchcode { get; set; }

        public virtual College College { get; set; }
    }
}
